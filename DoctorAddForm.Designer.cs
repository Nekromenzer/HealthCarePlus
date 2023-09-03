using System.Windows.Forms;

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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            doctorTable = new DataGridView();
            doctorId = new DataGridViewTextBoxColumn();
            doctorFullName = new DataGridViewTextBoxColumn();
            doctorContactNumber = new DataGridViewTextBoxColumn();
            doctorEmail = new DataGridViewTextBoxColumn();
            doctorLocation = new DataGridViewTextBoxColumn();
            doctorAvailability = new DataGridViewTextBoxColumn();
            doctorExpertise = new DataGridViewTextBoxColumn();
            doctorOtherDetails = new DataGridViewTextBoxColumn();
            label1 = new Label();
            clearBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            submitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)doctorTable).BeginInit();
            SuspendLayout();
            // 
            // doctorTable
            // 
            doctorTable.AllowUserToAddRows = false;
            doctorTable.AllowUserToOrderColumns = true;
            doctorTable.AllowUserToResizeColumns = false;
            doctorTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            doctorTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            doctorTable.BackgroundColor = SystemColors.Control;
            doctorTable.BorderStyle = BorderStyle.None;
            doctorTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            doctorTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            doctorTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doctorTable.Columns.AddRange(new DataGridViewColumn[] { doctorId, doctorFullName, doctorContactNumber, doctorEmail, doctorLocation, doctorAvailability, doctorExpertise, doctorOtherDetails });
            doctorTable.EnableHeadersVisualStyles = false;
            doctorTable.Location = new Point(68, 309);
            doctorTable.Name = "doctorTable";
            doctorTable.RowHeadersVisible = false;
            doctorTable.RowTemplate.Height = 25;
            doctorTable.ScrollBars = ScrollBars.Vertical;
            doctorTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            doctorTable.Size = new Size(1193, 484);
            doctorTable.TabIndex = 0;
            doctorTable.CellContentClick += doctorTable_CellContentClick;
            // 
            // doctorId
            // 
            doctorId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            doctorId.DataPropertyName = "DoctorID";
            doctorId.HeaderText = "ID";
            doctorId.Name = "doctorId";
            doctorId.Width = 42;
            // 
            // doctorFullName
            // 
            doctorFullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doctorFullName.DataPropertyName = "FullName";
            doctorFullName.FillWeight = 40.9090919F;
            doctorFullName.HeaderText = "Full Name";
            doctorFullName.Name = "doctorFullName";
            // 
            // doctorContactNumber
            // 
            doctorContactNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            doctorContactNumber.DataPropertyName = "ContactNumber";
            doctorContactNumber.FillWeight = 40.9090919F;
            doctorContactNumber.HeaderText = "Phone";
            doctorContactNumber.Name = "doctorContactNumber";
            // 
            // doctorEmail
            // 
            doctorEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doctorEmail.DataPropertyName = "Email";
            doctorEmail.FillWeight = 40.9090919F;
            doctorEmail.HeaderText = "Email";
            doctorEmail.Name = "doctorEmail";
            // 
            // doctorLocation
            // 
            doctorLocation.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doctorLocation.DataPropertyName = "Location";
            doctorLocation.FillWeight = 40.9090919F;
            doctorLocation.HeaderText = "Location";
            doctorLocation.Name = "doctorLocation";
            // 
            // doctorAvailability
            // 
            doctorAvailability.DataPropertyName = "Availability";
            doctorAvailability.FillWeight = 454.545441F;
            doctorAvailability.HeaderText = "Availability";
            doctorAvailability.Name = "doctorAvailability";
            doctorAvailability.Width = 89;
            // 
            // doctorExpertise
            // 
            doctorExpertise.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doctorExpertise.DataPropertyName = "Expertise";
            doctorExpertise.FillWeight = 40.9090919F;
            doctorExpertise.HeaderText = "Expertise";
            doctorExpertise.Name = "doctorExpertise";
            // 
            // doctorOtherDetails
            // 
            doctorOtherDetails.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doctorOtherDetails.DataPropertyName = "OtherDetails";
            doctorOtherDetails.FillWeight = 40.9090919F;
            doctorOtherDetails.HeaderText = "Other Details";
            doctorOtherDetails.Name = "doctorOtherDetails";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(68, 19);
            label1.Name = "label1";
            label1.Size = new Size(154, 36);
            label1.TabIndex = 23;
            label1.Text = "Add Doctor";
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.White;
            clearBtn.BackgroundImageLayout = ImageLayout.None;
            clearBtn.Cursor = Cursors.Hand;
            clearBtn.FlatAppearance.BorderSize = 0;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clearBtn.ForeColor = Color.DimGray;
            clearBtn.Location = new Point(767, 226);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(167, 37);
            clearBtn.TabIndex = 32;
            clearBtn.Text = "clear";
            clearBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.IndianRed;
            deleteBtn.BackgroundImageLayout = ImageLayout.None;
            deleteBtn.Cursor = Cursors.Hand;
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.ForeColor = SystemColors.ButtonHighlight;
            deleteBtn.Location = new Point(481, 226);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(167, 37);
            deleteBtn.TabIndex = 31;
            deleteBtn.Text = "Delete ❌";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.Gold;
            updateBtn.BackgroundImageLayout = ImageLayout.None;
            updateBtn.Cursor = Cursors.Hand;
            updateBtn.FlatAppearance.BorderSize = 0;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            updateBtn.ForeColor = SystemColors.ActiveCaptionText;
            updateBtn.Location = new Point(275, 226);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(167, 37);
            updateBtn.TabIndex = 30;
            updateBtn.Text = "Update  🔧";
            updateBtn.UseVisualStyleBackColor = false;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.DodgerBlue;
            submitBtn.BackgroundImageLayout = ImageLayout.None;
            submitBtn.Cursor = Cursors.Hand;
            submitBtn.FlatAppearance.BorderSize = 0;
            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            submitBtn.Location = new Point(68, 226);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(167, 37);
            submitBtn.TabIndex = 29;
            submitBtn.Text = "Add Schedule ➕";
            submitBtn.UseVisualStyleBackColor = false;
            // 
            // DoctorAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 834);
            Controls.Add(clearBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(submitBtn);
            Controls.Add(label1);
            Controls.Add(doctorTable);
            Name = "DoctorAddForm";
            Text = "Add Doctor";
            ((System.ComponentModel.ISupportInitialize)doctorTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView doctorTable;
        private DataGridViewTextBoxColumn doctorId;
        private DataGridViewTextBoxColumn doctorFullName;
        private DataGridViewTextBoxColumn doctorContactNumber;
        private DataGridViewTextBoxColumn doctorEmail;
        private DataGridViewTextBoxColumn doctorLocation;
        private DataGridViewTextBoxColumn doctorAvailability;
        private DataGridViewTextBoxColumn doctorExpertise;
        private DataGridViewTextBoxColumn doctorOtherDetails;
        private Label label1;
        private Button clearBtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Button submitBtn;
    }
}