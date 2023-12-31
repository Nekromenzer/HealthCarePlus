﻿using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace HealthCarePlus
{
    public partial class searchForm : Form
    {
        private string mysqlCon = "Data source=127.0.0.1; user=root; database=hospital; password= ";
        public searchForm()
        {
            InitializeComponent();
            DisplayDoctorList();
            ClearSelectionWithDelay();
        }

        private async void ClearSelectionWithDelay()
        {
            await Task.Delay(1000);
            doctorTable.ClearSelection();
        }

        private void DisplayDoctorList()
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string query = "SELECT * FROM doctors WHERE 1=1"; // Always true condition

                if (!string.IsNullOrWhiteSpace(searchInput.Text))
                {
                    query += " AND (FullName LIKE @SearchText";
                    query += " OR Location LIKE @SearchText";
                    query += " OR Expertise LIKE @SearchText";
                    query += " OR Email LIKE @SearchText";
                    query += " OR OtherDetails LIKE @SearchText)";
                }

                if (available.Checked)
                {
                    query += " AND Availability = 'Available'";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (!string.IsNullOrWhiteSpace(searchInput.Text))
                {
                    cmd.Parameters.AddWithValue("@SearchText", "%" + searchInput.Text + "%");
                }

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // Bind the table
                    doctorTable.DataSource = dataTable;
                }
            }
        }



        private void doctorTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = doctorTable.Rows[e.RowIndex];

                string? doctorName = row.Cells["doctorFullName"].Value.ToString();
                string? location = row.Cells["doctorLocation"].Value.ToString();
                string? expertise = row.Cells["doctorExpertise"].Value.ToString();
                string? contactNumber = row.Cells["doctorContactNumber"].Value.ToString();
                string? email = row.Cells["doctorEmail"].Value.ToString();
                string? avialability = row.Cells["doctorAvailability"].Value.ToString();
                string? other = row.Cells["doctorOtherDetails"].Value.ToString();

                using (DoctorDetailsPopupForm popupForm = new DoctorDetailsPopupForm())
                {
                    popupForm.SetDoctorDetails(doctorName, location, expertise, contactNumber, email, avialability, other);

                    // Show the popup form
                    popupForm.ShowDialog();
                }
            }
        }

        private void searchInput_TextChanged_1(object sender, EventArgs e)
        {
            DisplayDoctorList();
            ClearSelectionWithDelay();
        }

        private void available_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDoctorList();
            ClearSelectionWithDelay();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            searchInput.Text = "";
            available.Checked = false;
            DisplayDoctorList();
        }

        private void searchForm_Load(object sender, EventArgs e)
        {

        }
    }
}
