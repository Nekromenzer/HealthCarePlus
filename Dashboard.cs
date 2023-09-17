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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void header_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorSchdulesForm doctorSchdulesForm = new DoctorSchdulesForm();
            doctorSchdulesForm.Show();
        }

        private void addDoctorBtn_Click(object sender, EventArgs e)
        {
            DoctorAddForm doctorSchdulesForm = new DoctorAddForm();
            doctorSchdulesForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void searchDoctorBtn_Click(object sender, EventArgs e)
        {
            searchForm DoctorSearchForm = new searchForm();
            DoctorSearchForm.Show();
        }

        private void managePatientBtn_Click(object sender, EventArgs e)
        {
            PatientAddForm patientAddForm = new PatientAddForm();
            patientAddForm.Show();
        }

        private void roomSearchBtn_Click(object sender, EventArgs e)
        {
            RoomTheaterForm roomTheaterForm = new RoomTheaterForm();
            roomTheaterForm.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void addAppointmentBtn_Click(object sender, EventArgs e)
        {
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.Show();
        }
    }
}
