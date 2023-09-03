using System.Data;
using MySql.Data.MySqlClient;

namespace HealthCarePlus
{
    public partial class DoctorSchdulesForm : Form

    {
        private string mysqlCon = "Data source=127.0.0.1; user=root; database=hospital; password= ";
        public DoctorSchdulesForm()
        {
            InitializeComponent();
            DisplayDoctorSchedules();
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
                return -1;
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
                return -1;
            }
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

        private void patients_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlCon))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT PatientID, FullName FROM patients", conn);
                    AutoCompleteStringCollection str_coll = new AutoCompleteStringCollection();
                    using (MySqlDataReader myreader = cmd.ExecuteReader())
                    {
                        while (myreader.Read())
                        {
                            str_coll.Add(myreader.GetString(1));
                        }
                    }
                    patients.AutoCompleteCustomSource = str_coll;
                    patients.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    patients.AutoCompleteMode = AutoCompleteMode.Suggest;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here, e.g., log it or display an error message
                MessageBox.Show("An error occurred: " + ex.Message);
            }
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
        private bool UpdateDoctorSchedule(string primaryKeyValue, int doctorId, int patientId, DateTime startTime, DateTime endTime, string appointmentType, string location, DateTime scheduleDate, string notes)
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                try
                {
                    conn.Open();
                    string updateQuery = "UPDATE doctorschedules SET DoctorID = @DoctorID, PatientID = @PatientID, StartTime = @StartTime, EndTime = @EndTime, AppointmentType = @AppointmentType, Location = @Location, ScheduleDate = @ScheduleDate, Notes = @Notes WHERE ScheduleID = @PrimaryKeyValue";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@DoctorID", doctorId);
                    cmd.Parameters.AddWithValue("@PatientID", patientId);
                    cmd.Parameters.AddWithValue("@StartTime", startTime);
                    cmd.Parameters.AddWithValue("@EndTime", endTime);
                    cmd.Parameters.AddWithValue("@AppointmentType", appointmentType);
                    cmd.Parameters.AddWithValue("@Location", location);
                    cmd.Parameters.AddWithValue("@ScheduleDate", scheduleDate);
                    cmd.Parameters.AddWithValue("@Notes", notes);
                    cmd.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Update successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    return rowsAffected > 0;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
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
                    DisplayDoctorSchedules();
                }
                else
                {
                    MessageBox.Show("Failed to insert schedule.");
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (doctoSchdulesTable.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = doctoSchdulesTable.SelectedRows[0];

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

                // Update the row in the database
                if (UpdateDoctorSchedule(selectedRow.Cells["ScheduleID"].Value.ToString(), doctorIdSelected, patientId, selectedStartTime, selectedEndTime, selectedAppointmentType, selectedLocation, selectedDate, selectedNote))
                {
                    // Update successful, refresh
                    DisplayDoctorSchedules();
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (doctoSchdulesTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = doctoSchdulesTable.SelectedRows[0];
                string primaryKeyValue = selectedRow.Cells["ScheduleID"].Value.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to delete this schedule?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (DeleteDoctorSchedule(primaryKeyValue))
                    {
                        doctoSchdulesTable.Rows.Remove(selectedRow);
                        MessageBox.Show("Schedule deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete schedule.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a schedule to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
            doctoSchdulesTable.ClearSelection();
        }
        private void doctoSchdulesTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (doctoSchdulesTable.Columns[e.ColumnIndex].Name == "PatientID")
            {
                if (e.Value != null)
                {
                    string patientName = GetPatientNameById(Convert.ToInt32(e.Value));
                    e.Value = patientName;
                }
            }

            if (doctoSchdulesTable.Columns[e.ColumnIndex].Name == "dataGridViewTextBoxColumn1")
            {
                if (e.Value != null)
                {
                    string? doctorName = GetDoctorNameById(Convert.ToInt32(e.Value));
                    e.Value = doctorName;
                }
            }
        }

        private void DisplayDoctorSchedules()
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string query = "SELECT * FROM doctorschedules";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // bind table
                    doctoSchdulesTable.DataSource = dataTable;
                }
            }
        }

        private void doctoSchdulesTable_SelectionChanged(object sender, EventArgs e)
        {
            if (doctoSchdulesTable.SelectedRows.Count > 0)
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
        private void doctoSchdulesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dataGridView = (DataGridView)sender;
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                // Deselect any previously selected rows
                dataGridView.ClearSelection();

                // Select the clicked row
                selectedRow.Selected = true;

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = doctoSchdulesTable.Rows[e.RowIndex];

                    doctorId.Text = GetDoctorNameById(Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn1"].Value.ToString()));
                    patients.Text = GetPatientNameById(Convert.ToInt32(row.Cells["PatientID"].Value.ToString()));
                    if (row.Cells["dataGridViewTextBoxColumn3"].Value != null)
                    {
                        if (TimeSpan.TryParse(row.Cells["dataGridViewTextBoxColumn3"].Value.ToString(), out TimeSpan startTimeValue))
                        {
                            startTime.Value = DateTime.Today.Add(startTimeValue);
                        }
                        else
                        {
                            startTime.Value = DateTime.Now;
                        }
                    }
                    else
                    {
                        startTime.Value = DateTime.Now;
                    }

                    if (row.Cells["dataGridViewTextBoxColumn4"].Value != null)
                    {
                        if (TimeSpan.TryParse(row.Cells["dataGridViewTextBoxColumn4"].Value.ToString(), out TimeSpan endTimeValue))
                        {
                            endTime.Value = DateTime.Today.Add(endTimeValue);
                        }
                        else
                        {
                            endTime.Value = DateTime.Now;
                        }
                    }
                    else
                    {
                        endTime.Value = DateTime.Now;
                    }

                    string? cellValue = row.Cells["dataGridViewTextBoxColumn2"].Value.ToString();
                    int index = appointmentType.FindString(cellValue);
                    appointmentType.SelectedIndex = index != -1 ? index : -1;

                    string? locationCellValue = row.Cells["dataGridViewTextBoxColumn5"].Value.ToString();
                    int locationIndex = location.FindString(locationCellValue);
                    location.SelectedIndex = locationIndex != -1 ? locationIndex : -1;

                    if (row.Cells["ScheduleDate"].Value != null)
                    {
                        date.Value = (DateTime)row.Cells["ScheduleDate"].Value;
                    }
                    else
                    {
                        date.Value = DateTime.Now;
                    }
                    note.Text = row.Cells["Notes"].Value.ToString();
                }
            }
        }
        private void doctoSchdulesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool DeleteDoctorSchedule(string primaryKeyValue)
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                try
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM doctorschedules WHERE ScheduleID = @PrimaryKeyValue";
                    MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);
                    cmd.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void appointmentType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
