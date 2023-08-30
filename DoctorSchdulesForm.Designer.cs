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
            appointmentTypeLabel = new Label();
            appointmentType = new TextBox();
            SuspendLayout();
            // 
            // doctorId
            // 
            doctorId.AutoCompleteMode = AutoCompleteMode.Suggest;
            doctorId.AutoCompleteSource = AutoCompleteSource.CustomSource;
            doctorId.BorderStyle = BorderStyle.FixedSingle;
            doctorId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            doctorId.Location = new Point(12, 128);
            doctorId.Name = "doctorId";
            doctorId.Size = new Size(239, 33);
            doctorId.TabIndex = 0;
            doctorId.TextChanged += doctorId_TextChanged;
            // 
            // doctorIdLabel
            // 
            doctorIdLabel.AutoSize = true;
            doctorIdLabel.Location = new Point(12, 110);
            doctorIdLabel.Name = "doctorIdLabel";
            doctorIdLabel.Size = new Size(43, 15);
            doctorIdLabel.TabIndex = 1;
            doctorIdLabel.Text = "Doctor";
            doctorIdLabel.Click += label1_Click;
            // 
            // appointmentTypeLabel
            // 
            appointmentTypeLabel.AutoSize = true;
            appointmentTypeLabel.Location = new Point(12, 189);
            appointmentTypeLabel.Name = "appointmentTypeLabel";
            appointmentTypeLabel.Size = new Size(104, 15);
            appointmentTypeLabel.TabIndex = 3;
            appointmentTypeLabel.Text = "Appointment type";
            appointmentTypeLabel.Click += label2_Click;
            // 
            // appointmentType
            // 
            appointmentType.AutoCompleteCustomSource.AddRange(new string[] { "Regular Check-up", "Consultation", "Follow-up", "Diagnostic Tests", "Treatment", "Vaccination", "Specialist Referral", "Emergency", "Preventive Care", "Physical Examination", "Counseling", "Medication Review", "Surgery", "Prenatal Care", "Postoperative Follow-up", "Dental Check-up", "Optometry Check-up", "Nutrition Consultation", "Physical Therapy", "Telemedicine" });
            appointmentType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            appointmentType.AutoCompleteSource = AutoCompleteSource.CustomSource;
            appointmentType.BorderStyle = BorderStyle.FixedSingle;
            appointmentType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            appointmentType.Location = new Point(12, 207);
            appointmentType.Name = "appointmentType";
            appointmentType.Size = new Size(239, 33);
            appointmentType.TabIndex = 2;
            // 
            // DoctorSchdulesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(appointmentTypeLabel);
            Controls.Add(appointmentType);
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
        private Label appointmentTypeLabel;
        private TextBox appointmentType;
    }
}