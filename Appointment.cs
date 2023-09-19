using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCarePlus
{

    public partial class AppointmentForm : Form
    {
        private string mysqlCon = "Data source=127.0.0.1; user=root; database=hospital; password= ";
        public AppointmentForm()
        {
            InitializeComponent();
            DisplayDoctorSchedules();
            ClearSelectionWithDelay();
            //get doctors
            LoadDoctorNames();
            // get schdules
            LoadDoctorSchedules();
            //get patient list
            LoadPatients();

        }

        public class DoctorNameFunc
        {
            public int DoctorID { get; set; }
            public string? FullName { get; set; }
            public override string ToString()
            {
                return FullName;
            }
        }

        public class PatientNameFunc
        {
            public int PatientID { get; set; }
            public string? FullName { get; set; }
            public override string ToString()
            {
                return FullName;
            }
        }

        // get doctors who has schedule
        private void LoadDoctorNames()
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ds.DoctorID, d.FullName FROM doctorschedules ds " +
                                   "INNER JOIN doctors d ON ds.DoctorID = d.DoctorID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    // check duplicates of doctor name
                    HashSet<string> uniqueDoctorNames = new HashSet<string>();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int doctorID = reader.GetInt32("DoctorID");
                            string fullName = reader.GetString("FullName");
                            if (!uniqueDoctorNames.Contains(fullName))
                            {
                                DoctorNameFunc doctorName = new DoctorNameFunc { DoctorID = doctorID, FullName = fullName };
                                doctor.Items.Add(doctorName);

                                // Add the doctor name to the HashSet to prevent duplicates
                                uniqueDoctorNames.Add(fullName);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        // get schedule for relevent doctor or get all 
        private void LoadDoctorSchedules()
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                try
                {
                    conn.Open();

                    string query;
                    MySqlCommand cmd;

                    if (doctor.SelectedItem != null)
                    {
                        // If a doctor is selected, get schedules for that doctor
                        int selectedDoctorID = ((DoctorNameFunc)doctor.SelectedItem).DoctorID;
                        query = "SELECT DISTINCT ds.AppointmentType FROM doctorschedules ds " +
                                "WHERE ds.DoctorID = @DoctorID";
                        cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@DoctorID", selectedDoctorID);
                    }
                    else
                    {
                        // If no doctor is selected, display all schedules
                        query = "SELECT DISTINCT ds.AppointmentType FROM doctorschedules ds";
                        cmd = new MySqlCommand(query, conn);
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        schedule.Items.Clear();
                        while (reader.Read())
                        {
                            string appointmentTypeName = reader.GetString("AppointmentType");
                            schedule.Items.Add(appointmentTypeName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        // get patient list
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
                        patient.Items.Clear(); // Clear existing items

                        while (reader.Read())
                        {
                            int patientID = reader.GetInt32("PatientID");
                            string fullName = reader.GetString("FullName");
                            PatientNameFunc patientName = new PatientNameFunc { PatientID = patientID, FullName = fullName };
                            patient.Items.Add(patientName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
       
        private void DisplayDoctorSchedules()
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string query = "SELECT * FROM appointments";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // bind table
                    appointmentTable.DataSource = dataTable;
                }
            }
        }

        private async void ClearSelectionWithDelay()
        {
            await Task.Delay(1000);
            appointmentTable.ClearSelection();
        }

        private void appointmentTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {

        }

        private void doctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDoctorSchedules();
        }
    }
}
