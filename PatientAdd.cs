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

        private bool IsSriLankanNICValid(string nic)
        {
            string nicPattern = @"^\d{9}[VvXx]$";
            return Regex.IsMatch(nic, nicPattern);
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

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearInputFields();
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
