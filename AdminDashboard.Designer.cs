namespace HealthCarePlus
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            adminTabs = new MaterialSkin.Controls.MaterialTabControl();
            Doctor = new TabPage();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            imageList1 = new ImageList(components);
            adminTabs.SuspendLayout();
            SuspendLayout();
            // 
            // adminTabs
            // 
            adminTabs.Controls.Add(Doctor);
            adminTabs.Controls.Add(tabPage2);
            adminTabs.Controls.Add(tabPage1);
            adminTabs.Depth = 0;
            adminTabs.Dock = DockStyle.Bottom;
            adminTabs.HotTrack = true;
            adminTabs.ImageList = imageList1;
            adminTabs.Location = new Point(0, 0);
            adminTabs.MouseState = MaterialSkin.MouseState.HOVER;
            adminTabs.Multiline = true;
            adminTabs.Name = "adminTabs";
            adminTabs.SelectedIndex = 0;
            adminTabs.Size = new Size(1054, 617);
            adminTabs.TabIndex = 0;
            // 
            // Doctor
            // 
            Doctor.BackColor = Color.White;
            Doctor.ImageKey = "icons8-doctor-female-skin-type-1-48.png";
            Doctor.Location = new Point(4, 27);
            Doctor.Name = "Doctor";
            Doctor.Padding = new Padding(3);
            Doctor.Size = new Size(1046, 586);
            Doctor.TabIndex = 0;
            Doctor.Text = "Doctor";
            Doctor.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.ImageKey = "icons8-patient-48.png";
            tabPage2.Location = new Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1046, 586);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Patient";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1046, 586);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-facial-recognition-48.png");
            imageList1.Images.SetKeyName(1, "icons8-patient-48.png");
            imageList1.Images.SetKeyName(2, "icons8-doctor-female-skin-type-1-48.png");
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1054, 617);
            Controls.Add(adminTabs);
            Name = "AdminDashboard";
            Text = "Admin Dashboard";
            Load += Form4_Load;
            adminTabs.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl adminTabs;
        private TabPage Doctor;
        private TabPage tabPage2;
        private ImageList imageList1;
        private TabPage tabPage1;
    }
}