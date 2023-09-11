using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCarePlus
{
   
    public partial class PatientAddForm : Form
    {
        private string mysqlCon = "Data source=127.0.0.1; user=root; database=hospital; password= ";
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
    }
}
