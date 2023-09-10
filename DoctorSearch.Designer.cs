using System.Windows.Forms;

namespace HealthCarePlus
{
    partial class searchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchForm));
            doctorTable = new DataGridView();
            doctorId = new DataGridViewTextBoxColumn();
            doctorFullName = new DataGridViewTextBoxColumn();
            doctorContactNumber = new DataGridViewTextBoxColumn();
            doctorEmail = new DataGridViewTextBoxColumn();
            doctorLocation = new DataGridViewTextBoxColumn();
            doctorAvailability = new DataGridViewTextBoxColumn();
            doctorExpertise = new DataGridViewTextBoxColumn();
            doctorOtherDetails = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)doctorTable).BeginInit();
            SuspendLayout();
            // 
            // doctorTable
            // 
            doctorTable.AllowUserToAddRows = false;
            doctorTable.AllowUserToOrderColumns = true;
            doctorTable.AllowUserToResizeColumns = false;
            doctorTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            doctorTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            doctorTable.BackgroundColor = SystemColors.Control;
            doctorTable.BorderStyle = BorderStyle.None;
            doctorTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            doctorTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            doctorTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doctorTable.Columns.AddRange(new DataGridViewColumn[] { doctorId, doctorFullName, doctorContactNumber, doctorEmail, doctorLocation, doctorAvailability, doctorExpertise, doctorOtherDetails });
            doctorTable.EnableHeadersVisualStyles = false;
            doctorTable.Location = new Point(68, 304);
            doctorTable.Name = "doctorTable";
            doctorTable.RowHeadersVisible = false;
            doctorTable.RowTemplate.Height = 25;
            doctorTable.ScrollBars = ScrollBars.Vertical;
            doctorTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            doctorTable.Size = new Size(1193, 484);
            doctorTable.TabIndex = 0;
            doctorTable.CellContentClick += doctorTable_CellContentClick;
            // 
            // doctorId
            // 
            doctorId.DataPropertyName = "DoctorID";
            doctorId.HeaderText = "Id";
            doctorId.Name = "doctorId";
            doctorId.Width = 41;
            // 
            // doctorFullName
            // 
            doctorFullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doctorFullName.DataPropertyName = "FullName";
            doctorFullName.HeaderText = "Full Name";
            doctorFullName.Name = "doctorFullName";
            // 
            // doctorContactNumber
            // 
            doctorContactNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            doctorContactNumber.DataPropertyName = "ContactNumber";
            doctorContactNumber.HeaderText = "Contact";
            doctorContactNumber.Name = "doctorContactNumber";
            doctorContactNumber.Width = 73;
            // 
            // doctorEmail
            // 
            doctorEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doctorEmail.DataPropertyName = "Email";
            doctorEmail.HeaderText = "Email";
            doctorEmail.Name = "doctorEmail";
            // 
            // doctorLocation
            // 
            doctorLocation.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doctorLocation.DataPropertyName = "Location";
            doctorLocation.HeaderText = "Location";
            doctorLocation.Name = "doctorLocation";
            // 
            // doctorAvailability
            // 
            doctorAvailability.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doctorAvailability.DataPropertyName = "Availability";
            doctorAvailability.HeaderText = "Availability";
            doctorAvailability.Name = "doctorAvailability";
            // 
            // doctorExpertise
            // 
            doctorExpertise.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doctorExpertise.DataPropertyName = "Expertise";
            doctorExpertise.HeaderText = "Expertise";
            doctorExpertise.Name = "doctorExpertise";
            // 
            // doctorOtherDetails
            // 
            doctorOtherDetails.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doctorOtherDetails.DataPropertyName = "OtherDetails";
            doctorOtherDetails.HeaderText = "Other Details";
            doctorOtherDetails.Name = "doctorOtherDetails";
            // 
            // searchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 834);
            Controls.Add(doctorTable);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "searchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search";
            ((System.ComponentModel.ISupportInitialize)doctorTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView doctorTable;
        private DataGridViewTextBoxColumn doctorId;
        private DataGridViewTextBoxColumn doctorFullName;
        private DataGridViewTextBoxColumn doctorContactNumber;
        private DataGridViewTextBoxColumn doctorEmail;
        private DataGridViewTextBoxColumn doctorLocation;
        private DataGridViewTextBoxColumn doctorAvailability;
        private DataGridViewTextBoxColumn doctorExpertise;
        private DataGridViewTextBoxColumn doctorOtherDetails;
    }
}