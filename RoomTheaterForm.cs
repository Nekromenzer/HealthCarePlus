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
            DisplayResourceList();
        }

        private async void ClearSelectionWithDelay()
        {
            await Task.Delay(1000);
            roomsTable.ClearSelection();
            resTable.ClearSelection();
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


        private void roomsTable_CellClick(object sender, EventArgs e)
        {
            if (roomsTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = roomsTable.SelectedRows[0];

                string roomTypeVal = selectedRow.Cells["roomTypeCol"].Value.ToString();
                string roomNumberVal = selectedRow.Cells["roomNumberCol"].Value.ToString();
                decimal pricePerDay = Convert.ToDecimal(selectedRow.Cells["priceCol"].Value);
                int isRoomTheater = Convert.ToInt32(selectedRow.Cells["roomTheaterCol"].Value);

                roomType.SelectedItem = roomTypeVal;
                roomNumber.Text = roomNumberVal;
                roomPrice.Text = pricePerDay.ToString();
                isRoom.SelectedItem = isRoomTheater == 0 ? "Theater" : "Room";
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

        private void DisplayResourceList()
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string query = "SELECT * FROM resources";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    resTable.DataSource = dataTable;
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

        private void ClearInputFields()
        {
            roomType.SelectedIndex = -1;
            roomNumber.Text = "";
            roomPrice.Text = "";
            isRoom.SelectedIndex = -1;
        }

        private bool IsRoomNumberExists(string roomNumber)
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM rooms WHERE RoomNumber = @RoomNumber";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
        }

        private void RoomSubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string roomTypeName = roomType.SelectedItem?.ToString();
                string roomNumberVal = roomNumber.Text;
                decimal pricePerDay = string.IsNullOrWhiteSpace(roomPrice.Text) ? 0 : decimal.Parse(roomPrice.Text);
                bool isRoomTheater = isRoom.SelectedIndex == 1;

                if (IsRoomNumberExists(roomNumberVal))
                {
                    MessageBox.Show("Room with this room number already exists.", "Duplicate Room Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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

        private void RoomClearBtn_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            ClearSelectionWithDelay();
        }

        private void DeleteRoom()
        {
            if (roomsTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = roomsTable.SelectedRows[0];
                int roomID = Convert.ToInt32(selectedRow.Cells["id"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this room?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(mysqlCon))
                        {
                            conn.Open();
                            string deleteQuery = "DELETE FROM rooms WHERE RoomID = @RoomID";
                            MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);
                            cmd.Parameters.AddWithValue("@RoomID", roomID);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Room deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DisplayRoomsList(); // Refresh the room list
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a room to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void roomDeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteRoom();
            ClearSelectionWithDelay();
        }

        private void roomUpdateBtn_Click(object sender, EventArgs e)
        {
            if (roomsTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = roomsTable.SelectedRows[0];

                int roomId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                string roomNumberVal = roomNumber.Text;
                string roomTypeVal = roomType.SelectedItem?.ToString();
                decimal pricePerDay = string.IsNullOrWhiteSpace(roomPrice.Text) ? 0 : decimal.Parse(roomPrice.Text);
                bool isRoomTheater = isRoom.SelectedIndex == 1;

                if (string.IsNullOrWhiteSpace(roomTypeVal) || string.IsNullOrWhiteSpace(roomNumberVal))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                using (MySqlConnection connection = new MySqlConnection(mysqlCon))
                {
                    connection.Open();

                    string updateQuery = "UPDATE rooms SET RoomNumber = RoomNumber, RoomType = @RoomType, PricePerDay = @PricePerDay, Type = @Type WHERE RoomID = @RoomID";

                    MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                    cmd.Parameters.AddWithValue("@RoomID", roomId);
                    cmd.Parameters.AddWithValue("@RoomNumber", roomNumberVal);
                    cmd.Parameters.AddWithValue("@RoomType", roomType);
                    cmd.Parameters.AddWithValue("@PricePerDay", pricePerDay);
                    cmd.Parameters.AddWithValue("@Type", isRoomTheater);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Room record updated successfully.");
                        DisplayRoomsList();
                        ClearInputFields();
                        ClearSelectionWithDelay();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update room record.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a room record to update.");
            }
        }

        private void resSubmitBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
