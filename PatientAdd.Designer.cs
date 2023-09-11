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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientAddForm));
            patientTable = new DataGridView();
            submitBtn = new Button();
            clearBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            label1 = new Label();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            dob = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            contact = new DataGridViewTextBoxColumn();
            nic = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            noteLabel = new Label();
            fullName = new TextBox();
            label2 = new Label();
            phone = new TextBox();
            ((System.ComponentModel.ISupportInitialize)patientTable).BeginInit();
            SuspendLayout();
            // 
            // patientTable
            // 
            patientTable.AllowUserToAddRows = false;
            patientTable.AllowUserToOrderColumns = true;
            patientTable.AllowUserToResizeColumns = false;
            patientTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            patientTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            patientTable.BackgroundColor = SystemColors.Control;
            patientTable.BorderStyle = BorderStyle.None;
            patientTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            patientTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            patientTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientTable.Columns.AddRange(new DataGridViewColumn[] { id, name, dob, gender, contact, nic, address });
            patientTable.EnableHeadersVisualStyles = false;
            patientTable.Location = new Point(68, 316);
            patientTable.Name = "patientTable";
            patientTable.RowHeadersVisible = false;
            patientTable.RowTemplate.Height = 25;
            patientTable.ScrollBars = ScrollBars.Vertical;
            patientTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            patientTable.Size = new Size(1193, 484);
            patientTable.TabIndex = 0;
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
            submitBtn.Location = new Point(68, 222);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(167, 37);
            submitBtn.TabIndex = 36;
            submitBtn.Text = "Add patient";
            submitBtn.TextAlign = ContentAlignment.MiddleLeft;
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
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
            clearBtn.Location = new Point(759, 222);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(167, 37);
            clearBtn.TabIndex = 41;
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
            deleteBtn.Location = new Point(473, 222);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(167, 37);
            deleteBtn.TabIndex = 40;
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
            updateBtn.Location = new Point(267, 222);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(167, 37);
            updateBtn.TabIndex = 39;
            updateBtn.Text = "Update ";
            updateBtn.TextAlign = ContentAlignment.MiddleLeft;
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(68, 19);
            label1.Name = "label1";
            label1.Size = new Size(158, 36);
            label1.TabIndex = 42;
            label1.Text = "Add Patient";
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            id.DataPropertyName = "PatientID";
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 42;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            name.DataPropertyName = "FullName";
            name.HeaderText = "Full Name";
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 85;
            // 
            // dob
            // 
            dob.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dob.DataPropertyName = "DateOfBirth";
            dob.HeaderText = "DOB";
            dob.Name = "dob";
            dob.ReadOnly = true;
            dob.Width = 55;
            // 
            // gender
            // 
            gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gender.DataPropertyName = "Gender";
            gender.HeaderText = "Gender";
            gender.Name = "gender";
            gender.ReadOnly = true;
            gender.Width = 69;
            // 
            // contact
            // 
            contact.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            contact.DataPropertyName = "ContactNumber";
            contact.HeaderText = "Contact";
            contact.Name = "contact";
            contact.ReadOnly = true;
            contact.Width = 73;
            // 
            // nic
            // 
            nic.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nic.DataPropertyName = "NIC";
            nic.HeaderText = "NIC";
            nic.Name = "nic";
            nic.ReadOnly = true;
            nic.Width = 51;
            // 
            // address
            // 
            address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            address.DataPropertyName = "Address";
            address.HeaderText = "Address";
            address.Name = "address";
            address.ReadOnly = true;
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new Point(68, 83);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(61, 15);
            noteLabel.TabIndex = 44;
            noteLabel.Text = "Full Name";
            // 
            // fullName
            // 
            fullName.AutoCompleteCustomSource.AddRange(new string[] { "London", "Manchester", "Birmingham", "Edinburgh", "Glasgow", "Liverpool", "Leeds", "Bristol", "Sheffield", "Newcastle" });
            fullName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            fullName.BorderStyle = BorderStyle.FixedSingle;
            fullName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            fullName.Location = new Point(68, 101);
            fullName.Name = "fullName";
            fullName.Size = new Size(279, 33);
            fullName.TabIndex = 43;
            fullName.TextChanged += fullName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(375, 83);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 46;
            label2.Text = "Phone";
            // 
            // phone
            // 
            phone.BackColor = SystemColors.Window;
            phone.BorderStyle = BorderStyle.FixedSingle;
            phone.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            phone.Location = new Point(375, 101);
            phone.Margin = new Padding(6);
            phone.MinimumSize = new Size(30, 30);
            phone.Name = "phone";
            phone.Size = new Size(279, 31);
            phone.TabIndex = 45;
            phone.TextChanged += phone_TextChanged;
            // 
            // PatientAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1325, 834);
            Controls.Add(label2);
            Controls.Add(phone);
            Controls.Add(noteLabel);
            Controls.Add(fullName);
            Controls.Add(label1);
            Controls.Add(clearBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(submitBtn);
            Controls.Add(patientTable);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PatientAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Patient";
            Load += PatientAddForm_Load;
            ((System.ComponentModel.ISupportInitialize)patientTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView patientTable;
        private Button submitBtn;
        private Button clearBtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Label label1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn dob;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn contact;
        private DataGridViewTextBoxColumn nic;
        private DataGridViewTextBoxColumn address;
        private Label noteLabel;
        private TextBox fullName;
        private Label label2;
        private TextBox phone;
    }
}