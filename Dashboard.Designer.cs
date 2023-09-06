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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            addDoctorSchedules = new Button();
            addDoctorBtn = new Button();
            SuspendLayout();
            // 
            // addDoctorSchedules
            // 
            addDoctorSchedules.Location = new Point(40, 267);
            addDoctorSchedules.Name = "addDoctorSchedules";
            addDoctorSchedules.Size = new Size(171, 49);
            addDoctorSchedules.TabIndex = 1;
            addDoctorSchedules.Text = "Add doctor schdule";
            addDoctorSchedules.UseVisualStyleBackColor = true;
            addDoctorSchedules.Click += button1_Click;
            // 
            // addDoctorBtn
            // 
            addDoctorBtn.Location = new Point(40, 345);
            addDoctorBtn.Name = "addDoctorBtn";
            addDoctorBtn.Size = new Size(171, 49);
            addDoctorBtn.TabIndex = 2;
            addDoctorBtn.Text = "Add doctor";
            addDoctorBtn.UseVisualStyleBackColor = true;
            addDoctorBtn.Click += addDoctorBtn_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1325, 834);
            Controls.Add(addDoctorBtn);
            Controls.Add(addDoctorSchedules);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            TransparencyKey = Color.WhiteSmoke;
            Load += Form3_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button addDoctorSchedules;
        private Button addDoctorBtn;
    }
}