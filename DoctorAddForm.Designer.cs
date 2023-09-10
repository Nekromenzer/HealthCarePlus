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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorAddForm));
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
            noteLabel = new Label();
            fullName = new TextBox();
            clearBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            submitBtn = new Button();
            emailLabel = new Label();
            email = new TextBox();
            label2 = new Label();
            phone = new TextBox();
            location = new ComboBox();
            locationLabel = new Label();
            expertise = new ComboBox();
            label3 = new Label();
            available = new CheckBox();
            label4 = new Label();
            otherDetails = new TextBox();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            doctorTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            doctorTable.CellClick += doctorTable_CellClick;
            doctorTable.CellContentClick += doctorTable_CellContentClick;
            doctorTable.SelectionChanged += doctorTable_SelectionChanged;
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
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new Point(68, 72);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(61, 15);
            noteLabel.TabIndex = 34;
            noteLabel.Text = "Full Name";
            // 
            // fullName
            // 
            fullName.AutoCompleteCustomSource.AddRange(new string[] { "London", "Manchester", "Birmingham", "Edinburgh", "Glasgow", "Liverpool", "Leeds", "Bristol", "Sheffield", "Newcastle" });
            fullName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            fullName.BorderStyle = BorderStyle.FixedSingle;
            fullName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            fullName.Location = new Point(68, 90);
            fullName.Name = "fullName";
            fullName.Size = new Size(279, 33);
            fullName.TabIndex = 33;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.White;
            clearBtn.BackgroundImageLayout = ImageLayout.None;
            clearBtn.Cursor = Cursors.Hand;
            clearBtn.FlatAppearance.BorderSize = 0;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clearBtn.ForeColor = SystemColors.Desktop;
            clearBtn.Image = (Image)resources.GetObject("clearBtn.Image");
            clearBtn.ImageAlign = ContentAlignment.MiddleRight;
            clearBtn.Location = new Point(766, 231);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(167, 37);
            clearBtn.TabIndex = 38;
            clearBtn.Text = "clear";
            clearBtn.TextAlign = ContentAlignment.MiddleLeft;
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
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
            deleteBtn.Image = (Image)resources.GetObject("deleteBtn.Image");
            deleteBtn.ImageAlign = ContentAlignment.MiddleRight;
            deleteBtn.Location = new Point(480, 231);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(167, 37);
            deleteBtn.TabIndex = 37;
            deleteBtn.Text = "Delete";
            deleteBtn.TextAlign = ContentAlignment.MiddleLeft;
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
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
            updateBtn.Image = (Image)resources.GetObject("updateBtn.Image");
            updateBtn.ImageAlign = ContentAlignment.MiddleRight;
            updateBtn.Location = new Point(274, 231);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(167, 37);
            updateBtn.TabIndex = 36;
            updateBtn.Text = "Update ";
            updateBtn.TextAlign = ContentAlignment.MiddleLeft;
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.MediumSeaGreen;
            submitBtn.BackgroundImageLayout = ImageLayout.None;
            submitBtn.Cursor = Cursors.Hand;
            submitBtn.FlatAppearance.BorderSize = 0;
            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            submitBtn.Image = (Image)resources.GetObject("submitBtn.Image");
            submitBtn.ImageAlign = ContentAlignment.MiddleRight;
            submitBtn.Location = new Point(69, 231);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(167, 37);
            submitBtn.TabIndex = 35;
            submitBtn.Text = "Add Doctor";
            submitBtn.TextAlign = ContentAlignment.MiddleLeft;
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(369, 72);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 42;
            emailLabel.Text = "Email";
            // 
            // email
            // 
            email.BackColor = SystemColors.Window;
            email.BorderStyle = BorderStyle.FixedSingle;
            email.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(369, 90);
            email.Margin = new Padding(6);
            email.MinimumSize = new Size(30, 30);
            email.Name = "email";
            email.Size = new Size(279, 31);
            email.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(679, 72);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 44;
            label2.Text = "Phone";
            // 
            // phone
            // 
            phone.BackColor = SystemColors.Window;
            phone.BorderStyle = BorderStyle.FixedSingle;
            phone.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            phone.Location = new Point(679, 90);
            phone.Margin = new Padding(6);
            phone.MinimumSize = new Size(30, 30);
            phone.Name = "phone";
            phone.Size = new Size(279, 31);
            phone.TabIndex = 43;
            // 
            // location
            // 
            location.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            location.FormattingEnabled = true;
            location.Items.AddRange(new object[] { "London", "Manchester", "Birmingham", "Edinburgh", "Glasgow", "Liverpool", "Leeds", "Bristol", "Sheffield", "Newcastle" });
            location.Location = new Point(982, 90);
            location.Name = "location";
            location.Size = new Size(279, 33);
            location.TabIndex = 46;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new Point(982, 72);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(53, 15);
            locationLabel.TabIndex = 45;
            locationLabel.Text = "Location";
            // 
            // expertise
            // 
            expertise.AutoCompleteCustomSource.AddRange(new string[] { "Cardiology", "Dermatology", "Gastroenterology", "Neurology", "Orthopedics", "Pediatrics", "Psychiatry", "Radiology", "Surgery", "Urology" });
            expertise.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            expertise.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            expertise.FormattingEnabled = true;
            expertise.Items.AddRange(new object[] { "Cardiology", "Dermatology", "Gastroenterology", "Neurology", "Orthopedics", "Pediatrics", "Psychiatry", "Radiology", "Surgery", "Urology" });
            expertise.Location = new Point(68, 155);
            expertise.Name = "expertise";
            expertise.Size = new Size(279, 33);
            expertise.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 137);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 47;
            label3.Text = "Expertise";
            // 
            // available
            // 
            available.AutoSize = true;
            available.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            available.Location = new Point(369, 155);
            available.Name = "available";
            available.Padding = new Padding(4, 0, 0, 0);
            available.Size = new Size(110, 29);
            available.TabIndex = 49;
            available.Text = "available";
            available.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(507, 138);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 51;
            label4.Text = "Qualification";
            // 
            // otherDetails
            // 
            otherDetails.AutoCompleteCustomSource.AddRange(new string[] { "London", "Manchester", "Birmingham", "Edinburgh", "Glasgow", "Liverpool", "Leeds", "Bristol", "Sheffield", "Newcastle" });
            otherDetails.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            otherDetails.BorderStyle = BorderStyle.FixedSingle;
            otherDetails.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            otherDetails.Location = new Point(507, 156);
            otherDetails.Name = "otherDetails";
            otherDetails.Size = new Size(754, 33);
            otherDetails.TabIndex = 50;
            // 
            // DoctorAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1325, 834);
            Controls.Add(label4);
            Controls.Add(otherDetails);
            Controls.Add(available);
            Controls.Add(expertise);
            Controls.Add(label3);
            Controls.Add(location);
            Controls.Add(locationLabel);
            Controls.Add(label2);
            Controls.Add(phone);
            Controls.Add(emailLabel);
            Controls.Add(email);
            Controls.Add(clearBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(submitBtn);
            Controls.Add(noteLabel);
            Controls.Add(fullName);
            Controls.Add(label1);
            Controls.Add(doctorTable);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DoctorAddForm";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label noteLabel;
        private TextBox fullName;
        private Button clearBtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Button submitBtn;
        private Label emailLabel;
        private TextBox email;
        private Label label2;
        private TextBox phone;
        private ComboBox location;
        private Label locationLabel;
        private ComboBox expertise;
        private Label label3;
        private CheckBox available;
        private Label label4;
        private TextBox otherDetails;
    }
}