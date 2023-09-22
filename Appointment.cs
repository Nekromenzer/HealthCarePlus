using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HealthCarePlus
{

    public partial class AppointmentForm : Form
    {
        private string mysqlCon = "Data source=127.0.0.1; user=root; database=hospital; password= ";
        public AppointmentForm()
        {
            InitializeComponent();
            DisplayAppointments();
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

        private int GetScheduleIDByAppointmentType(int doctorID, string appointmentType)
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string query = "SELECT ScheduleID FROM doctorschedules WHERE DoctorID = @DoctorID AND AppointmentType = @AppointmentType";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DoctorID", doctorID);
                cmd.Parameters.AddWithValue("@AppointmentType", appointmentType);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    return Convert.ToInt32(result);
                }

                return 0;
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

        private void DisplayAppointments()
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

        private string GetDoctorNameById(int doctorId)
        {
            string? doctorName = string.Empty;
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string query = "SELECT FullName FROM doctors WHERE DoctorID = @DoctorID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DoctorID", doctorId);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    doctorName = result.ToString();
                }
            }
            return doctorName;
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

        private string GetAppointmentTypeById(int ScheduleID)
        {
            string? AppointmentType = string.Empty;
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string query = "SELECT AppointmentType FROM doctorschedules WHERE ScheduleID = @ScheduleID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ScheduleID", ScheduleID);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        AppointmentType = reader.GetString("AppointmentType");
                    }
                }
            }
            return AppointmentType;
        }

        private string GetAppointmentTypeByScheduleId(int scheduleId)
        {
            string appointmentType = string.Empty;

            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string query = "SELECT AppointmentType FROM doctorSchedules WHERE ScheduleID = @ScheduleID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ScheduleID", scheduleId);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    appointmentType = result.ToString();
                }
            }

            return appointmentType;
        }

        //format table data col
        private void appointmentTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (appointmentTable.Columns[e.ColumnIndex].Name == "doctorCol")
            {
                if (e.Value != null)
                {
                    string? doctorName = GetDoctorNameById(Convert.ToInt32(e.Value));
                    e.Value = doctorName;
                }
            }
            if (appointmentTable.Columns[e.ColumnIndex].Name == "patientCol")
            {
                if (e.Value != null)
                {
                    string? patientName = GetPatientNameById(Convert.ToInt32(e.Value));
                    e.Value = patientName;
                }
            }
            if (appointmentTable.Columns[e.ColumnIndex].Name == "scheduleCol")
            {
                if (e.Value != null)
                {
                    string? schduleName = GetAppointmentTypeByScheduleId(Convert.ToInt32(e.Value));
                    e.Value = schduleName;
                }
            }
        }

        private void appointmentTable_SelectionChanged(object sender, EventArgs e)
        {
            if (appointmentTable.SelectedRows.Count > 0)
            {
                submitBtn.Enabled = false;
                updateBtn.Enabled = true;
                deleteBtn.Enabled = true;
                ClearFields();
            }
            else
            {
                submitBtn.Enabled = true;
                updateBtn.Enabled = false;
                deleteBtn.Enabled = false;
            }
        }

        private void SyncDataWithInput(DataGridViewRow selectedRow)
        {
            if (selectedRow != null)
            {
                string? doctorName = GetDoctorNameById(Convert.ToInt32(selectedRow.Cells["doctorCol"].Value.ToString()));
                string? patientName = selectedRow.Cells["patientCol"].Value.ToString();
                string? stateVal = selectedRow.Cells["statusCol"].Value.ToString();
                string? scheduleId = GetAppointmentTypeById(Convert.ToInt32(selectedRow.Cells["scheduleCol"].Value.ToString()));
                DateTime dateVal = Convert.ToDateTime(selectedRow.Cells["dateCol"].Value);
                if (selectedRow.Cells["timeCol"].Value != null)
                {
                    if (TimeSpan.TryParse(selectedRow.Cells["timeCol"].Value.ToString(), out TimeSpan endTimeValue))
                    {
                        time.Value = DateTime.Today.Add(endTimeValue);
                    }
                    else
                    {
                        time.Value = DateTime.Now;
                    }
                }
                else
                {
                    time.Value = DateTime.Now;
                }
                doctor.Enabled = false;
                doctor.Text = doctorName;
                patient.SelectedIndex = int.Parse(patientName);
                state.SelectedItem = stateVal;
                schedule.Enabled = false;
                schedule.Text = scheduleId;
                date.Value = dateVal;
            }
            else
            {
                ClearFields();
            }
        }

        private void appointmentTable_CellClick(object sender, EventArgs e)
        {
            // Handle the selection change event of the DataGridView
            if (appointmentTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = appointmentTable.SelectedRows[0];
                SyncDataWithInput(selectedRow);
            }
            else
            {
                ClearFields();
            }
        }

        private void UpdateAppointment(int appointmentId, int doctorId, int patientId, string state, int scheduleId, DateTime date, DateTime time)
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                try
                {
                    conn.Open();

                    string updateQuery = "UPDATE appointments " +
                                         "SET DoctorID = @DoctorID, PatientID = @PatientID, Status = @Status, ScheduleID = @ScheduleID, Date = @Date, Time = @Time " +
                                         "WHERE AppointmentID = @AppointmentID";

                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@DoctorID", doctorId);
                    cmd.Parameters.AddWithValue("@PatientID", patientId);
                    cmd.Parameters.AddWithValue("@Status", state);
                    cmd.Parameters.AddWithValue("@ScheduleID", scheduleId);
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.Parameters.AddWithValue("@Time", time);
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Appointment updated successfully.");
                        ClearFields();
                        DisplayAppointments();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update appointment.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (appointmentTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = appointmentTable.SelectedRows[0];
                int appointmentId = Convert.ToInt32(selectedRow.Cells["idCol"].Value);
                int selectedDoctorID = ((DoctorNameFunc)doctor.SelectedItem).DoctorID;
                int selectedPatientID = ((PatientNameFunc)patient.SelectedItem).PatientID;
                string? stateVal = state.SelectedItem.ToString();
                string? selectedAppointmentType = schedule.SelectedItem.ToString();
                int selectedScheduleID = GetScheduleIDByAppointmentType(selectedDoctorID, selectedAppointmentType);
                DateTime dateVal = date.Value;
                DateTime timeVal = time.Value;
                if (selectedDoctorID == 0 || selectedPatientID == 0 || string.IsNullOrWhiteSpace(stateVal) || selectedScheduleID == 0)
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }
                // Call the update function with the updated values
                UpdateAppointment(appointmentId, selectedDoctorID, selectedPatientID, stateVal, selectedScheduleID, dateVal, timeVal);
            }
            else
            {
                MessageBox.Show("Please select an appointment to update.");
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected id
                int selectedDoctorID = ((DoctorNameFunc)doctor.SelectedItem).DoctorID;
                int selectedPatientID = ((PatientNameFunc)patient.SelectedItem).PatientID;
                string? selectedState = state.SelectedItem.ToString();
                // schdule id 
                string? selectedAppointmentType = schedule.SelectedItem.ToString();
                int selectedScheduleID = GetScheduleIDByAppointmentType(selectedDoctorID, selectedAppointmentType);
                DateTime selectedDate = date.Value;
                DateTime selectedTime = time.Value;
                // Fixed price value
                decimal fixedPrice = 3500;
                // Check if any required fields are empty
                if (selectedDoctorID == 0 || selectedPatientID == 0 || string.IsNullOrWhiteSpace(selectedState) || selectedScheduleID == 0)
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                string insertQuery = "INSERT INTO appointments (DoctorID, PatientID, Status, ScheduleID, Date, Time, Price) " +
                                     "VALUES (@DoctorID, @PatientID, @Status, @ScheduleID, @Date, @Time, @Price)";

                using (MySqlConnection conn = new MySqlConnection(mysqlCon))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@DoctorID", selectedDoctorID);
                    cmd.Parameters.AddWithValue("@PatientID", selectedPatientID);
                    cmd.Parameters.AddWithValue("@Status", selectedState);
                    cmd.Parameters.AddWithValue("@ScheduleID", selectedScheduleID);
                    cmd.Parameters.AddWithValue("@Date", selectedDate);
                    cmd.Parameters.AddWithValue("@Time", selectedTime);
                    cmd.Parameters.AddWithValue("@Price", fixedPrice);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Appointment added successfully.");
                        ClearFields();
                        DisplayAppointments();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add appointment.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            ClearSelectionWithDelay();
        }

        private void DeleteAppointment(int appointmentId)
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                try
                {
                    conn.Open();

                    string deleteQuery = "DELETE FROM appointments WHERE AppointmentID = @AppointmentID";

                    MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Appointment deleted successfully.");
                        ClearFields();
                        DisplayAppointments();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete appointment.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (appointmentTable.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = appointmentTable.SelectedRows[0];
                    int appointmentId = Convert.ToInt32(selectedRow.Cells["idCol"].Value);
                    DeleteAppointment(appointmentId);
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to delete.");
            }
        }

        private void ClearFields()
        {
            date.Value = DateTime.Now;
            time.Value = DateTime.Now;
            schedule.Enabled = true;
            doctor.Enabled = true;
            schedule.Text = "";
            doctor.Text = "";
            patient.SelectedIndex = -1;
            doctor.SelectedIndex = -1;
            schedule.SelectedIndex = -1;
            state.SelectedIndex = -1;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadDoctorSchedules();
            ClearSelectionWithDelay();
        }

        private void doctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDoctorSchedules();
        }

        private void appointmentTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
