using System.Windows.Forms;

namespace HealthCarePlus
{
    partial class searchForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchForm));
            doctorTable = new DataGridView();
            doctorId = new DataGridViewTextBoxColumn();
            doctorFullName = new DataGridViewTextBoxColumn();
            doctorContactNumber = new DataGridViewTextBoxColumn();
            doctorEmail = new DataGridViewTextBoxColumn();
            doctorLocation = new DataGridViewTextBoxColumn();
            doctorAvailability = new DataGridViewTextBoxColumn();
            doctorExpertise = new DataGridViewTextBoxColumn();
            doctorOtherDetails = new DataGridViewTextBoxColumn();
            noteLabel = new Label();
            fullName = new TextBox();
            location = new ComboBox();
            locationLabel = new Label();
            expertise = new ComboBox();
            label3 = new Label();
            available = new CheckBox();
            clearBtn = new Button();
            label1 = new Label();
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            doctorTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            doctorTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doctorTable.Columns.AddRange(new DataGridViewColumn[] { doctorId, doctorFullName, doctorContactNumber, doctorEmail, doctorLocation, doctorAvailability, doctorExpertise, doctorOtherDetails });
            doctorTable.EnableHeadersVisualStyles = false;
            doctorTable.Location = new Point(68, 304);
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
            doctorId.DataPropertyName = "DoctorID";
            doctorId.HeaderText = "Id";
            doctorId.Name = "doctorId";
            doctorId.Width = 41;
            // 
            // doctorFullName
            // 
            doctorFullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doctorFullName.DataPropertyName = "FullName";
            doctorFullName.HeaderText = "Full Name";
            doctorFullName.Name = "doctorFullName";
            // 
            // doctorContactNumber
            // 
            doctorContactNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            doctorContactNumber.DataPropertyName = "ContactNumber";
            doctorContactNumber.HeaderText = "Contact";
            doctorContactNumber.Name = "doctorContactNumber";
            doctorContactNumber.Width = 73;
            // 
            // doctorEmail
            // 
            doctorEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doctorEmail.DataPropertyName = "Email";
            doctorEmail.HeaderText = "Email";
            doctorEmail.Name = "doctorEmail";
            // 
            // doctorLocation
            // 
            doctorLocation.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doctorLocation.DataPropertyName = "Location";
            doctorLocation.HeaderText = "Location";
            doctorLocation.Name = "doctorLocation";
            // 
            // doctorAvailability
            // 
            doctorAvailability.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doctorAvailability.DataPropertyName = "Availability";
            doctorAvailability.HeaderText = "Availability";
            doctorAvailability.Name = "doctorAvailability";
            // 
            // doctorExpertise
            // 
            doctorExpertise.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doctorExpertise.DataPropertyName = "Expertise";
            doctorExpertise.HeaderText = "Expertise";
            doctorExpertise.Name = "doctorExpertise";
            // 
            // doctorOtherDetails
            // 
            doctorOtherDetails.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doctorOtherDetails.DataPropertyName = "OtherDetails";
            doctorOtherDetails.HeaderText = "Other Details";
            doctorOtherDetails.Name = "doctorOtherDetails";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new Point(68, 147);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(61, 15);
            noteLabel.TabIndex = 36;
            noteLabel.Text = "Full Name";
            // 
            // fullName
            // 
            fullName.AutoCompleteCustomSource.AddRange(new string[] { "London", "Manchester", "Birmingham", "Edinburgh", "Glasgow", "Liverpool", "Leeds", "Bristol", "Sheffield", "Newcastle" });
            fullName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            fullName.BorderStyle = BorderStyle.FixedSingle;
            fullName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            fullName.Location = new Point(68, 165);
            fullName.Name = "fullName";
            fullName.Size = new Size(279, 33);
            fullName.TabIndex = 35;
            fullName.TextChanged += fullName_TextChanged;
            // 
            // location
            // 
            location.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            location.FormattingEnabled = true;
            location.Items.AddRange(new object[] { "London", "Manchester", "Birmingham", "Edinburgh", "Glasgow", "Liverpool", "Leeds", "Bristol", "Sheffield", "Newcastle" });
            location.Location = new Point(363, 165);
            location.Name = "location";
            location.Size = new Size(279, 33);
            location.TabIndex = 48;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new Point(363, 147);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(53, 15);
            locationLabel.TabIndex = 47;
            locationLabel.Text = "Location";
            // 
            // expertise
            // 
            expertise.AutoCompleteCustomSource.AddRange(new string[] { "Cardiology", "Dermatology", "Gastroenterology", "Neurology", "Orthopedics", "Pediatrics", "Psychiatry", "Radiology", "Surgery", "Urology" });
            expertise.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            expertise.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            expertise.FormattingEnabled = true;
            expertise.Items.AddRange(new object[] { "Cardiology", "Dermatology", "Gastroenterology", "Neurology", "Orthopedics", "Pediatrics", "Psychiatry", "Radiology", "Surgery", "Urology" });
            expertise.Location = new Point(660, 165);
            expertise.Name = "expertise";
            expertise.Size = new Size(279, 33);
            expertise.TabIndex = 50;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(660, 147);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 49;
            label3.Text = "Expertise";
            // 
            // available
            // 
            available.AutoSize = true;
            available.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            available.Location = new Point(960, 169);
            available.Name = "available";
            available.Padding = new Padding(4, 0, 0, 0);
            available.Size = new Size(110, 29);
            available.TabIndex = 51;
            available.Text = "available";
            available.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.IndianRed;
            clearBtn.BackgroundImageLayout = ImageLayout.None;
            clearBtn.Cursor = Cursors.Hand;
            clearBtn.FlatAppearance.BorderSize = 0;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clearBtn.ForeColor = SystemColors.Desktop;
            clearBtn.Image = (Image)resources.GetObject("clearBtn.Image");
            clearBtn.ImageAlign = ContentAlignment.MiddleRight;
            clearBtn.Location = new Point(1094, 161);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(167, 37);
            clearBtn.TabIndex = 52;
            clearBtn.Text = "clear search";
            clearBtn.TextAlign = ContentAlignment.MiddleLeft;
            clearBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(68, 25);
            label1.Name = "label1";
            label1.Size = new Size(185, 36);
            label1.TabIndex = 53;
            label1.Text = "Doctor Search";
            // 
            // searchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1325, 834);
            Controls.Add(label1);
            Controls.Add(clearBtn);
            Controls.Add(available);
            Controls.Add(expertise);
            Controls.Add(label3);
            Controls.Add(location);
            Controls.Add(locationLabel);
            Controls.Add(noteLabel);
            Controls.Add(fullName);
            Controls.Add(doctorTable);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "searchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search";
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
        private Label noteLabel;
        private TextBox fullName;
        private ComboBox location;
        private Label locationLabel;
        private ComboBox expertise;
        private Label label3;
        private CheckBox available;
        private Button clearBtn;
        private Label label1;
    }
}