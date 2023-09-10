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
    public partial class searchForm : Form
    {
        private string mysqlCon = "Data source=127.0.0.1; user=root; database=hospital; password= ";
        public searchForm()
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
                if (!string.IsNullOrWhiteSpace(fullName.Text))
                {
                    query += " WHERE FullName LIKE @SearchText";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (!string.IsNullOrWhiteSpace(fullName.Text))
                {
                    // Set the parameter value for the search text
                    cmd.Parameters.AddWithValue("@SearchText", "%" + fullName.Text + "%");
                }

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // bind table
                    doctorTable.DataSource = dataTable;
                }
            }
        }


        private void doctorTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fullName_TextChanged(object sender, EventArgs e)
        {
            DisplayDoctorList();
        }
    }
}
