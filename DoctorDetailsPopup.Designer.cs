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
            SuspendLayout();
            // 
            // doctorNameLabel
            // 
            doctorNameLabel.AutoSize = true;
            doctorNameLabel.Location = new Point(206, 139);
            doctorNameLabel.Name = "doctorNameLabel";
            doctorNameLabel.Size = new Size(38, 15);
            doctorNameLabel.TabIndex = 0;
            doctorNameLabel.Text = "label1";
            doctorNameLabel.Click += doctorNameLabel_Click;
            // 
            // DoctorDetailsPopupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 754);
            Controls.Add(doctorNameLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DoctorDetailsPopupForm";
            RightToLeft = RightToLeft.No;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctor Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label doctorNameLabel;
    }
}