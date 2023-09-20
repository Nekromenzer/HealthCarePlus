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
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public class PatientInfo
        {
            public int PatientID { get; set; }
            public string FullName { get; set; }

            public override string ToString()
            {
                return FullName;
            }
        }

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
        private void patient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            patient.SelectedIndex = -1;
        }
    }
}
