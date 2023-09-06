﻿namespace HealthCarePlus
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            addDoctorSchedulesBtn = new Button();
            manageDoctorBtn = new Button();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            searchDoctorBtn = new Button();
            searchPatient = new Button();
            pictureBox2 = new PictureBox();
            managePatientBtn = new Button();
            addAppointmentBtn = new Button();
            logoutBtn = new Button();
            roomSearchBtn = new Button();
            pictureBox3 = new PictureBox();
            scannersBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // addDoctorSchedulesBtn
            // 
            addDoctorSchedulesBtn.BackColor = Color.ForestGreen;
            addDoctorSchedulesBtn.FlatStyle = FlatStyle.Flat;
            addDoctorSchedulesBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            addDoctorSchedulesBtn.ForeColor = Color.WhiteSmoke;
            addDoctorSchedulesBtn.Image = (Image)resources.GetObject("addDoctorSchedulesBtn.Image");
            addDoctorSchedulesBtn.ImageAlign = ContentAlignment.MiddleRight;
            addDoctorSchedulesBtn.Location = new Point(128, 644);
            addDoctorSchedulesBtn.Name = "addDoctorSchedulesBtn";
            addDoctorSchedulesBtn.Padding = new Padding(10, 0, 10, 0);
            addDoctorSchedulesBtn.Size = new Size(260, 49);
            addDoctorSchedulesBtn.TabIndex = 1;
            addDoctorSchedulesBtn.Text = "Schdules";
            addDoctorSchedulesBtn.TextAlign = ContentAlignment.MiddleLeft;
            addDoctorSchedulesBtn.UseVisualStyleBackColor = false;
            addDoctorSchedulesBtn.Click += button1_Click;
            // 
            // manageDoctorBtn
            // 
            manageDoctorBtn.BackColor = Color.SeaGreen;
            manageDoctorBtn.FlatAppearance.BorderSize = 0;
            manageDoctorBtn.FlatStyle = FlatStyle.Flat;
            manageDoctorBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            manageDoctorBtn.ForeColor = Color.WhiteSmoke;
            manageDoctorBtn.Image = (Image)resources.GetObject("manageDoctorBtn.Image");
            manageDoctorBtn.ImageAlign = ContentAlignment.MiddleRight;
            manageDoctorBtn.Location = new Point(128, 556);
            manageDoctorBtn.Margin = new Padding(0);
            manageDoctorBtn.Name = "manageDoctorBtn";
            manageDoctorBtn.Padding = new Padding(10, 0, 10, 0);
            manageDoctorBtn.Size = new Size(260, 49);
            manageDoctorBtn.TabIndex = 2;
            manageDoctorBtn.Text = "Manage Doctor";
            manageDoctorBtn.TextAlign = ContentAlignment.MiddleLeft;
            manageDoctorBtn.UseVisualStyleBackColor = false;
            manageDoctorBtn.Click += addDoctorBtn_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-facial-recognition-48.png");
            imageList1.Images.SetKeyName(1, "icons8-patient-48.png");
            imageList1.Images.SetKeyName(2, "icons8-doctor-female-skin-type-1-48.png");
            imageList1.Images.SetKeyName(3, "icons8-report-48.png");
            imageList1.Images.SetKeyName(4, "icons8-microscope-48.png");
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(200, 297);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 118);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // searchDoctorBtn
            // 
            searchDoctorBtn.BackColor = Color.LightSeaGreen;
            searchDoctorBtn.FlatAppearance.BorderSize = 0;
            searchDoctorBtn.FlatStyle = FlatStyle.Flat;
            searchDoctorBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            searchDoctorBtn.ForeColor = Color.WhiteSmoke;
            searchDoctorBtn.Image = (Image)resources.GetObject("searchDoctorBtn.Image");
            searchDoctorBtn.ImageAlign = ContentAlignment.MiddleRight;
            searchDoctorBtn.Location = new Point(128, 465);
            searchDoctorBtn.Margin = new Padding(0);
            searchDoctorBtn.Name = "searchDoctorBtn";
            searchDoctorBtn.Padding = new Padding(10, 0, 10, 0);
            searchDoctorBtn.Size = new Size(260, 49);
            searchDoctorBtn.TabIndex = 4;
            searchDoctorBtn.Text = "Search Doctor";
            searchDoctorBtn.TextAlign = ContentAlignment.MiddleLeft;
            searchDoctorBtn.UseVisualStyleBackColor = false;
            // 
            // searchPatient
            // 
            searchPatient.BackColor = Color.LightSeaGreen;
            searchPatient.FlatAppearance.BorderSize = 0;
            searchPatient.FlatStyle = FlatStyle.Flat;
            searchPatient.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            searchPatient.ForeColor = Color.WhiteSmoke;
            searchPatient.Image = (Image)resources.GetObject("searchPatient.Image");
            searchPatient.ImageAlign = ContentAlignment.MiddleRight;
            searchPatient.Location = new Point(537, 465);
            searchPatient.Margin = new Padding(0);
            searchPatient.Name = "searchPatient";
            searchPatient.Padding = new Padding(10, 0, 10, 0);
            searchPatient.Size = new Size(260, 49);
            searchPatient.TabIndex = 8;
            searchPatient.Text = "Search Patient";
            searchPatient.TextAlign = ContentAlignment.MiddleLeft;
            searchPatient.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(621, 297);
            pictureBox2.Margin = new Padding(5, 3, 3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(118, 118);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // managePatientBtn
            // 
            managePatientBtn.BackColor = Color.SeaGreen;
            managePatientBtn.FlatAppearance.BorderSize = 0;
            managePatientBtn.FlatStyle = FlatStyle.Flat;
            managePatientBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            managePatientBtn.ForeColor = Color.WhiteSmoke;
            managePatientBtn.Image = (Image)resources.GetObject("managePatientBtn.Image");
            managePatientBtn.ImageAlign = ContentAlignment.MiddleRight;
            managePatientBtn.Location = new Point(537, 556);
            managePatientBtn.Margin = new Padding(0);
            managePatientBtn.Name = "managePatientBtn";
            managePatientBtn.Padding = new Padding(10, 0, 10, 0);
            managePatientBtn.Size = new Size(260, 49);
            managePatientBtn.TabIndex = 6;
            managePatientBtn.Text = "Manage Patient";
            managePatientBtn.TextAlign = ContentAlignment.MiddleLeft;
            managePatientBtn.UseVisualStyleBackColor = false;
            // 
            // addAppointmentBtn
            // 
            addAppointmentBtn.BackColor = Color.ForestGreen;
            addAppointmentBtn.FlatStyle = FlatStyle.Flat;
            addAppointmentBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            addAppointmentBtn.ForeColor = Color.WhiteSmoke;
            addAppointmentBtn.Image = (Image)resources.GetObject("addAppointmentBtn.Image");
            addAppointmentBtn.ImageAlign = ContentAlignment.MiddleRight;
            addAppointmentBtn.Location = new Point(537, 644);
            addAppointmentBtn.Name = "addAppointmentBtn";
            addAppointmentBtn.Padding = new Padding(10, 0, 10, 0);
            addAppointmentBtn.Size = new Size(260, 49);
            addAppointmentBtn.TabIndex = 5;
            addAppointmentBtn.Text = "Appointments";
            addAppointmentBtn.TextAlign = ContentAlignment.MiddleLeft;
            addAppointmentBtn.UseVisualStyleBackColor = false;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = SystemColors.ActiveBorder;
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            logoutBtn.ForeColor = Color.Black;
            logoutBtn.Image = (Image)resources.GetObject("logoutBtn.Image");
            logoutBtn.ImageAlign = ContentAlignment.MiddleRight;
            logoutBtn.Location = new Point(1181, 9);
            logoutBtn.Margin = new Padding(0);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Padding = new Padding(10, 0, 10, 0);
            logoutBtn.Size = new Size(135, 35);
            logoutBtn.TabIndex = 9;
            logoutBtn.Text = "Logout";
            logoutBtn.TextAlign = ContentAlignment.MiddleLeft;
            logoutBtn.UseVisualStyleBackColor = false;
            // 
            // roomSearchBtn
            // 
            roomSearchBtn.BackColor = Color.SaddleBrown;
            roomSearchBtn.FlatAppearance.BorderSize = 0;
            roomSearchBtn.FlatStyle = FlatStyle.Flat;
            roomSearchBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            roomSearchBtn.ForeColor = Color.WhiteSmoke;
            roomSearchBtn.Image = (Image)resources.GetObject("roomSearchBtn.Image");
            roomSearchBtn.ImageAlign = ContentAlignment.MiddleRight;
            roomSearchBtn.Location = new Point(935, 465);
            roomSearchBtn.Margin = new Padding(0);
            roomSearchBtn.Name = "roomSearchBtn";
            roomSearchBtn.Padding = new Padding(10, 0, 10, 0);
            roomSearchBtn.Size = new Size(260, 49);
            roomSearchBtn.TabIndex = 13;
            roomSearchBtn.Text = "Room/Theater";
            roomSearchBtn.TextAlign = ContentAlignment.MiddleLeft;
            roomSearchBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(1019, 297);
            pictureBox3.Margin = new Padding(5, 3, 3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(118, 118);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // scannersBtn
            // 
            scannersBtn.BackColor = Color.DimGray;
            scannersBtn.FlatAppearance.BorderSize = 0;
            scannersBtn.FlatStyle = FlatStyle.Flat;
            scannersBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            scannersBtn.ForeColor = Color.WhiteSmoke;
            scannersBtn.Image = (Image)resources.GetObject("scannersBtn.Image");
            scannersBtn.ImageAlign = ContentAlignment.MiddleRight;
            scannersBtn.Location = new Point(935, 556);
            scannersBtn.Margin = new Padding(0);
            scannersBtn.Name = "scannersBtn";
            scannersBtn.Padding = new Padding(10, 0, 10, 0);
            scannersBtn.Size = new Size(260, 49);
            scannersBtn.TabIndex = 11;
            scannersBtn.Text = "Scanners";
            scannersBtn.TextAlign = ContentAlignment.MiddleLeft;
            scannersBtn.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1325, 834);
            Controls.Add(roomSearchBtn);
            Controls.Add(pictureBox3);
            Controls.Add(scannersBtn);
            Controls.Add(logoutBtn);
            Controls.Add(searchPatient);
            Controls.Add(pictureBox2);
            Controls.Add(managePatientBtn);
            Controls.Add(addAppointmentBtn);
            Controls.Add(searchDoctorBtn);
            Controls.Add(pictureBox1);
            Controls.Add(manageDoctorBtn);
            Controls.Add(addDoctorSchedulesBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            TransparencyKey = Color.WhiteSmoke;
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button addDoctorSchedulesBtn;
        private Button manageDoctorBtn;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Button searchDoctorBtn;
        private Button searchPatient;
        private PictureBox pictureBox2;
        private Button managePatientBtn;
        private Button addAppointmentBtn;
        private Button logoutBtn;
        private Button roomSearchBtn;
        private PictureBox pictureBox3;
        private Button scannersBtn;
    }
}