namespace HealthCarePlus
{
    partial class PatientAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientAddForm));
            patientTable = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            dob = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            contact = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            nic = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)patientTable).BeginInit();
            SuspendLayout();
            // 
            // patientTable
            // 
            patientTable.AllowUserToAddRows = false;
            patientTable.AllowUserToOrderColumns = true;
            patientTable.AllowUserToResizeColumns = false;
            patientTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            patientTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            patientTable.BackgroundColor = SystemColors.Control;
            patientTable.BorderStyle = BorderStyle.None;
            patientTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            patientTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            patientTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientTable.Columns.AddRange(new DataGridViewColumn[] { id, name, dob, gender, contact, address, nic });
            patientTable.EnableHeadersVisualStyles = false;
            patientTable.Location = new Point(68, 304);
            patientTable.Name = "patientTable";
            patientTable.RowHeadersVisible = false;
            patientTable.RowTemplate.Height = 25;
            patientTable.ScrollBars = ScrollBars.Vertical;
            patientTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            patientTable.Size = new Size(1193, 484);
            patientTable.TabIndex = 0;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            id.DataPropertyName = "PatientID";
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 42;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            name.DataPropertyName = "FullName";
            name.HeaderText = "Full Name";
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 85;
            // 
            // dob
            // 
            dob.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dob.DataPropertyName = "DateOfBirth";
            dob.HeaderText = "DOB";
            dob.Name = "dob";
            dob.ReadOnly = true;
            dob.Width = 55;
            // 
            // gender
            // 
            gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gender.DataPropertyName = "Gender";
            gender.HeaderText = "Gender";
            gender.Name = "gender";
            gender.ReadOnly = true;
            gender.Width = 69;
            // 
            // contact
            // 
            contact.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            contact.DataPropertyName = "ContactNumber";
            contact.HeaderText = "Contact";
            contact.Name = "contact";
            contact.ReadOnly = true;
            contact.Width = 73;
            // 
            // address
            // 
            address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            address.DataPropertyName = "Address";
            address.HeaderText = "Address";
            address.Name = "address";
            address.ReadOnly = true;
            // 
            // nic
            // 
            nic.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nic.DataPropertyName = "NIC";
            nic.HeaderText = "NIC";
            nic.Name = "nic";
            nic.ReadOnly = true;
            nic.Width = 51;
            // 
            // PatientAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1325, 834);
            Controls.Add(patientTable);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PatientAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient Add";
            Load += PatientAddForm_Load;
            ((System.ComponentModel.ISupportInitialize)patientTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView patientTable;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn dob;
        private DataGridViewTextBoxColumn contact;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn nic;
        private DataGridViewTextBoxColumn gender;
    }
}