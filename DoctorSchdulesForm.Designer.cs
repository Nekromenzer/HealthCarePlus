namespace HealthCarePlus
{
    partial class DoctorSchdulesForm
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
            doctorId = new TextBox();
            doctorIdLabel = new Label();
            date = new DateTimePicker();
            DateLabel = new Label();
            StartTimeLabel = new Label();
            startTime = new DateTimePicker();
            EndTimeLabel = new Label();
            endTime = new DateTimePicker();
            AppointmentLabel = new Label();
            patientsLabel = new Label();
            patients = new TextBox();
            locationLabel = new Label();
            noteLabel = new Label();
            note = new TextBox();
            submitBtn = new Button();
            label1 = new Label();
            location = new ComboBox();
            appointmentType = new ComboBox();
            SuspendLayout();
            // 
            // doctorId
            // 
            doctorId.AutoCompleteMode = AutoCompleteMode.Suggest;
            doctorId.AutoCompleteSource = AutoCompleteSource.CustomSource;
            doctorId.BorderStyle = BorderStyle.FixedSingle;
            doctorId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            doctorId.Location = new Point(76, 137);
            doctorId.Name = "doctorId";
            doctorId.PlaceholderText = "Dr.Jane Low";
            doctorId.Size = new Size(279, 33);
            doctorId.TabIndex = 0;
            doctorId.TextChanged += doctorId_TextChanged;
            // 
            // doctorIdLabel
            // 
            doctorIdLabel.AutoSize = true;
            doctorIdLabel.Location = new Point(76, 119);
            doctorIdLabel.Name = "doctorIdLabel";
            doctorIdLabel.Size = new Size(43, 15);
            doctorIdLabel.TabIndex = 1;
            doctorIdLabel.Text = "Doctor";
            // 
            // date
            // 
            date.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            date.Format = DateTimePickerFormat.Short;
            date.Location = new Point(76, 272);
            date.MinDate = new DateTime(2023, 8, 31, 0, 0, 0, 0);
            date.Name = "date";
            date.Size = new Size(279, 33);
            date.TabIndex = 4;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(76, 254);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(31, 15);
            DateLabel.TabIndex = 5;
            DateLabel.Text = "Date";
            // 
            // StartTimeLabel
            // 
            StartTimeLabel.AutoSize = true;
            StartTimeLabel.Location = new Point(76, 328);
            StartTimeLabel.Name = "StartTimeLabel";
            StartTimeLabel.Size = new Size(60, 15);
            StartTimeLabel.TabIndex = 7;
            StartTimeLabel.Text = "Start Time";
            // 
            // startTime
            // 
            startTime.CustomFormat = "HH:mm";
            startTime.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            startTime.Format = DateTimePickerFormat.Custom;
            startTime.Location = new Point(76, 346);
            startTime.MinDate = new DateTime(2023, 8, 31, 0, 0, 0, 0);
            startTime.Name = "startTime";
            startTime.ShowUpDown = true;
            startTime.Size = new Size(279, 33);
            startTime.TabIndex = 6;
            // 
            // EndTimeLabel
            // 
            EndTimeLabel.AutoSize = true;
            EndTimeLabel.Location = new Point(429, 328);
            EndTimeLabel.Name = "EndTimeLabel";
            EndTimeLabel.Size = new Size(56, 15);
            EndTimeLabel.TabIndex = 9;
            EndTimeLabel.Text = "End Time";
            // 
            // endTime
            // 
            endTime.CustomFormat = "HH:mm";
            endTime.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            endTime.Format = DateTimePickerFormat.Custom;
            endTime.Location = new Point(429, 346);
            endTime.MinDate = new DateTime(2023, 8, 31, 0, 0, 0, 0);
            endTime.Name = "endTime";
            endTime.ShowUpDown = true;
            endTime.Size = new Size(279, 33);
            endTime.TabIndex = 8;
            // 
            // AppointmentLabel
            // 
            AppointmentLabel.AutoSize = true;
            AppointmentLabel.Location = new Point(76, 187);
            AppointmentLabel.Name = "AppointmentLabel";
            AppointmentLabel.Size = new Size(105, 15);
            AppointmentLabel.TabIndex = 11;
            AppointmentLabel.Text = "Appointment Type";
            // 
            // patientsLabel
            // 
            patientsLabel.AutoSize = true;
            patientsLabel.Location = new Point(429, 119);
            patientsLabel.Name = "patientsLabel";
            patientsLabel.Size = new Size(49, 15);
            patientsLabel.TabIndex = 13;
            patientsLabel.Text = "Patients";
            // 
            // patients
            // 
            patients.AutoCompleteMode = AutoCompleteMode.Suggest;
            patients.AutoCompleteSource = AutoCompleteSource.CustomSource;
            patients.BorderStyle = BorderStyle.FixedSingle;
            patients.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            patients.Location = new Point(429, 137);
            patients.Name = "patients";
            patients.PlaceholderText = "Jane doe";
            patients.Size = new Size(279, 33);
            patients.TabIndex = 12;
            patients.TextChanged += patients_TextChanged;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new Point(429, 187);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(53, 15);
            locationLabel.TabIndex = 17;
            locationLabel.Text = "Location";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new Point(429, 254);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(33, 15);
            noteLabel.TabIndex = 19;
            noteLabel.Text = "Note";
            // 
            // note
            // 
            note.AutoCompleteCustomSource.AddRange(new string[] { "London", "Manchester", "Birmingham", "Edinburgh", "Glasgow", "Liverpool", "Leeds", "Bristol", "Sheffield", "Newcastle" });
            note.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            note.BorderStyle = BorderStyle.FixedSingle;
            note.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            note.Location = new Point(429, 272);
            note.Name = "note";
            note.Size = new Size(279, 33);
            note.TabIndex = 18;
            // 
            // submitBtn
            // 
            submitBtn.BackgroundImageLayout = ImageLayout.None;
            submitBtn.Cursor = Cursors.Hand;
            submitBtn.FlatAppearance.BorderSize = 2;
            submitBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            submitBtn.Location = new Point(76, 412);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(279, 42);
            submitBtn.TabIndex = 21;
            submitBtn.Text = "Add Schedule +";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(72, 30);
            label1.Name = "label1";
            label1.Size = new Size(284, 36);
            label1.TabIndex = 22;
            label1.Text = "Add Doctor Schedules";
            // 
            // location
            // 
            location.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            location.FormattingEnabled = true;
            location.Items.AddRange(new object[] { "London", "Manchester", "Birmingham", "Edinburgh", "Glasgow", "Liverpool", "Leeds", "Bristol", "Sheffield", "Newcastle" });
            location.Location = new Point(429, 205);
            location.Name = "location";
            location.Size = new Size(279, 33);
            location.TabIndex = 23;
            // 
            // appointmentType
            // 
            appointmentType.AutoCompleteCustomSource.AddRange(new string[] { "General Checkup", "Follow-up Visit", "Consultation", "Vaccination", "Test Results Discussion", "Treatment Session", "Procedure or Surgery", "Specialized Consultation", "Medication Review", "Physical Therapy Session" });
            appointmentType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            appointmentType.FormattingEnabled = true;
            appointmentType.Items.AddRange(new object[] { "London", "Manchester", "Birmingham", "Edinburgh", "Glasgow", "Liverpool", "Leeds", "Bristol", "Sheffield", "Newcastle" });
            appointmentType.Location = new Point(76, 205);
            appointmentType.Name = "appointmentType";
            appointmentType.Size = new Size(279, 33);
            appointmentType.TabIndex = 24;
            // 
            // DoctorSchdulesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 522);
            Controls.Add(appointmentType);
            Controls.Add(location);
            Controls.Add(label1);
            Controls.Add(submitBtn);
            Controls.Add(noteLabel);
            Controls.Add(note);
            Controls.Add(locationLabel);
            Controls.Add(patientsLabel);
            Controls.Add(patients);
            Controls.Add(AppointmentLabel);
            Controls.Add(EndTimeLabel);
            Controls.Add(endTime);
            Controls.Add(StartTimeLabel);
            Controls.Add(startTime);
            Controls.Add(DateLabel);
            Controls.Add(date);
            Controls.Add(doctorIdLabel);
            Controls.Add(doctorId);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DoctorSchdulesForm";
            Text = "Add Doctor Schedules";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox doctorId;
        private Label doctorIdLabel;
        private DateTimePicker date;
        private Label DateLabel;
        private Label StartTimeLabel;
        private DateTimePicker startTime;
        private Label EndTimeLabel;
        private DateTimePicker endTime;
        private Label AppointmentLabel;
        private Label patientsLabel;
        private TextBox patients;
        private Label locationLabel;
        private Label noteLabel;
        private TextBox note;
        private Button submitBtn;
        private Label label1;
        private ComboBox location;
        private ComboBox appointmentType;
    }
}