namespace HealthCarePlus
{
    partial class PatientAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientAddForm));
            patientTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)patientTable).BeginInit();
            SuspendLayout();
            // 
            // patientTable
            // 
            patientTable.AllowUserToAddRows = false;
            patientTable.AllowUserToDeleteRows = false;
            patientTable.AllowUserToResizeColumns = false;
            patientTable.AllowUserToResizeRows = false;
            patientTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientTable.Location = new Point(62, 303);
            patientTable.Name = "patientTable";
            patientTable.ReadOnly = true;
            patientTable.RowTemplate.Height = 25;
            patientTable.Size = new Size(1193, 484);
            patientTable.TabIndex = 0;
            // 
            // PatientAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1325, 834);
            Controls.Add(patientTable);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PatientAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient Add";
            ((System.ComponentModel.ISupportInitialize)patientTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView patientTable;
    }
}