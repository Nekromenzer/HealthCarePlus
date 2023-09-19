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
            state = new ComboBox();
            stateLabel = new Label();
            submitBtn = new Button();
            scheduleLabel = new Label();
            schedule = new ComboBox();
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
            // state
            // 
            state.AutoCompleteCustomSource.AddRange(new string[] { "Pending", "Ongoing", "Complete" });
            state.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            state.FormattingEnabled = true;
            state.Location = new Point(970, 192);
            state.Name = "state";
            state.Size = new Size(279, 33);
            state.TabIndex = 1;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            stateLabel.Location = new Point(970, 172);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(39, 17);
            stateLabel.TabIndex = 2;
            stateLabel.Text = "State";
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.MediumSeaGreen;
            submitBtn.BackgroundImageLayout = ImageLayout.None;
            submitBtn.Cursor = Cursors.Hand;
            submitBtn.FlatAppearance.BorderSize = 0;
            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            submitBtn.Image = (Image)resources.GetObject("submitBtn.Image");
            submitBtn.ImageAlign = ContentAlignment.MiddleRight;
            submitBtn.Location = new Point(56, 250);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(206, 37);
            submitBtn.TabIndex = 21;
            submitBtn.Text = "Create Appointment";
            submitBtn.TextAlign = ContentAlignment.MiddleLeft;
            submitBtn.UseVisualStyleBackColor = false;
            // 
            // scheduleLabel
            // 
            scheduleLabel.AutoSize = true;
            scheduleLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            scheduleLabel.Location = new Point(56, 104);
            scheduleLabel.Name = "scheduleLabel";
            scheduleLabel.Size = new Size(62, 17);
            scheduleLabel.TabIndex = 23;
            scheduleLabel.Text = "Schedule";
            // 
            // schedule
            // 
            schedule.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            schedule.FormattingEnabled = true;
            schedule.Location = new Point(56, 124);
            schedule.Name = "schedule";
            schedule.Size = new Size(279, 33);
            schedule.TabIndex = 22;
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1325, 834);
            Controls.Add(scheduleLabel);
            Controls.Add(schedule);
            Controls.Add(submitBtn);
            Controls.Add(stateLabel);
            Controls.Add(state);
            Controls.Add(appointmentTable);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AppointmentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Appointment";
            ((System.ComponentModel.ISupportInitialize)appointmentTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private ComboBox state;
        private Label stateLabel;
        private Button submitBtn;
        private Label scheduleLabel;
        private ComboBox schedule;
    }
}