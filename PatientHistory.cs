using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCarePlus
{
    public partial class PatientHsitory : Form
    {
        private string mysqlCon = "Data source=127.0.0.1; user=root; database=hospital; password= ";
        public PatientHsitory()
        {
            InitializeComponent();
            LoadPatients();
            // lab results
            LoadLabResults(-1);

            ClearSelectionWithDelay();
        }

        //clean selection
        private async void ClearSelectionWithDelay()
        {
            await Task.Delay(1000);
            labResultsTable.ClearSelection();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private string GetPatientNameById(int patientId)
        {
            string? patientName = string.Empty;
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string query = "SELECT FullName FROM patients WHERE PatientID = @PatientID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PatientID", patientId);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    patientName = result.ToString();
                }
            }
            return patientName;
        }

        private string GetUserNameById(int userId)
        {
            string? userName = string.Empty;
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string query = "SELECT FullName FROM userstable WHERE UserID = @UserID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    userName = result.ToString();
                }
            }
            return userName;
        }


        // patient class
        public class PatientInfo
        {
            public int PatientID { get; set; }
            public string? FullName { get; set; }

            public override string ToString()
            {
                return FullName;
            }
        }

        // load patients
        private void LoadPatients()
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT PatientID, FullName FROM patients";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        patient.Items.Clear();
                        while (reader.Read())
                        {
                            int patientID = reader.GetInt32("PatientID");
                            string fullName = reader.GetString("FullName");
                            PatientInfo patientInfo = new PatientInfo { PatientID = patientID, FullName = fullName };
                            patient.Items.Add(patientInfo);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        // fetch lab results
        private void LoadLabResults(int patientID)
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                try
                {
                    conn.Open();
                    string query;

                    if (patientID == -1)
                    {
                        query = "SELECT LabResultText, LabResultDate, LabTechnicianID FROM labresults";
                    }
                    else
                    {
                        query = "SELECT LabResultText, LabResultDate, LabTechnicianID FROM labresults WHERE PatientID = @PatientID";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    if (patientID != 0)
                    {
                        cmd.Parameters.AddWithValue("@PatientID", patientID);
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        labResultsTable.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        //format lab results
        private void labResultsTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (labResultsTable.Columns[e.ColumnIndex].Name == "labTechnicianCol")
            {
                if (e.Value != null)
                {
                    string? userNmae = GetUserNameById(Convert.ToInt32(e.Value));
                    e.Value = userNmae;
                }
            }
            if (labResultsTable.Columns[e.ColumnIndex].Name == "nameCol")
            {
                if (e.Value != null)
                {
                    string? patientName = GetPatientNameById(Convert.ToInt32(e.Value));
                    e.Value = patientName;
                }
            }
        }

        private void patient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (patient.SelectedItem != null)
            {
                int patientID = ((PatientInfo)patient.SelectedItem).PatientID;
                LoadLabResults(patientID);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            patient.SelectedIndex = -1;
            LoadLabResults(-1);
        }
    }
}
