namespace HealthCarePlus
{
    partial class DoctorDetailsPopupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorDetailsPopupForm));
            doctorNameLabel = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            doctorEmailLabel = new Label();
            label3 = new Label();
            doctorContactNumber = new Label();
            label4 = new Label();
            doctorLocation = new Label();
            labelava = new Label();
            doctorAvailability = new Label();
            label5 = new Label();
            doctorExpertise = new Label();
            doctorOtherDetails = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // doctorNameLabel
            // 
            doctorNameLabel.AutoSize = true;
            doctorNameLabel.BackColor = Color.Transparent;
            doctorNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            doctorNameLabel.Location = new Point(276, 219);
            doctorNameLabel.Name = "doctorNameLabel";
            doctorNameLabel.Size = new Size(71, 21);
            doctorNameLabel.TabIndex = 0;
            doctorNameLabel.Text = "Jane doe";
            doctorNameLabel.Click += doctorNameLabel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(207, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 118);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Enabled = false;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(88, 219);
            label1.Name = "label1";
            label1.Size = new Size(141, 27);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Enabled = false;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(88, 259);
            label2.Name = "label2";
            label2.Size = new Size(141, 27);
            label2.TabIndex = 7;
            label2.Text = "Email";
            // 
            // doctorEmailLabel
            // 
            doctorEmailLabel.AutoSize = true;
            doctorEmailLabel.BackColor = Color.Transparent;
            doctorEmailLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            doctorEmailLabel.Location = new Point(276, 259);
            doctorEmailLabel.Name = "doctorEmailLabel";
            doctorEmailLabel.Size = new Size(152, 21);
            doctorEmailLabel.TabIndex = 6;
            doctorEmailLabel.Text = "janedoe@gmail.com";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Enabled = false;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(88, 298);
            label3.Name = "label3";
            label3.Size = new Size(141, 27);
            label3.TabIndex = 9;
            label3.Text = "Contact";
            // 
            // doctorContactNumber
            // 
            doctorContactNumber.AutoSize = true;
            doctorContactNumber.BackColor = Color.Transparent;
            doctorContactNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            doctorContactNumber.Location = new Point(276, 298);
            doctorContactNumber.Name = "doctorContactNumber";
            doctorContactNumber.Size = new Size(100, 21);
            doctorContactNumber.TabIndex = 8;
            doctorContactNumber.Text = "0112033300";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Enabled = false;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(88, 337);
            label4.Name = "label4";
            label4.Size = new Size(141, 27);
            label4.TabIndex = 11;
            label4.Text = "Location";
            // 
            // doctorLocation
            // 
            doctorLocation.AutoSize = true;
            doctorLocation.BackColor = Color.Transparent;
            doctorLocation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            doctorLocation.Location = new Point(276, 337);
            doctorLocation.Name = "doctorLocation";
            doctorLocation.Size = new Size(63, 21);
            doctorLocation.TabIndex = 10;
            doctorLocation.Text = "London";
            // 
            // labelava
            // 
            labelava.BackColor = Color.Transparent;
            labelava.Enabled = false;
            labelava.FlatStyle = FlatStyle.Flat;
            labelava.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelava.Image = (Image)resources.GetObject("labelava.Image");
            labelava.ImageAlign = ContentAlignment.MiddleRight;
            labelava.Location = new Point(88, 377);
            labelava.Name = "labelava";
            labelava.Size = new Size(141, 27);
            labelava.TabIndex = 13;
            labelava.Text = "Availability";
            // 
            // doctorAvailability
            // 
            doctorAvailability.AutoSize = true;
            doctorAvailability.BackColor = Color.Transparent;
            doctorAvailability.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            doctorAvailability.Location = new Point(276, 377);
            doctorAvailability.Name = "doctorAvailability";
            doctorAvailability.Size = new Size(73, 21);
            doctorAvailability.TabIndex = 12;
            doctorAvailability.Text = "Available";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Enabled = false;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.ImageAlign = ContentAlignment.MiddleRight;
            label5.Location = new Point(88, 419);
            label5.Name = "label5";
            label5.Size = new Size(141, 27);
            label5.TabIndex = 15;
            label5.Text = "Expertise";
            // 
            // doctorExpertise
            // 
            doctorExpertise.AutoSize = true;
            doctorExpertise.BackColor = Color.Transparent;
            doctorExpertise.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            doctorExpertise.Location = new Point(276, 419);
            doctorExpertise.Name = "doctorExpertise";
            doctorExpertise.Size = new Size(80, 21);
            doctorExpertise.TabIndex = 14;
            doctorExpertise.Text = "Cadiology";
            // 
            // doctorOtherDetails
            // 
            doctorOtherDetails.BackColor = Color.Transparent;
            doctorOtherDetails.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            doctorOtherDetails.Location = new Point(88, 488);
            doctorOtherDetails.Name = "doctorOtherDetails";
            doctorOtherDetails.Size = new Size(359, 137);
            doctorOtherDetails.TabIndex = 16;
            doctorOtherDetails.Text = "Specializes in heart-related issues.";
            doctorOtherDetails.Click += doctorOtherDetails_Click;
            // 
            // DoctorDetailsPopupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(525, 664);
            Controls.Add(doctorOtherDetails);
            Controls.Add(label5);
            Controls.Add(doctorExpertise);
            Controls.Add(labelava);
            Controls.Add(doctorAvailability);
            Controls.Add(label4);
            Controls.Add(doctorLocation);
            Controls.Add(label3);
            Controls.Add(doctorContactNumber);
            Controls.Add(label2);
            Controls.Add(doctorEmailLabel);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(doctorNameLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DoctorDetailsPopupForm";
            RightToLeft = RightToLeft.No;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctor Profile";
            Load += DoctorDetailsPopupForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label doctorNameLabel;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label doctorEmailLabel;
        private Label label3;
        private Label doctorContactNumber;
        private Label label4;
        private Label doctorLocation;
        private Label labelava;
        private Label doctorAvailability;
        private Label label5;
        private Label doctorExpertise;
        private Label doctorOtherDetails;
    }
}