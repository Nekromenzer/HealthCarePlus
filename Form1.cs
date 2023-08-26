using MySql.Data.MySqlClient;
namespace HealthCarePlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string mysqlCon = "server='127.0.0.1'; user=root; database=hospital; password= ";
            MySqlConnection mySqlConnection = new MySqlConnection (mysqlCon);
            try
            {
                mySqlConnection.Open ();
                MessageBox.Show("Connection success");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { mySqlConnection.Close (); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}