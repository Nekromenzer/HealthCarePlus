namespace HealthCarePlus
{
    partial class AppointmentForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            appointmentTable = new DataGridView();
            idCol = new DataGridViewTextBoxColumn();
            scheduleCol = new DataGridViewTextBoxColumn();
            doctorCol = new DataGridViewTextBoxColumn();
            patientCol = new DataGridViewTextBoxColumn();
            dateCol = new DataGridViewTextBoxColumn();
            timeCol = new DataGridViewTextBoxColumn();
            statusCol = new DataGridViewTextBoxColumn();
            priceCol = new DataGridViewTextBoxColumn();
            state = new ComboBox();
            stateLabel = new Label();
            submitBtn = new Button();
            scheduleLabel = new Label();
            schedule = new ComboBox();
            date = new DateTimePicker();
            dateLabel = new Label();
            timeLabel = new Label();
            time = new DateTimePicker();
            patientLabel = new Label();
            patient = new ComboBox();
            updateBtn = new Button();
            deleteBtn = new Button();
            clearBtn = new Button();
            label1 = new Label();
            doctorLable = new Label();
            doctor = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)appointmentTable).BeginInit();
            SuspendLayout();
            // 
            // appointmentTable
            // 
            appointmentTable.AllowUserToAddRows = false;
            appointmentTable.AllowUserToDeleteRows = false;
            appointmentTable.AllowUserToOrderColumns = true;
            appointmentTable.AllowUserToResizeColumns = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            appointmentTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            appointmentTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            appointmentTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            appointmentTable.BackgroundColor = SystemColors.Control;
            appointmentTable.BorderStyle = BorderStyle.None;
            appointmentTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            appointmentTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            appointmentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentTable.Columns.AddRange(new DataGridViewColumn[] { idCol, scheduleCol, doctorCol, patientCol, dateCol, timeCol, statusCol, priceCol });
            appointmentTable.GridColor = SystemColors.Control;
            appointmentTable.Location = new Point(77, 315);
            appointmentTable.Name = "appointmentTable";
            appointmentTable.RowHeadersVisible = false;
            appointmentTable.RowTemplate.Height = 25;
            appointmentTable.RowTemplate.Resizable = DataGridViewTriState.True;
            appointmentTable.ScrollBars = ScrollBars.Vertical;
            appointmentTable.ShowCellErrors = false;
            appointmentTable.ShowCellToolTips = false;
            appointmentTable.ShowEditingIcon = false;
            appointmentTable.ShowRowErrors = false;
            appointmentTable.Size = new Size(1180, 484);
            appointmentTable.TabIndex = 0;
            appointmentTable.CellContentClick += appointmentTable_CellContentClick;
            appointmentTable.CellFormatting += appointmentTable_CellFormatting;
            // 
            // idCol
            // 
            idCol.DataPropertyName = "AppointmentID";
            idCol.FillWeight = 50F;
            idCol.HeaderText = "ID";
            idCol.Name = "idCol";
            idCol.ReadOnly = true;
            idCol.Width = 43;
            // 
            // scheduleCol
            // 
            scheduleCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            scheduleCol.DataPropertyName = "ScheduleID";
            scheduleCol.HeaderText = "Schedule";
            scheduleCol.Name = "scheduleCol";
            scheduleCol.ReadOnly = true;
            // 
            // doctorCol
            // 
            doctorCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            doctorCol.DataPropertyName = "DoctorID ";
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveCaption;
            doctorCol.DefaultCellStyle = dataGridViewCellStyle4;
            doctorCol.HeaderText = "Doctor";
            doctorCol.Name = "doctorCol";
            doctorCol.ReadOnly = true;
            // 
            // patientCol
            // 
            patientCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            patientCol.DataPropertyName = "PatientID";
            patientCol.HeaderText = "Patient";
            patientCol.Name = "patientCol";
            patientCol.ReadOnly = true;
            // 
            // dateCol
            // 
            dateCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dateCol.DataPropertyName = "Date";
            dateCol.HeaderText = "Date";
            dateCol.Name = "dateCol";
            dateCol.ReadOnly = true;
            dateCol.Width = 56;
            // 
            // timeCol
            // 
            timeCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            timeCol.DataPropertyName = "Time";
            timeCol.HeaderText = "Time";
            timeCol.Name = "timeCol";
            timeCol.ReadOnly = true;
            timeCol.Width = 58;
            // 
            // statusCol
            // 
            statusCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            statusCol.DataPropertyName = "Status";
            statusCol.HeaderText = "States";
            statusCol.Name = "statusCol";
            statusCol.ReadOnly = true;
            statusCol.Width = 63;
            // 
            // priceCol
            // 
            priceCol.DataPropertyName = "Price";
            priceCol.HeaderText = "Charge";
            priceCol.Name = "priceCol";
            priceCol.ReadOnly = true;
            priceCol.Width = 70;
            // 
            // state
            // 
            state.AutoCompleteCustomSource.AddRange(new string[] { "Pending", "Ongoing", "Complete" });
            state.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            state.FormattingEnabled = true;
            state.Items.AddRange(new object[] { "Pending ", "Ongoing", "Complete" });
            state.Location = new Point(75, 191);
            state.Name = "state";
            state.Size = new Size(279, 33);
            state.TabIndex = 1;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            stateLabel.Location = new Point(75, 171);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(39, 17);
            stateLabel.TabIndex = 2;
            stateLabel.Text = "State";
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
            submitBtn.Location = new Point(77, 256);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(220, 37);
            submitBtn.TabIndex = 21;
            submitBtn.Text = "Create Appointment";
            submitBtn.TextAlign = ContentAlignment.MiddleLeft;
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // scheduleLabel
            // 
            scheduleLabel.AutoSize = true;
            scheduleLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            scheduleLabel.Location = new Point(384, 101);
            scheduleLabel.Name = "scheduleLabel";
            scheduleLabel.Size = new Size(62, 17);
            scheduleLabel.TabIndex = 23;
            scheduleLabel.Text = "Schedule";
            // 
            // schedule
            // 
            schedule.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            schedule.FormattingEnabled = true;
            schedule.Location = new Point(384, 121);
            schedule.Name = "schedule";
            schedule.Size = new Size(279, 33);
            schedule.TabIndex = 22;
            // 
            // date
            // 
            date.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            date.Location = new Point(702, 124);
            date.Name = "date";
            date.Size = new Size(279, 33);
            date.TabIndex = 24;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dateLabel.Location = new Point(702, 104);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(36, 17);
            dateLabel.TabIndex = 25;
            dateLabel.Text = "Date";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            timeLabel.Location = new Point(702, 171);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(37, 17);
            timeLabel.TabIndex = 27;
            timeLabel.Text = "Time";
            // 
            // time
            // 
            time.CustomFormat = "HH:mm";
            time.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            time.Format = DateTimePickerFormat.Custom;
            time.Location = new Point(702, 191);
            time.Name = "time";
            time.Size = new Size(279, 33);
            time.TabIndex = 26;
            // 
            // patientLabel
            // 
            patientLabel.AutoSize = true;
            patientLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            patientLabel.Location = new Point(384, 171);
            patientLabel.Name = "patientLabel";
            patientLabel.Size = new Size(51, 17);
            patientLabel.TabIndex = 29;
            patientLabel.Text = "Patient";
            // 
            // patient
            // 
            patient.AutoCompleteCustomSource.AddRange(new string[] { "Pending", "Ongoing", "Complete" });
            patient.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            patient.FormattingEnabled = true;
            patient.Location = new Point(384, 191);
            patient.Name = "patient";
            patient.Size = new Size(279, 33);
            patient.TabIndex = 28;
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
            updateBtn.Location = new Point(331, 256);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(167, 37);
            updateBtn.TabIndex = 26;
            updateBtn.Text = "Update ";
            updateBtn.TextAlign = ContentAlignment.MiddleLeft;
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
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
            deleteBtn.Location = new Point(537, 256);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(167, 37);
            deleteBtn.TabIndex = 27;
            deleteBtn.Text = "Delete";
            deleteBtn.TextAlign = ContentAlignment.MiddleLeft;
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
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
            clearBtn.Location = new Point(823, 256);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(167, 37);
            clearBtn.TabIndex = 28;
            clearBtn.Text = "clear";
            clearBtn.TextAlign = ContentAlignment.MiddleLeft;
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(77, 27);
            label1.Name = "label1";
            label1.Size = new Size(179, 36);
            label1.TabIndex = 22;
            label1.Text = "Appointment";
            // 
            // doctorLable
            // 
            doctorLable.AutoSize = true;
            doctorLable.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            doctorLable.Location = new Point(75, 101);
            doctorLable.Name = "doctorLable";
            doctorLable.Size = new Size(49, 17);
            doctorLable.TabIndex = 31;
            doctorLable.Text = "Doctor";
            // 
            // doctor
            // 
            doctor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            doctor.FormattingEnabled = true;
            doctor.Location = new Point(75, 121);
            doctor.Name = "doctor";
            doctor.Size = new Size(279, 33);
            doctor.TabIndex = 30;
            doctor.SelectedIndexChanged += doctor_SelectedIndexChanged;
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1325, 834);
            Controls.Add(doctorLable);
            Controls.Add(doctor);
            Controls.Add(label1);
            Controls.Add(clearBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(patientLabel);
            Controls.Add(patient);
            Controls.Add(timeLabel);
            Controls.Add(time);
            Controls.Add(dateLabel);
            Controls.Add(date);
            Controls.Add(scheduleLabel);
            Controls.Add(schedule);
            Controls.Add(submitBtn);
            Controls.Add(stateLabel);
            Controls.Add(state);
            Controls.Add(appointmentTable);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AppointmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appointment";
            ((System.ComponentModel.ISupportInitialize)appointmentTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView appointmentTable;
        private ComboBox state;
        private Label stateLabel;
        private Button submitBtn;
        private Label scheduleLabel;
        private ComboBox schedule;
        private DateTimePicker date;
        private Label dateLabel;
        private Label timeLabel;
        private DateTimePicker time;
        private Label patientLabel;
        private ComboBox patient;
        private Button updateBtn;
        private Button deleteBtn;
        private Button clearBtn;
        private Label label1;
        private Label doctorLable;
        private ComboBox doctor;
        private DataGridViewTextBoxColumn sheduleCol;
        private DataGridViewTextBoxColumn idCol;
        private DataGridViewTextBoxColumn scheduleCol;
        private DataGridViewTextBoxColumn doctorCol;
        private DataGridViewTextBoxColumn patientCol;
        private DataGridViewTextBoxColumn dateCol;
        private DataGridViewTextBoxColumn timeCol;
        private DataGridViewTextBoxColumn statusCol;
        private DataGridViewTextBoxColumn priceCol;
    }
}