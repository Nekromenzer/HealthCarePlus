using MySql.Data.MySqlClient;
namespace HealthCarePlus
{
    public partial class Form1 : Form

    {
        string mysqlCon = "server='127.0.0.1'; user=root; database=hospital; password= ";
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                RegisterUser();
            }

        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(fullName.Text) ||
                string.IsNullOrWhiteSpace(email.Text) ||
                string.IsNullOrWhiteSpace(position.Text) ||
                string.IsNullOrWhiteSpace(password.Text) ||
                string.IsNullOrWhiteSpace(confirmPassword.Text))
            {
                MessageBox.Show("All fields are required.");
                return false;
            }

            if (!IsValidEmail(email.Text))
            {
                MessageBox.Show("Invalid email address.");
                return false;
            }

            if (password.Text != confirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
        }

        private void RegisterUser()
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon))
            {
                try
                {
                    mySqlConnection.Open();
                    string insertQuery = "INSERT INTO userstable (FullName, Email, Position, Password) VALUES (@FullName, @Email, @Position, @Password)";
                    MySqlCommand cmd = new MySqlCommand(insertQuery, mySqlConnection);
                    cmd.Parameters.AddWithValue("@FullName", fullName.Text);
                    cmd.Parameters.AddWithValue("@Email", email.Text);
                    cmd.Parameters.AddWithValue("@Position", position.Text);
                    cmd.Parameters.AddWithValue("@Password", password.Text);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Registration successful.");
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ClearInputs()
        {
            fullName.Text = "";
            email.Text = "";
            position.Text = "";
            password.Text = "";
            confirmPassword.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //email
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void fullName_TextChanged(object sender, EventArgs e)
        {
            //full name
        }

        private void position_TextChanged(object sender, EventArgs e)
        {
            //possition
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            //password
        }

        private void confirmPassword_TextChanged(object sender, EventArgs e)
        {
            //confirm pass
        }
    }
}