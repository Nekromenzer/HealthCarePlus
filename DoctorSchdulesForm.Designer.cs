﻿using System.Windows.Forms;

namespace HealthCarePlus
{
    partial class DoctorSchdulesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorSchdulesForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            doctorId = new TextBox();
            doctorIdLabel = new Label();
            date = new DateTimePicker();
            DateLabel = new Label();
            StartTimeLabel = new Label();
            startTime = new DateTimePicker();
            EndTimeLabel = new Label();
            endTime = new DateTimePicker();
            AppointmentLabel = new Label();
            RoomLabel = new Label();
            rooms = new TextBox();
            locationLabel = new Label();
            priceLabel = new Label();
            price = new TextBox();
            submitBtn = new Button();
            label1 = new Label();
            location = new ComboBox();
            appointmentType = new ComboBox();
            doctoSchdulesTable = new DataGridView();
            updateBtn = new Button();
            deleteBtn = new Button();
            clearBtn = new Button();
            ScheduleID = new DataGridViewTextBoxColumn();
            patientIDCol = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            RoomNumber = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            ScheduleDate = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            PriceHeader = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)doctoSchdulesTable).BeginInit();
            SuspendLayout();
            // 
            // doctorId
            // 
            doctorId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            doctorId.AutoCompleteSource = AutoCompleteSource.CustomSource;
            doctorId.BorderStyle = BorderStyle.FixedSingle;
            doctorId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            doctorId.Location = new Point(77, 105);
            doctorId.Name = "doctorId";
            doctorId.PlaceholderText = "Dr.Jane Low";
            doctorId.Size = new Size(279, 33);
            doctorId.TabIndex = 0;
            doctorId.TextChanged += doctorId_TextChanged;
            // 
            // doctorIdLabel
            // 
            doctorIdLabel.AutoSize = true;
            doctorIdLabel.BackColor = Color.Transparent;
            doctorIdLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            doctorIdLabel.Location = new Point(77, 83);
            doctorIdLabel.Name = "doctorIdLabel";
            doctorIdLabel.Size = new Size(49, 17);
            doctorIdLabel.TabIndex = 1;
            doctorIdLabel.Text = "Doctor";
            // 
            // date
            // 
            date.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            date.Format = DateTimePickerFormat.Short;
            date.Location = new Point(78, 173);
            date.MinDate = new DateTime(2023, 8, 31, 0, 0, 0, 0);
            date.Name = "date";
            date.Size = new Size(278, 33);
            date.TabIndex = 4;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.BackColor = Color.Transparent;
            DateLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DateLabel.Location = new Point(78, 151);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(36, 17);
            DateLabel.TabIndex = 5;
            DateLabel.Text = "Date";
            // 
            // StartTimeLabel
            // 
            StartTimeLabel.AutoSize = true;
            StartTimeLabel.BackColor = Color.Transparent;
            StartTimeLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            StartTimeLabel.Location = new Point(376, 151);
            StartTimeLabel.Name = "StartTimeLabel";
            StartTimeLabel.Size = new Size(70, 17);
            StartTimeLabel.TabIndex = 7;
            StartTimeLabel.Text = "Start Time";
            // 
            // startTime
            // 
            startTime.CustomFormat = "HH:mm";
            startTime.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            startTime.Format = DateTimePickerFormat.Custom;
            startTime.Location = new Point(376, 173);
            startTime.MinDate = new DateTime(2023, 8, 31, 0, 0, 0, 0);
            startTime.Name = "startTime";
            startTime.ShowUpDown = true;
            startTime.Size = new Size(279, 33);
            startTime.TabIndex = 6;
            // 
            // EndTimeLabel
            // 
            EndTimeLabel.AutoSize = true;
            EndTimeLabel.BackColor = Color.Transparent;
            EndTimeLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            EndTimeLabel.Location = new Point(676, 151);
            EndTimeLabel.Name = "EndTimeLabel";
            EndTimeLabel.Size = new Size(64, 17);
            EndTimeLabel.TabIndex = 9;
            EndTimeLabel.Text = "End Time";
            // 
            // endTime
            // 
            endTime.CustomFormat = "HH:mm";
            endTime.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            endTime.Format = DateTimePickerFormat.Custom;
            endTime.Location = new Point(676, 173);
            endTime.MinDate = new DateTime(2023, 8, 31, 0, 0, 0, 0);
            endTime.Name = "endTime";
            endTime.ShowUpDown = true;
            endTime.Size = new Size(279, 33);
            endTime.TabIndex = 8;
            // 
            // AppointmentLabel
            // 
            AppointmentLabel.AutoSize = true;
            AppointmentLabel.BackColor = Color.Transparent;
            AppointmentLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AppointmentLabel.Location = new Point(676, 84);
            AppointmentLabel.Name = "AppointmentLabel";
            AppointmentLabel.Size = new Size(121, 17);
            AppointmentLabel.TabIndex = 11;
            AppointmentLabel.Text = "Appointment Type";
            // 
            // RoomLabel
            // 
            RoomLabel.AutoSize = true;
            RoomLabel.BackColor = Color.Transparent;
            RoomLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            RoomLabel.Location = new Point(376, 84);
            RoomLabel.Name = "RoomLabel";
            RoomLabel.Size = new Size(98, 17);
            RoomLabel.TabIndex = 13;
            RoomLabel.Text = "Room Number";
            // 
            // rooms
            // 
            rooms.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            rooms.AutoCompleteSource = AutoCompleteSource.CustomSource;
            rooms.BorderStyle = BorderStyle.FixedSingle;
            rooms.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rooms.Location = new Point(376, 106);
            rooms.Name = "rooms";
            rooms.Size = new Size(279, 33);
            rooms.TabIndex = 12;
            rooms.TextChanged += rooms_TextChanged;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.BackColor = Color.Transparent;
            locationLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            locationLabel.Location = new Point(978, 84);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(59, 17);
            locationLabel.TabIndex = 17;
            locationLabel.Text = "Location";
            locationLabel.Click += locationLabel_Click;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.BackColor = Color.Transparent;
            priceLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            priceLabel.Location = new Point(978, 151);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(37, 17);
            priceLabel.TabIndex = 19;
            priceLabel.Text = "Price";
            // 
            // price
            // 
            price.AutoCompleteCustomSource.AddRange(new string[] { "London", "Manchester", "Birmingham", "Edinburgh", "Glasgow", "Liverpool", "Leeds", "Bristol", "Sheffield", "Newcastle" });
            price.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            price.BorderStyle = BorderStyle.FixedSingle;
            price.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            price.Location = new Point(978, 173);
            price.Name = "price";
            price.Size = new Size(279, 33);
            price.TabIndex = 18;
            price.TextChanged += note_TextChanged;
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
            submitBtn.Location = new Point(77, 235);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(167, 37);
            submitBtn.TabIndex = 21;
            submitBtn.Text = "Add Schedule";
            submitBtn.TextAlign = ContentAlignment.MiddleLeft;
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(72, 30);
            label1.Name = "label1";
            label1.Size = new Size(284, 36);
            label1.TabIndex = 22;
            label1.Text = "Add Doctor Schedules";
            // 
            // location
            // 
            location.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            location.FormattingEnabled = true;
            location.Items.AddRange(new object[] { "London", "Manchester", "Birmingham", "Edinburgh", "Glasgow", "Liverpool", "Leeds", "Bristol", "Sheffield", "Newcastle" });
            location.Location = new Point(978, 106);
            location.Name = "location";
            location.Size = new Size(279, 33);
            location.TabIndex = 23;
            // 
            // appointmentType
            // 
            appointmentType.AutoCompleteCustomSource.AddRange(new string[] { "General Checkup", "Follow-up Visit", "Consultation", "Vaccination", "Test Results Discussion", "Treatment Session", "Procedure or Surgery", "Specialized Consultation", "Medication Review", "Physical Therapy Session" });
            appointmentType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            appointmentType.FormattingEnabled = true;
            appointmentType.Items.AddRange(new object[] { "General Checkup", "Follow-up Visit", "Consultation", "Vaccination", "Test Results Discussion", "Treatment Session", "Procedure or Surgery", "Specialized Consultation", "Medication Review", "Physical Therapy Session" });
            appointmentType.Location = new Point(676, 106);
            appointmentType.Name = "appointmentType";
            appointmentType.Size = new Size(279, 33);
            appointmentType.TabIndex = 24;
            appointmentType.SelectedIndexChanged += appointmentType_SelectedIndexChanged;
            // 
            // doctoSchdulesTable
            // 
            doctoSchdulesTable.AllowUserToAddRows = false;
            doctoSchdulesTable.AllowUserToDeleteRows = false;
            doctoSchdulesTable.AllowUserToOrderColumns = true;
            doctoSchdulesTable.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            doctoSchdulesTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            doctoSchdulesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            doctoSchdulesTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            doctoSchdulesTable.BackgroundColor = SystemColors.Control;
            doctoSchdulesTable.BorderStyle = BorderStyle.None;
            doctoSchdulesTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            doctoSchdulesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            doctoSchdulesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doctoSchdulesTable.Columns.AddRange(new DataGridViewColumn[] { ScheduleID, patientIDCol, dataGridViewTextBoxColumn1, RoomNumber, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, ScheduleDate, dataGridViewTextBoxColumn5, PriceHeader });
            doctoSchdulesTable.GridColor = SystemColors.Control;
            doctoSchdulesTable.Location = new Point(77, 315);
            doctoSchdulesTable.Name = "doctoSchdulesTable";
            doctoSchdulesTable.RowHeadersVisible = false;
            doctoSchdulesTable.RowTemplate.Height = 25;
            doctoSchdulesTable.RowTemplate.Resizable = DataGridViewTriState.True;
            doctoSchdulesTable.ScrollBars = ScrollBars.Vertical;
            doctoSchdulesTable.ShowCellErrors = false;
            doctoSchdulesTable.ShowCellToolTips = false;
            doctoSchdulesTable.ShowEditingIcon = false;
            doctoSchdulesTable.ShowRowErrors = false;
            doctoSchdulesTable.Size = new Size(1180, 484);
            doctoSchdulesTable.TabIndex = 25;
            doctoSchdulesTable.CellClick += doctoSchdulesTable_CellClick;
            doctoSchdulesTable.CellContentClick += doctoSchdulesTable_CellContentClick;
            doctoSchdulesTable.CellFormatting += doctoSchdulesTable_CellFormatting;
            doctoSchdulesTable.SelectionChanged += doctoSchdulesTable_SelectionChanged;
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
            updateBtn.Location = new Point(282, 235);
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
            deleteBtn.Location = new Point(488, 235);
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
            clearBtn.Location = new Point(774, 235);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(167, 37);
            clearBtn.TabIndex = 28;
            clearBtn.Text = "clear";
            clearBtn.TextAlign = ContentAlignment.MiddleLeft;
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // ScheduleID
            // 
            ScheduleID.DataPropertyName = "ScheduleID";
            ScheduleID.FillWeight = 382.0895F;
            ScheduleID.HeaderText = "ID";
            ScheduleID.MinimumWidth = 2;
            ScheduleID.Name = "ScheduleID";
            ScheduleID.Width = 43;
            // 
            // patientIDCol
            // 
            patientIDCol.DataPropertyName = "PatientID";
            patientIDCol.HeaderText = "p id";
            patientIDCol.Name = "patientIDCol";
            patientIDCol.Visible = false;
            patientIDCol.Width = 52;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.DataPropertyName = "DoctorID";
            dataGridViewTextBoxColumn1.FillWeight = 59.7015038F;
            dataGridViewTextBoxColumn1.HeaderText = "Doctor Name";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // RoomNumber
            // 
            RoomNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RoomNumber.DataPropertyName = "RoomNumber";
            RoomNumber.FillWeight = 59.7015038F;
            RoomNumber.HeaderText = "Room Number";
            RoomNumber.Name = "RoomNumber";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "AppointmentType";
            dataGridViewTextBoxColumn2.HeaderText = "Appointment Type";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.DataPropertyName = "StartTime";
            dataGridViewTextBoxColumn3.FillWeight = 59.7015038F;
            dataGridViewTextBoxColumn3.HeaderText = "Start Time";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.DataPropertyName = "EndTime";
            dataGridViewTextBoxColumn4.FillWeight = 59.7015038F;
            dataGridViewTextBoxColumn4.HeaderText = "End Time";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // ScheduleDate
            // 
            ScheduleDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ScheduleDate.DataPropertyName = "ScheduleDate";
            ScheduleDate.FillWeight = 59.7015038F;
            ScheduleDate.HeaderText = "Schedule Date";
            ScheduleDate.Name = "ScheduleDate";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.DataPropertyName = "Location";
            dataGridViewTextBoxColumn5.FillWeight = 59.7015038F;
            dataGridViewTextBoxColumn5.HeaderText = "Location";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // PriceHeader
            // 
            PriceHeader.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PriceHeader.DataPropertyName = "Price";
            PriceHeader.FillWeight = 59.7015038F;
            PriceHeader.HeaderText = "Price per schedule";
            PriceHeader.Name = "PriceHeader";
            // 
            // DoctorSchdulesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1325, 834);
            Controls.Add(clearBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(doctoSchdulesTable);
            Controls.Add(appointmentType);
            Controls.Add(location);
            Controls.Add(label1);
            Controls.Add(submitBtn);
            Controls.Add(priceLabel);
            Controls.Add(price);
            Controls.Add(locationLabel);
            Controls.Add(RoomLabel);
            Controls.Add(rooms);
            Controls.Add(AppointmentLabel);
            Controls.Add(EndTimeLabel);
            Controls.Add(endTime);
            Controls.Add(StartTimeLabel);
            Controls.Add(startTime);
            Controls.Add(DateLabel);
            Controls.Add(date);
            Controls.Add(doctorIdLabel);
            Controls.Add(doctorId);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DoctorSchdulesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Doctor Schedules";
            TopMost = true;
            Load += DoctorSchdulesForm_Load;
            ((System.ComponentModel.ISupportInitialize)doctoSchdulesTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox doctorId;
        private Label doctorIdLabel;
        private DateTimePicker date;
        private Label DateLabel;
        private Label StartTimeLabel;
        private DateTimePicker startTime;
        private Label EndTimeLabel;
        private DateTimePicker endTime;
        private Label AppointmentLabel;
        private Label RoomLabel;
        private TextBox rooms;
        private Label locationLabel;
        private Label priceLabel;
        private TextBox price;
        private Button submitBtn;
        private Label label1;
        private ComboBox location;
        private ComboBox appointmentType;
        private DataGridView doctoSchdulesTable;
        private DataGridViewTextBoxColumn SchedduleID;
        private Button updateBtn;
        private Button deleteBtn;
        private Button clearBtn;
        private DataGridViewTextBoxColumn ScheduleID;
        private DataGridViewTextBoxColumn patientIDCol;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn ScheduleDate;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn PriceHeader;
    }
}