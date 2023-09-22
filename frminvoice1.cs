using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HealthCarePlus
{
    public partial class frminvoice1 : Form

    {
        private string mysqlCon = "Data source=127.0.0.1; user=root; database=hospital; password= ";
        string pid = "0";
        string desc = "";
        int qty = 1;
        string dte1 = "";
        int status1 = 0;
        int invoicenumber = 1;
        int btnMode = 0; // 1 = Appoinment 2= Medication 3= Rooms 4= Procedures
        int invoiceStatus = 0; // 0 = No active invoice 1 = active invoice going
        public frminvoice1()
        {
            InitializeComponent();
        }
        public class DoctorNameFunc
        {
            public int DoctorID { get; set; }
            public string? FullName { get; set; }
            public override string ToString()
            {
                return FullName;
            }
        }

        public class PatientNameFunc
        {
            public int PatientID { get; set; }
            public string? FullName { get; set; }
            public override string ToString()
            {
                return FullName;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pid = txtpid.Text;
            loadPatientdata();
        }
        private void loadPatientdata()
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string query = "SELECT * FROM patients WHERE PatientID=" + pid + "";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    txtPname.Text = mdr[1].ToString();
                    txtDOB.Text = mdr[2].ToString();
                    txtGender.Text = mdr[3].ToString();
                    txtPno.Text = mdr[4].ToString();
                    txtAddress.Text = mdr[5].ToString();
                    txtNic.Text = mdr[6].ToString();

                }


            }
        }
        private void DisplayAppointments()
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string query = "SELECT AppointmentID, DoctorById(DoctorID) As Doctor, patientById(PatientID) as Patient, Price FROM appointments where date= '" + dtp1.Text + "' and PatientID= '" + txtpid.Text + "' and Status ='0'";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // bind table
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void DisplayMedications()
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string query = "SELECT m.MedicationID, patientById(m.patientId) as Patient,mc.name , mc.price  FROM medications as m, medichild as mc where m.MedicationID=mc.medicationId and  m.patientid= '" + txtpid.Text + "' and m.status ='0'";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // bind table
                    dataGridView1.DataSource = dataTable;
                }
            }
        }
        private void DisplayConsultations()
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string query = "SELECT ConsultationID, patientById(PatientID) as Patient, DoctorById(DoctorID) As Doctor,ConsultationFee  FROM consultations where  patientid= '" + txtpid.Text + "' and status ='0'";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // bind table
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void DisplayInvoice()
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string query = " SELECT i.invoiceID, patientById(i.patient), i.iDate, i.status, b.description, b.qty, b.unitp FROM invoiceparent AS i, invoicechild AS b WHERE i.invoiceID = b.invoiceID AND i.STATUS = 1 and i.invoiceID = " + invoicenumber + "";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // bind table
                    dataGridView2.DataSource = dataTable;

                    decimal sum = 0;
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            // Assuming that Quantity is in column index 2 and Unit Price is in column index 3
                            decimal quantity = Convert.ToDecimal(row.Cells[5].Value);
                            decimal unitPrice = Convert.ToDecimal(row.Cells[6].Value);
                            sum += quantity * unitPrice;
                        }
                    }

                    DataRow totalRow = dataTable.NewRow();
                    // totalRow[5] = "Total";

                    totalRow[6] = sum;
                    dataTable.Rows.Add(totalRow);

                    // Rebind the DataGridView
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = dataTable;

                    int totalRowIndex = dataGridView2.Rows.Count - 1;
                    dataGridView2.Rows[totalRowIndex].DefaultCellStyle.Font = new Font(dataGridView2.Font, FontStyle.Bold);
                    lbl2.Text = sum.ToString();


                }
            }

        }
        private void DisplayInvoice1()
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string query = " SELECT i.invoiceID, patientById(i.patient), i.iDate, i.status, b.description, b.qty, b.unitp FROM invoiceparent AS i, invoicechild AS b WHERE i.invoiceID = b.invoiceID AND i.STATUS = 1 and i.patient = " + txtpid.Text + "";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // bind table
                    dataGridView2.DataSource = dataTable;

                    decimal sum = 0;
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            // Assuming that Quantity is in column index 2 and Unit Price is in column index 3
                            decimal quantity = Convert.ToDecimal(row.Cells[5].Value);
                            decimal unitPrice = Convert.ToDecimal(row.Cells[6].Value);
                            sum += quantity * unitPrice;
                        }
                    }

                    DataRow totalRow = dataTable.NewRow();
                    // totalRow[5] = "Total";

                    totalRow[6] = sum;
                    dataTable.Rows.Add(totalRow);

                    // Rebind the DataGridView
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = dataTable;

                    int totalRowIndex = dataGridView2.Rows.Count - 1;
                    dataGridView2.Rows[totalRowIndex].DefaultCellStyle.Font = new Font(dataGridView2.Font, FontStyle.Bold);
                    lbl2.Text = sum.ToString();
                }
            }

        }

        private void frminvoice1_Load(object sender, EventArgs e)
        {
            DisplayInvoice();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAppoinment_Click(object sender, EventArgs e)
        {
            if (txtpid.Text != "")
            {
                DisplayAppointments();
                btnMode = 1;
                desc = "Appointment Charge";
            }
        }

        private void btnAddtoDb_Click(object sender, EventArgs e)
        {
            CreateInvoiceNumber();
            AddinvoiceParent();

            if (btnMode == 1)
            {
                AddAppointmentToInvoice();
            }
            else if (btnMode == 2)
            {
                AddMedicationToInvoice();
            }
            else if (btnMode == 3)
            {

            }
            else if (btnMode == 4)
            {

            }
            else if (btnMode == 5)
            {
                AddConsultationToInvoice();
            }
            //btnMode = 0;
            DisplayInvoice();
        }

        private void CreateInvoiceNumber()
        {
            if (invoiceStatus == 0)
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlCon))
                {
                    connection.Open();

                    string query = "SELECT MAX(invoiceID) FROM invoiceparent";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            int maxInvoiceNumber = Convert.ToInt32(result);

                            // Set the maximum invoice number to a variable
                            invoicenumber = maxInvoiceNumber + 1;

                            return;
                        }
                        else
                        {

                        }
                    }
                }
            }
            else if (invoiceStatus == 1)
            {

            }
        }

        private void AddinvoiceParent()
        {
            if (invoiceStatus == 0)
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlCon))
                {
                    conn.Open();
                    // DateTime currentDate = DateTime.Now;
                    // DateTime formattedDate= currentDate.ToString("mm/dd/yyyy");
                    dte1 = DateTime.Now.ToString("MM/dd/yyyy");
                    status1 = 1;

                    string insertQuery = "INSERT INTO invoiceparent (invoiceID,patient, iDate, status) VALUES (" + invoicenumber + ",'" + txtpid.Text + "','" + dte1 + "', '" + status1 + "' )";
                    MySqlCommand command = new MySqlCommand(insertQuery, conn);
                    command.ExecuteNonQuery();
                    conn.Close();

                }
                invoiceStatus = 1;
            }



        }

        private void AddAppointmentToInvoice()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to insert.");
                return;
            }
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            string column4Value = selectedRow.Cells[2].Value.ToString();
            string column3Value = selectedRow.Cells[3].Value.ToString();

            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string insertQuery = "INSERT INTO invoicechild (invoiceID,description, qty, unitp) VALUES (" + invoicenumber + ",'" + desc + "'," + qty + ", " + column3Value + " )";
                MySqlCommand command = new MySqlCommand(insertQuery, conn);
                command.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void AddMedicationToInvoice()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to insert.");
                return;
            }
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            string column4Value = selectedRow.Cells[2].Value.ToString();
            string column3Value = selectedRow.Cells[3].Value.ToString();

            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string insertQuery = "INSERT INTO invoicechild (invoiceID,description, qty, unitp) VALUES (" + invoicenumber + ",'" + column4Value + "'," + qty + ", " + column3Value + " )";
                MySqlCommand command = new MySqlCommand(insertQuery, conn);
                command.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void AddConsultationToInvoice()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to insert.");
                return;
            }
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            string column4Value = selectedRow.Cells[2].Value.ToString();
            string column3Value = selectedRow.Cells[3].Value.ToString();

            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                conn.Open();
                string desc1 = "";
                desc1 = desc + " " + column4Value;
                string insertQuery = "INSERT INTO invoicechild (invoiceID,description, qty, unitp) VALUES (" + invoicenumber + ",'" + desc1 + "'," + qty + ", " + column3Value + " )";
                MySqlCommand command = new MySqlCommand(insertQuery, conn);
                command.ExecuteNonQuery();
                conn.Close();

            }
        }



        private void btnMedi_Click(object sender, EventArgs e)
        {
            if (txtpid.Text != "")
            {
                DisplayMedications();
                btnMode = 2;
                //desc = "Medication Charge";
            }

        }

        private void btnConsultation_Click(object sender, EventArgs e)
        {
            if (txtpid.Text != "")
            {
                DisplayConsultations();
                btnMode = 5;
                desc = "Consultation Fee";
            }
        }
    }
}
