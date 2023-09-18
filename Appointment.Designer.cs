namespace HealthCarePlus
{
    partial class AppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            appointmentTable = new DataGridView();
            idCol = new DataGridViewTextBoxColumn();
            sheduleCol = new DataGridViewTextBoxColumn();
            doctorCol = new DataGridViewTextBoxColumn();
            patientCol = new DataGridViewTextBoxColumn();
            dateCol = new DataGridViewTextBoxColumn();
            timeCol = new DataGridViewTextBoxColumn();
            statusCol = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)appointmentTable).BeginInit();
            SuspendLayout();
            // 
            // appointmentTable
            // 
            appointmentTable.AllowUserToAddRows = false;
            appointmentTable.AllowUserToDeleteRows = false;
            appointmentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentTable.Columns.AddRange(new DataGridViewColumn[] { idCol, sheduleCol, doctorCol, patientCol, dateCol, timeCol, statusCol });
            appointmentTable.Location = new Point(56, 326);
            appointmentTable.Name = "appointmentTable";
            appointmentTable.ReadOnly = true;
            appointmentTable.RowHeadersVisible = false;
            appointmentTable.RowTemplate.Height = 25;
            appointmentTable.Size = new Size(1193, 484);
            appointmentTable.TabIndex = 0;
            appointmentTable.CellContentClick += appointmentTable_CellContentClick;
            // 
            // idCol
            // 
            idCol.FillWeight = 50F;
            idCol.HeaderText = "ID";
            idCol.Name = "idCol";
            idCol.ReadOnly = true;
            // 
            // sheduleCol
            // 
            sheduleCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sheduleCol.HeaderText = "Shedule";
            sheduleCol.Name = "sheduleCol";
            sheduleCol.ReadOnly = true;
            // 
            // doctorCol
            // 
            doctorCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doctorCol.HeaderText = "Doctor";
            doctorCol.Name = "doctorCol";
            doctorCol.ReadOnly = true;
            // 
            // patientCol
            // 
            patientCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            patientCol.HeaderText = "Patient";
            patientCol.Name = "patientCol";
            patientCol.ReadOnly = true;
            // 
            // dateCol
            // 
            dateCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dateCol.HeaderText = "Date";
            dateCol.Name = "dateCol";
            dateCol.ReadOnly = true;
            dateCol.Width = 56;
            // 
            // timeCol
            // 
            timeCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            timeCol.HeaderText = "Time";
            timeCol.Name = "timeCol";
            timeCol.ReadOnly = true;
            timeCol.Width = 58;
            // 
            // statusCol
            // 
            statusCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            statusCol.HeaderText = "State";
            statusCol.Name = "statusCol";
            statusCol.ReadOnly = true;
            statusCol.Width = 58;
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1325, 834);
            Controls.Add(appointmentTable);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AppointmentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Appointment";
            ((System.ComponentModel.ISupportInitialize)appointmentTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView appointmentTable;
        private DataGridViewTextBoxColumn idCol;
        private DataGridViewTextBoxColumn sheduleCol;
        private DataGridViewTextBoxColumn doctorCol;
        private DataGridViewTextBoxColumn patientCol;
        private DataGridViewTextBoxColumn dateCol;
        private DataGridViewTextBoxColumn timeCol;
        private DataGridViewTextBoxColumn statusCol;
    }
}