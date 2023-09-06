namespace HealthCarePlus
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
            addDoctorSchedules = new Button();
            addDoctorBtn = new Button();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            searchDoctor = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // addDoctorSchedules
            // 
            addDoctorSchedules.BackColor = Color.MediumSeaGreen;
            addDoctorSchedules.FlatStyle = FlatStyle.Flat;
            addDoctorSchedules.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            addDoctorSchedules.ForeColor = Color.WhiteSmoke;
            addDoctorSchedules.Image = (Image)resources.GetObject("addDoctorSchedules.Image");
            addDoctorSchedules.ImageAlign = ContentAlignment.MiddleRight;
            addDoctorSchedules.Location = new Point(41, 568);
            addDoctorSchedules.Name = "addDoctorSchedules";
            addDoctorSchedules.Padding = new Padding(10, 0, 10, 0);
            addDoctorSchedules.Size = new Size(223, 49);
            addDoctorSchedules.TabIndex = 1;
            addDoctorSchedules.Text = "Add  Schdule";
            addDoctorSchedules.UseVisualStyleBackColor = false;
            addDoctorSchedules.Click += button1_Click;
            // 
            // addDoctorBtn
            // 
            addDoctorBtn.BackColor = Color.MediumSeaGreen;
            addDoctorBtn.FlatAppearance.BorderSize = 0;
            addDoctorBtn.FlatStyle = FlatStyle.Flat;
            addDoctorBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            addDoctorBtn.ForeColor = Color.WhiteSmoke;
            addDoctorBtn.Image = (Image)resources.GetObject("addDoctorBtn.Image");
            addDoctorBtn.ImageAlign = ContentAlignment.MiddleRight;
            addDoctorBtn.Location = new Point(41, 492);
            addDoctorBtn.Margin = new Padding(0);
            addDoctorBtn.Name = "addDoctorBtn";
            addDoctorBtn.Padding = new Padding(10, 0, 10, 0);
            addDoctorBtn.Size = new Size(223, 49);
            addDoctorBtn.TabIndex = 2;
            addDoctorBtn.Text = "Add Doctor";
            addDoctorBtn.UseVisualStyleBackColor = false;
            addDoctorBtn.Click += addDoctorBtn_Click;
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
            pictureBox1.Location = new Point(99, 244);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 118);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // searchDoctor
            // 
            searchDoctor.BackColor = Color.LightSeaGreen;
            searchDoctor.FlatAppearance.BorderSize = 0;
            searchDoctor.FlatStyle = FlatStyle.Flat;
            searchDoctor.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            searchDoctor.ForeColor = Color.WhiteSmoke;
            searchDoctor.Image = (Image)resources.GetObject("searchDoctor.Image");
            searchDoctor.ImageAlign = ContentAlignment.MiddleRight;
            searchDoctor.Location = new Point(41, 412);
            searchDoctor.Margin = new Padding(0);
            searchDoctor.Name = "searchDoctor";
            searchDoctor.Padding = new Padding(10, 0, 10, 0);
            searchDoctor.Size = new Size(223, 49);
            searchDoctor.TabIndex = 4;
            searchDoctor.Text = "Search Doctor";
            searchDoctor.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1325, 834);
            Controls.Add(searchDoctor);
            Controls.Add(pictureBox1);
            Controls.Add(addDoctorBtn);
            Controls.Add(addDoctorSchedules);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            TransparencyKey = Color.WhiteSmoke;
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button addDoctorSchedules;
        private Button addDoctorBtn;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Button searchDoctor;
    }
}