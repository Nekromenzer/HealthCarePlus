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
    public partial class DoctorSchdulesForm : Form

    {
        private string mysqlCon = "Data source=127.0.0.1; user=root; database=hospital; password= ";
        public DoctorSchdulesForm()
        {
            InitializeComponent();
        }

        private void doctorId_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(mysqlCon);
            MySqlCommand cmd = new MySqlCommand("Select DoctorId,FullName From doctors", conn);
            conn.Open();
            AutoCompleteStringCollection str_coll = new AutoCompleteStringCollection();
            MySqlDataReader myreader = cmd.ExecuteReader();
            while (myreader.Read())
            {
                str_coll.Add(myreader.GetString(1));
            }
            doctorId.AutoCompleteCustomSource = str_coll;
            doctorId.AutoCompleteSource = AutoCompleteSource.CustomSource;
            doctorId.AutoCompleteMode = AutoCompleteMode.Suggest;
            conn.Close();
        }
    }
}
