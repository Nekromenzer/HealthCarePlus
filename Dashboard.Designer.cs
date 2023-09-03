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
            addDoctorSchedules = new Button();
            addDoctorBtn = new Button();
            SuspendLayout();
            // 
            // addDoctorSchedules
            // 
            addDoctorSchedules.Location = new Point(12, 95);
            addDoctorSchedules.Name = "addDoctorSchedules";
            addDoctorSchedules.Size = new Size(171, 49);
            addDoctorSchedules.TabIndex = 1;
            addDoctorSchedules.Text = "Add doctor schdule";
            addDoctorSchedules.UseVisualStyleBackColor = true;
            addDoctorSchedules.Click += button1_Click;
            // 
            // addDoctorBtn
            // 
            addDoctorBtn.Location = new Point(12, 173);
            addDoctorBtn.Name = "addDoctorBtn";
            addDoctorBtn.Size = new Size(171, 49);
            addDoctorBtn.TabIndex = 2;
            addDoctorBtn.Text = "Add doctor";
            addDoctorBtn.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addDoctorBtn);
            Controls.Add(addDoctorSchedules);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Form3_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button addDoctorSchedules;
        private Button addDoctorBtn;
    }
}