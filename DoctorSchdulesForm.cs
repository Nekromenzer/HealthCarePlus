using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HealthCarePlus
{
    public partial class DoctorSchdulesForm : Form

    {
        private string mysqlCon = "Data source=127.0.0.1; user=root; database=hospital; password= ";
        public DoctorSchdulesForm()
        {
            InitializeComponent();
        }

        private int GetDoctorIdByName(string doctorName)
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string query = "SELECT DoctorID FROM doctors WHERE FullName = @FullName";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FullName", doctorName);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                return -1; // Return a value to indicate that the doctor was not found
            }
        }

        private int GetPatientIdByName(string patientName)
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string query = "SELECT PatientID FROM patients WHERE FullName = @FullName";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FullName", patientName);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                return -1; // Return a value to indicate that the patient was not found
            }
        }


        private void doctorId_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(mysqlCon);
            MySqlCommand cmd = new MySqlCommand("Select DoctorId,FullName From doctors", conn);
            conn.Open();
            AutoCompleteStringCollection str_coll = new AutoCompleteStringCollection();
            MySqlDataReader myreader = cmd.ExecuteReader();
            while (myreader.Read())
            {
                str_coll.Add(myreader.GetString(1));
            }
            doctorId.AutoCompleteCustomSource = str_coll;
            doctorId.AutoCompleteSource = AutoCompleteSource.CustomSource;
            doctorId.AutoCompleteMode = AutoCompleteMode.Suggest;
            conn.Close();
        }

        private void startTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void patients_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(mysqlCon);
            MySqlCommand cmd = new MySqlCommand("SELECT PatientID, FullName FROM patients", conn);
            conn.Open();
            AutoCompleteStringCollection str_coll = new AutoCompleteStringCollection();
            MySqlDataReader myreader = cmd.ExecuteReader();
            while (myreader.Read())
            {
                str_coll.Add(myreader.GetString(1));
            }
            patients.AutoCompleteCustomSource = str_coll;
            patients.AutoCompleteSource = AutoCompleteSource.CustomSource;
            patients.AutoCompleteMode = AutoCompleteMode.Suggest;
            conn.Close();
        }

        private void appointmentType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void location_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void note_TextChanged(object sender, EventArgs e)
        {

        }

        private void endTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ClearFields()
        {
            doctorId.Text = "";
            patients.Text = "";
            startTime.Value = DateTime.Now;
            endTime.Value = DateTime.Now;
            appointmentType.SelectedIndex = -1;
            location.SelectedIndex = -1;
            date.Value = DateTime.Now;
            note.Text = "";
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string selectedDoctorName = doctorId.Text;
            string selectedPatientName = patients.Text;
            DateTime selectedStartTime = startTime.Value;
            DateTime selectedEndTime = endTime.Value;
            string selectedAppointmentType = appointmentType.SelectedItem.ToString();
            string selectedLocation = location.SelectedItem.ToString();
            DateTime selectedDate = date.Value;
            string selectedNote = note.Text;

            int doctorIdSelected = GetDoctorIdByName(selectedDoctorName);
            int patientId = GetPatientIdByName(selectedPatientName);

            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string insertQuery = "INSERT INTO doctorschedules (DoctorID, PatientID, StartTime, EndTime, AppointmentType, Location, ScheduleDate, Notes) " +
                                     "VALUES (@DoctorID, @PatientID, @StartTime, @EndTime, @AppointmentType, @Location, @ScheduleDate, @Notes)";
                MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@DoctorID", doctorIdSelected);
                cmd.Parameters.AddWithValue("@PatientID", patientId);
                cmd.Parameters.AddWithValue("@StartTime", selectedStartTime);
                cmd.Parameters.AddWithValue("@EndTime", selectedEndTime);
                cmd.Parameters.AddWithValue("@AppointmentType", selectedAppointmentType);
                cmd.Parameters.AddWithValue("@Location", selectedLocation);
                cmd.Parameters.AddWithValue("@ScheduleDate", selectedDate);
                cmd.Parameters.AddWithValue("@Notes", selectedNote);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Schedule inserted successfully.");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to insert schedule.");
                }
            }
        }
    }
}
