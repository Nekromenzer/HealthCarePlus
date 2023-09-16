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

        private void roomsTable_SelectionChanged(object sender, EventArgs e)
        {
            if (roomsTable.SelectedRows.Count > 0)
            {
                roomSubmitBtn.Enabled = false;
                roomUpdateBtn.Enabled = true;
                roomDeleteBtn.Enabled = true;
                ClearInputFields();
            }
            else
            {
                roomSubmitBtn.Enabled = true;
                roomUpdateBtn.Enabled = false;
                roomDeleteBtn.Enabled = false;
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

        private void ClearInputFields()
        {
            roomType.SelectedIndex = -1;
            roomNumber.Text = "";
            roomPrice.Text = "";
            isRoom.SelectedIndex = -1;
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
            try
            {
                string roomTypeName = roomType.SelectedItem?.ToString();
                string roomNumberVal = roomNumber.Text;
                decimal pricePerDay = string.IsNullOrWhiteSpace(roomPrice.Text) ? 0 : decimal.Parse(roomPrice.Text);
                bool isRoomTheater = isRoom.SelectedIndex == 1;

                if (string.IsNullOrEmpty(roomTypeName))
                {
                    MessageBox.Show("Please select a room type.");
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(mysqlCon))
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO rooms (RoomType, RoomNumber, PricePerDay, Allocated, Type, Date, PatientID) " +
                                         "VALUES (@RoomType, @RoomNumber, @PricePerDay, 0, @Type, NULL, NULL)";
                    MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@RoomType", roomTypeName);
                    cmd.Parameters.AddWithValue("@RoomNumber", roomNumberVal);
                    cmd.Parameters.AddWithValue("@PricePerDay", pricePerDay);
                    cmd.Parameters.AddWithValue("@Type", isRoomTheater);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Room added successfully.");
                        DisplayRoomsList();
                        ClearInputFields();
                        ClearSelectionWithDelay();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add room.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void roomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roomNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void roomPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void isRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RoomClearBtn_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
    }
}
