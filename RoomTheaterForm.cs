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
    public partial class RoomTheaterForm : Form
    {
        private string mysqlCon = "Data source=127.0.0.1; user=root; database=hospital; password= ";
        public RoomTheaterForm()
        {
            InitializeComponent();
            DisplayRoomsList();
            ClearSelectionWithDelay();
        }

        private async void ClearSelectionWithDelay()
        {
            await Task.Delay(1000);
            roomsTable.ClearSelection();
        }

        private string GetPatientNameById(int patientId)
        {
            string? patientName = string.Empty;
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string query = "SELECT FullName FROM patients WHERE PatientID = @PatientID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PatientID", patientId);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    patientName = result.ToString();
                }
            }
            return patientName;
        }

        private void roomsTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (roomsTable.Columns[e.ColumnIndex].Name == "patientIdCol")
            {
                if (e.Value != null && !DBNull.Value.Equals(e.Value))
                {
                    string? patientName = GetPatientNameById(Convert.ToInt32(e.Value));
                    e.Value = patientName;
                }
            }

            if (roomsTable.Columns[e.ColumnIndex].Name == "allocatedCol")
            {
                if (e.Value != null && e.Value.ToString() == "1")
                {
                    string? allocated = "✔️";
                    e.Value = allocated;
                }
                else
                {
                    string? notAllocated = "❌";
                    e.Value = notAllocated;
                }
            }

            if (roomsTable.Columns[e.ColumnIndex].Name == "roomTheaterCol")
            {
                if (e.Value != null && e.Value.ToString() == "False")
                {
                    string? room = "Theater";
                    e.Value = room;
                }
                if (e.Value != null && e.Value.ToString() == "True")
                {
                    string? room = "Room";
                    e.Value = room;
                }
            }

        }

        private void DisplayRoomsList()
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string query = "SELECT * FROM rooms";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    roomsTable.DataSource = dataTable;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void roomsTab_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RoomSubmitBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
