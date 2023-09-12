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
using System;
using System.Windows.Forms;

namespace HealthCarePlus
{
    public partial class Login : Form
    {
        private string mysqlCon = "server=127.0.0.1; user=root; database=hospital; password= ";
        public Login()
        {
            InitializeComponent();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ValidateUserCredentials(string email, string password)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon))
            {
                try
                {
                    mySqlConnection.Open();
                    string query = "SELECT COUNT(*) FROM userstable WHERE Email = @Email AND Password = @Password";
                    MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }

        private void OpenMainApplication()
        {
            string userEmail = email.Text;

            Dashboard dashboard = new Dashboard();
            AdminDashboard adminDashboard = new AdminDashboard();
            if (userEmail == "admin@healthcareplus.com")
            {
                adminDashboard.Show();
            }
            else
            {
                dashboard.Show();
            }

            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            {
                string userEmail = email.Text;
                string userPassword = password.Text;

                if (!string.IsNullOrWhiteSpace(userEmail) && !string.IsNullOrWhiteSpace(userPassword))
                {
                    if (ValidateUserCredentials(userEmail, userPassword))
                    {
                        // Login successful, navigate to main application page
                        OpenMainApplication();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password. Please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in both email and password fields.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
