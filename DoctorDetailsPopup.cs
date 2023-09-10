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
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HealthCarePlus
{
    public partial class DoctorDetailsPopupForm : Form
    {
        public DoctorDetailsPopupForm()
        {
            InitializeComponent();
        }

        public void SetDoctorDetails(string doctorName, string location, string expertise, string contactNumber, string email, string avialability, string other)
        {
            // Populate the labels or text boxes with the provided details
            //doctorNameLabel.Text = doctorName;
            doctorNameLabel.Text = doctorName;
        }

        private void doctorNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DoctorDetailsPopupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
