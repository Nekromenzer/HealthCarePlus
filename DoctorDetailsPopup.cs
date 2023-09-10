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

namespace HealthCarePlus
{
    public partial class DoctorDetailsPopupForm : Form
    {
        public DoctorDetailsPopupForm()
        {
            InitializeComponent();
        }

        public void SetDoctorDetails(string doctorName, string location, string expertise)
        {
            // Populate the labels or text boxes with the provided details
            //doctorNameLabel.Text = doctorName;
            doctorNameLabel.Text = doctorName;
        }

        private void doctorNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
