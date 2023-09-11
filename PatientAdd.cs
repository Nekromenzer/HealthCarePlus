using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCarePlus
{

    public partial class PatientAddForm : Form
    {
        private string mysqlCon = "Data source=127.0.0.1; user=root; database=hospital; password= ";
        string patientGender;
        public PatientAddForm()
        {
            InitializeComponent();
            DisplayPatientList();
            ClearSelectionWithDelay();
        }

        private void DisplayPatientList()
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string query = "SELECT * FROM patients";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // bind table
                    patientTable.DataSource = dataTable;
                }
            }
        }

        private void PatientAddForm_Load(object sender, EventArgs e)
        {

        }

        private async void ClearSelectionWithDelay()
        {
            await Task.Delay(1000);
            patientTable.ClearSelection();
        }

        private bool IsSriLankanNICValid(string nic)
        {
            string nicPattern = @"^\d{9}[VvXx]$";
            if (Regex.IsMatch(nic, nicPattern))
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlCon))
                {
                    connection.Open();

                    string checkDuplicateQuery = "SELECT COUNT(*) FROM Patients WHERE NIC = @NIC";
                    MySqlCommand cmd = new MySqlCommand(checkDuplicateQuery, connection);
                    cmd.Parameters.AddWithValue("@NIC", nic);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("NIC already exists. Please enter a unique NIC.");
                        return false;
                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show("Invalid NIC format. Please enter a valid NIC.");
                return false;
            }
        }


        private void submitBtn_Click(object sender, EventArgs e)
        {
            string fullName = fullNameInput.Text;
            string phoneNumber = phoneInput.Text;
            string dateOfBirth = dobInput.Value.ToString("yyyy-MM-dd");
            string nicNumber = nicInput.Text;
            string patientAddress = addressInput.Text;

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(patientAddress) || string.IsNullOrWhiteSpace(nicNumber) || string.IsNullOrWhiteSpace(patientGender))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (!IsSriLankanNICValid(nicNumber))
            {
                MessageBox.Show("Invalid NIC number. Please enter a valid Sri Lankan NIC number.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                try
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO Patients (FullName, DateOfBirth, Gender, ContactNumber, Address, NIC) " +
                                         "VALUES (@FullName, @DateOfBirth, @Gender, @ContactNumber, @Address, @NIC)";
                    MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    cmd.Parameters.AddWithValue("@Gender", patientGender);
                    cmd.Parameters.AddWithValue("@ContactNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@Address", patientAddress);
                    cmd.Parameters.AddWithValue("@NIC", nicNumber);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Patient added successfully.");
                        ClearInputFields();
                        DisplayPatientList();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add patient.");
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
            if (patientTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = patientTable.SelectedRows[0];

                int patientID = Convert.ToInt32(selectedRow.Cells["PatientID"].Value);

                string fullName = fullNameInput.Text;
                string phoneNumber = phoneInput.Text;
                DateTime dateOfBirth = dobInput.Value;
                string nicNumber = nicInput.Text;
                string address = addressInput.Text;

                string gender = "Male";
                if (male.Checked)
                {
                    gender = "Male";
                }
                else if (female.Checked)
                {
                    gender = "Female";
                }

                if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(nicNumber) || string.IsNullOrWhiteSpace(patientGender))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                if (!IsSriLankanNICValid(nicNumber))
                {
                    MessageBox.Show("Invalid NIC number. Please enter a valid Sri Lankan NIC number.");
                    return;
                }

                using (MySqlConnection connection = new MySqlConnection(mysqlCon))
                {
                    connection.Open();

                    string updateQuery = "UPDATE Patients SET FullName = @FullName, DateOfBirth = @DateOfBirth, Gender = @Gender, " +
                                         "ContactNumber = @ContactNumber, Address = @Address, NIC = @NIC WHERE PatientID = @PatientID";

                    MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                    cmd.Parameters.AddWithValue("@PatientID", patientID);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@ContactNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@NIC", nicNumber);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Patient record updated successfully.");
                        DisplayPatientList();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update patient record.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a patient record to update.");
            }
        }

        private bool DeletePatient(string primaryKeyValue)
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string deleteQuery = "DELETE FROM patients WHERE PatientID = @PrimaryKeyValue";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);
                    cmd.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (patientTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = patientTable.SelectedRows[0];

                // Check if the "id" cell value is not null and not empty
                string primaryKeyValue = selectedRow.Cells["id"].Value?.ToString();

                if (!string.IsNullOrEmpty(primaryKeyValue))
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this Patient?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        if (DeletePatient(primaryKeyValue))
                        {
                            patientTable.Rows.Remove(selectedRow);
                            MessageBox.Show("Patient deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selected patient does not have a valid ID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a patient to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            patientTable.ClearSelection();
        }

        private void patientTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = patientTable.Rows[e.RowIndex];

                fullNameInput.Text = row.Cells["name"].Value.ToString();
                phoneInput.Text = row.Cells["contact"].Value.ToString();
                dobInput.Value = Convert.ToDateTime(row.Cells["dob"].Value);
                nicInput.Text = row.Cells["nic"].Value.ToString();
                addressInput.Text = row.Cells["address"].Value.ToString();
                if (row.Cells["gender"].Value.ToString() == "Male")
                {
                    male.Checked = true;
                    female.Checked = false;
                }
                else
                {
                    female.Checked = true;
                    male.Checked = false;
                }
                // genderInput.SelectedItem = row.Cells["GenderColumn"].Value.ToString(); // Assuming ComboBox
            }
        }
        private void fullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderInput_Enter(object sender, EventArgs e)
        {

        }

        private void ClearInputFields()
        {
            fullNameInput.Text = "";
            phoneInput.Text = "";
            nicInput.Text = "";
            addressInput.Text = "";
            patientGender = "";
            fullNameInput.Focus();
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            patientGender = "Male";
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            patientGender = "Female";
        }
    }
}
