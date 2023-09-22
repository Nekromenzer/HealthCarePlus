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

namespace HealthCarePlus
{
    public partial class frmInvoice : Form
    {
        private string mysqlCon = "Data source=127.0.0.1; user=root; database=hospital; password= ";
        string pid = "0";
        public frmInvoice()
        {
            InitializeComponent();


        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadPatientdata();

        }
        private void loadPatientdata()
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string query = "SELECT * FROM patient WHERE PatientID=" + pid + "";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    txtPname.Text = mdr[1].ToString();




                }


            }
        }
    }
}
