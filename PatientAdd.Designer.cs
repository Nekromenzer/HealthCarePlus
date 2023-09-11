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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientAddForm));
            patientTable = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            dob = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            contact = new DataGridViewTextBoxColumn();
            nic = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            submitBtn = new Button();
            clearBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            label1 = new Label();
            noteLabel = new Label();
            fullNameInput = new TextBox();
            label2 = new Label();
            phoneInput = new TextBox();
            DateLabel = new Label();
            dobInput = new DateTimePicker();
            label3 = new Label();
            nicInput = new TextBox();
            label4 = new Label();
            addressInput = new TextBox();
            genderInput = new GroupBox();
            female = new RadioButton();
            male = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)patientTable).BeginInit();
            genderInput.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            patientTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            patientTable.CellContentClick += patientTable_CellContentClick;
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
            submitBtn.Location = new Point(68, 236);
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
            clearBtn.Location = new Point(759, 236);
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
            deleteBtn.Location = new Point(473, 236);
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
            updateBtn.Location = new Point(267, 236);
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
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new Point(68, 83);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(61, 15);
            noteLabel.TabIndex = 44;
            noteLabel.Text = "Full Name";
            // 
            // fullNameInput
            // 
            fullNameInput.AutoCompleteCustomSource.AddRange(new string[] { "London", "Manchester", "Birmingham", "Edinburgh", "Glasgow", "Liverpool", "Leeds", "Bristol", "Sheffield", "Newcastle" });
            fullNameInput.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            fullNameInput.BorderStyle = BorderStyle.FixedSingle;
            fullNameInput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            fullNameInput.Location = new Point(68, 101);
            fullNameInput.Name = "fullNameInput";
            fullNameInput.Size = new Size(279, 33);
            fullNameInput.TabIndex = 43;
            fullNameInput.TextChanged += fullName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 82);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 46;
            label2.Text = "Phone";
            // 
            // phoneInput
            // 
            phoneInput.BackColor = SystemColors.Window;
            phoneInput.BorderStyle = BorderStyle.FixedSingle;
            phoneInput.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            phoneInput.Location = new Point(373, 100);
            phoneInput.Margin = new Padding(6);
            phoneInput.MinimumSize = new Size(30, 33);
            phoneInput.Name = "phoneInput";
            phoneInput.Size = new Size(279, 33);
            phoneInput.TabIndex = 45;
            phoneInput.TextChanged += phone_TextChanged;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(676, 81);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(73, 15);
            DateLabel.TabIndex = 48;
            DateLabel.Text = "Date of Birth";
            // 
            // dobInput
            // 
            dobInput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dobInput.Format = DateTimePickerFormat.Short;
            dobInput.Location = new Point(676, 99);
            dobInput.MaxDate = new DateTime(2023, 9, 1, 0, 0, 0, 0);
            dobInput.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dobInput.Name = "dobInput";
            dobInput.Size = new Size(279, 33);
            dobInput.TabIndex = 47;
            dobInput.Value = new DateTime(2023, 9, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(982, 81);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 50;
            label3.Text = "NIC";
            // 
            // nicInput
            // 
            nicInput.BackColor = SystemColors.Window;
            nicInput.BorderStyle = BorderStyle.FixedSingle;
            nicInput.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nicInput.Location = new Point(982, 99);
            nicInput.Margin = new Padding(6);
            nicInput.MinimumSize = new Size(30, 33);
            nicInput.Name = "nicInput";
            nicInput.Size = new Size(279, 33);
            nicInput.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 144);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 52;
            label4.Text = "Address";
            // 
            // addressInput
            // 
            addressInput.BackColor = SystemColors.Window;
            addressInput.BorderStyle = BorderStyle.FixedSingle;
            addressInput.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addressInput.Location = new Point(68, 162);
            addressInput.Margin = new Padding(6);
            addressInput.MinimumSize = new Size(30, 33);
            addressInput.Name = "addressInput";
            addressInput.Size = new Size(584, 33);
            addressInput.TabIndex = 51;
            // 
            // genderInput
            // 
            genderInput.BackColor = Color.Transparent;
            genderInput.Controls.Add(female);
            genderInput.Controls.Add(male);
            genderInput.Location = new Point(676, 143);
            genderInput.Name = "genderInput";
            genderInput.Size = new Size(200, 52);
            genderInput.TabIndex = 53;
            genderInput.TabStop = false;
            genderInput.Text = "Gender";
            genderInput.Enter += genderInput_Enter;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            female.Location = new Point(121, 14);
            female.Name = "female";
            female.Size = new Size(78, 25);
            female.TabIndex = 1;
            female.TabStop = true;
            female.Text = "Female";
            female.UseVisualStyleBackColor = true;
            female.CheckedChanged += female_CheckedChanged;
            // 
            // male
            // 
            male.AutoSize = true;
            male.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            male.Location = new Point(40, 14);
            male.Name = "male";
            male.Size = new Size(62, 25);
            male.TabIndex = 0;
            male.TabStop = true;
            male.Text = "Male";
            male.UseVisualStyleBackColor = true;
            male.CheckedChanged += male_CheckedChanged;
            // 
            // PatientAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1325, 834);
            Controls.Add(genderInput);
            Controls.Add(label4);
            Controls.Add(addressInput);
            Controls.Add(label3);
            Controls.Add(nicInput);
            Controls.Add(DateLabel);
            Controls.Add(dobInput);
            Controls.Add(label2);
            Controls.Add(phoneInput);
            Controls.Add(noteLabel);
            Controls.Add(fullNameInput);
            Controls.Add(label1);
            Controls.Add(clearBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(submitBtn);
            Controls.Add(patientTable);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PatientAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Patient";
            Load += PatientAddForm_Load;
            ((System.ComponentModel.ISupportInitialize)patientTable).EndInit();
            genderInput.ResumeLayout(false);
            genderInput.PerformLayout();
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
        private TextBox fullNameInput;
        private Label label2;
        private TextBox phoneInput;
        private Label DateLabel;
        private DateTimePicker dobInput;
        private Label label3;
        private TextBox nicInput;
        private Label label4;
        private TextBox addressInput;
        private GroupBox genderInput;
        private RadioButton female;
        private RadioButton male;
    }
}