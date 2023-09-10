using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCarePlus
{
    public partial class DoctorAddForm : Form
    {
        private string mysqlCon = "Data source=127.0.0.1; user=root; database=hospital; password= ";
        public DoctorAddForm()
        {
            InitializeComponent();
            DisplayDoctorList();
            ClearSelectionWithDelay();
        }

        private async void ClearSelectionWithDelay()
        {
            await Task.Delay(1000);
            doctorTable.ClearSelection();
        }

        private void DisplayDoctorList()
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string query = "SELECT * FROM doctors";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // bind table
                    doctorTable.DataSource = dataTable;
                }
            }
        }

        private void ClearFormFields()
        {
            fullName.Text = "";
            phone.Text = "";
            email.Text = "";
            location.SelectedIndex = -1;
            expertise.SelectedIndex = -1;
            otherDetails.Text = "";
            available.Checked = false;
        }


        private void doctorTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void doctorTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = doctorTable.Rows[e.RowIndex];
                fullName.Text = row.Cells["doctorFullName"].Value.ToString();
                phone.Text = row.Cells["doctorContactNumber"].Value.ToString();
                email.Text = row.Cells["doctorEmail"].Value.ToString();
                string? locationCellValue = row.Cells["doctorLocation"].Value.ToString();
                int locationIndex = location.FindString(locationCellValue);
                location.SelectedIndex = locationIndex != -1 ? locationIndex : -1;
                expertise.SelectedItem = row.Cells["doctorExpertise"].Value.ToString();
                available.Checked = row.Cells["doctorAvailability"].Value.ToString() == "Available";
                otherDetails.Text = row.Cells["doctorOtherDetails"].Value.ToString();
            }
        }

        private void doctorTable_SelectionChanged(object sender, EventArgs e)
        {
            if (doctorTable.SelectedRows.Count > 0)
            {
                submitBtn.Enabled = false;
                updateBtn.Enabled = true;
                deleteBtn.Enabled = true;
                ClearFormFields();
            }
            else
            {
                submitBtn.Enabled = true;
                updateBtn.Enabled = false;
                deleteBtn.Enabled = false;
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(fullName.Text) ||
                string.IsNullOrWhiteSpace(email.Text) ||
                string.IsNullOrWhiteSpace(location.SelectedItem.ToString()) ||
                string.IsNullOrWhiteSpace(expertise.SelectedItem.ToString()))
            {
                MessageBox.Show("All fields are required.");
                return false;
            }

            if (!IsValidSriLankanPhoneNumber(phone.Text))
            {
                MessageBox.Show("Invalid phone number");
            }

            if (!IsValidEmail(email.Text))
            {
                MessageBox.Show("Invalid email address.");
                return false;
            }
            return true;
        }

        static bool IsValidSriLankanPhoneNumber(string phoneNumber)
        {
            string pattern = @"^0\d{1,2} \d{7,8}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            string doctorName = fullName.Text;
            string contactNumber = phone.Text;
            string doctorEmail = email.Text;
            string? doctorLocation = location.SelectedItem.ToString();
            string? doctorExpertise = expertise.SelectedItem.ToString();
            string doctorAvailable = available.Checked ? "Available" : "Not Available";
            string doctorOtherDetails = otherDetails.Text;

            if (ValidateInputs())

            {
                using (MySqlConnection conn = new MySqlConnection(mysqlCon))
                {
                    conn.Open();

                    string insertQuery = "INSERT INTO doctors (FullName, ContactNumber, Email, Location, Expertise,Availability,OtherDetails) " +
                                         "VALUES (@FullName, @ContactNumber, @Email, @Location, @Expertise,@Availability,@OtherDetails)";

                    MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@FullName", doctorName);
                    cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                    cmd.Parameters.AddWithValue("@Email", doctorEmail);
                    cmd.Parameters.AddWithValue("@Location", doctorLocation);
                    cmd.Parameters.AddWithValue("@Expertise", doctorExpertise);
                    cmd.Parameters.AddWithValue("@Availability", doctorAvailable);
                    cmd.Parameters.AddWithValue("@OtherDetails", doctorOtherDetails);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Doctor added successfully.");
                DisplayDoctorList();
                ClearFormFields();
            }
           
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearFormFields();
            doctorTable.ClearSelection();
        }

        private bool DeleteDoctor(string primaryKeyValue)
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                try
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM doctors WHERE DoctorID = @PrimaryKeyValue";
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (doctorTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = doctorTable.SelectedRows[0];
                string? primaryKeyValue = selectedRow.Cells["DoctorID"].Value.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Doctor?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (DeleteDoctor(primaryKeyValue))
                    {
                        doctorTable.Rows.Remove(selectedRow);
                        MessageBox.Show("doctor deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete doctor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a doctor to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool UpdateDoctor(int doctorId, string fullName, string contactNumber, string email, string location, string expertise, string otherDetails, string doctorAvailable)
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                try
                {
                    conn.Open();
                    string updateQuery = "UPDATE Doctors SET FullName = @FullName, ContactNumber = @ContactNumber, Email = @Email, Location = @Location, Expertise = @Expertise, OtherDetails = @OtherDetails,Availability =@Availability WHERE DoctorID = @DoctorID";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@DoctorID", doctorId);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Location", location);
                    cmd.Parameters.AddWithValue("@Expertise", expertise);
                    cmd.Parameters.AddWithValue("@OtherDetails", otherDetails);
                    cmd.Parameters.AddWithValue("@Availability", doctorAvailable);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (doctorTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = doctorTable.SelectedRows[0];
                int doctorId = Convert.ToInt32(selectedRow.Cells["DoctorID"].Value);

                string doctorName = fullName.Text;
                string contactNumber = phone.Text;
                string doctorEmail = email.Text;
                string? doctorLocation = location.SelectedItem.ToString();
                string? doctorExpertise = expertise.SelectedItem.ToString();
                string doctorAvailable = available.Checked ? "Available" : "Not Available";
                string doctorOtherDetails = otherDetails.Text;

                if (ValidateInputs())
                {
                    if (UpdateDoctor(doctorId, doctorName, contactNumber, doctorEmail, doctorLocation, doctorExpertise, doctorOtherDetails, doctorAvailable))
                    {
                        MessageBox.Show("Doctor information updated successfully.");
                        DisplayDoctorList();
                        ClearFormFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update doctor information.");
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Please select a doctor from the list to update.");
            }
        }
    }
}
