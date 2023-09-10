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
    public partial class DoctorAddForm : Form
    {
        private string mysqlCon = "Data source=127.0.0.1; user=root; database=hospital; password= ";
        public DoctorAddForm()
        {
            InitializeComponent();
            DisplayDoctorList();
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
            otherDetails.Text = " ";
        }


        private void doctorTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void submitBtn_Click(object sender, EventArgs e)
        {
            string doctorName = fullName.Text;
            string contactNumber = phone.Text;
            string doctorEmail = email.Text;
            string? doctorLocation = location.SelectedItem.ToString();
            string? doctorExpertise = expertise.SelectedItem.ToString();
            string doctorAvailable = available.Checked ? "available" : "not available";
            string doctorOtherDetails = otherDetails.Text;

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

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearFormFields();
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
    }
}
