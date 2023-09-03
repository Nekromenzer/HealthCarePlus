namespace HealthCarePlus
{
    partial class DoctorAddForm
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
            doctorTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)doctorTable).BeginInit();
            SuspendLayout();
            // 
            // doctorTable
            // 
            doctorTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doctorTable.Location = new Point(345, 320);
            doctorTable.Name = "doctorTable";
            doctorTable.RowTemplate.Height = 25;
            doctorTable.Size = new Size(240, 150);
            doctorTable.TabIndex = 0;
            doctorTable.CellContentClick += doctorTable_CellContentClick;
            // 
            // DoctorAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 834);
            Controls.Add(doctorTable);
            Name = "DoctorAddForm";
            Text = "Add Doctor";
            ((System.ComponentModel.ISupportInitialize)doctorTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView doctorTable;
    }
}