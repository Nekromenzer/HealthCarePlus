namespace HealthCarePlus
{
    partial class RoomTheaterForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomTheaterForm));
            roomsTable = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            roomTypeCol = new DataGridViewTextBoxColumn();
            roomNumberCol = new DataGridViewTextBoxColumn();
            allocatedCol = new DataGridViewTextBoxColumn();
            priceCol = new DataGridViewTextBoxColumn();
            patientIdCol = new DataGridViewTextBoxColumn();
            roomTheaterCol = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            roomsTab = new TabPage();
            DateLabel = new Label();
            date = new DateTimePicker();
            isRoom = new ComboBox();
            thaterLable = new Label();
            label1 = new Label();
            RoomClearBtn = new Button();
            RoomDeleteBtn = new Button();
            RoomUpdateBtn = new Button();
            RoomSubmitBtn = new Button();
            roomAllowcated = new CheckBox();
            priiceLabel = new Label();
            roomPrice = new TextBox();
            roomNumberLabel = new Label();
            roomNumber = new TextBox();
            roomType = new ComboBox();
            roomTypeLable = new Label();
            theaterTab = new TabPage();
            ((System.ComponentModel.ISupportInitialize)roomsTable).BeginInit();
            tabControl1.SuspendLayout();
            roomsTab.SuspendLayout();
            SuspendLayout();
            // 
            // roomsTable
            // 
            roomsTable.AllowUserToAddRows = false;
            roomsTable.AllowUserToDeleteRows = false;
            roomsTable.AllowUserToOrderColumns = true;
            roomsTable.AllowUserToResizeColumns = false;
            roomsTable.AllowUserToResizeRows = false;
            roomsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            roomsTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            roomsTable.BackgroundColor = SystemColors.Control;
            roomsTable.BorderStyle = BorderStyle.None;
            roomsTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            roomsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            roomsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roomsTable.Columns.AddRange(new DataGridViewColumn[] { id, roomTypeCol, roomNumberCol, allocatedCol, priceCol, patientIdCol, roomTheaterCol });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            roomsTable.DefaultCellStyle = dataGridViewCellStyle2;
            roomsTable.EnableHeadersVisualStyles = false;
            roomsTable.GridColor = SystemColors.Control;
            roomsTable.Location = new Point(65, 292);
            roomsTable.Name = "roomsTable";
            roomsTable.RowHeadersVisible = false;
            roomsTable.RowTemplate.Height = 25;
            roomsTable.ScrollBars = ScrollBars.Vertical;
            roomsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            roomsTable.Size = new Size(1193, 484);
            roomsTable.TabIndex = 0;
            // 
            // id
            // 
            id.DataPropertyName = "RoomID";
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 42;
            // 
            // roomTypeCol
            // 
            roomTypeCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            roomTypeCol.DataPropertyName = "RoomType";
            roomTypeCol.HeaderText = "Room Type";
            roomTypeCol.Name = "roomTypeCol";
            roomTypeCol.ReadOnly = true;
            // 
            // roomNumberCol
            // 
            roomNumberCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            roomNumberCol.DataPropertyName = "RoomNumber";
            roomNumberCol.HeaderText = "Room Number";
            roomNumberCol.Name = "roomNumberCol";
            roomNumberCol.ReadOnly = true;
            roomNumberCol.Width = 110;
            // 
            // allocatedCol
            // 
            allocatedCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            allocatedCol.DataPropertyName = "Allocated";
            allocatedCol.HeaderText = "Allocated";
            allocatedCol.Name = "allocatedCol";
            allocatedCol.ReadOnly = true;
            allocatedCol.Width = 81;
            // 
            // priceCol
            // 
            priceCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            priceCol.DataPropertyName = "PricePerDay";
            priceCol.HeaderText = "Price Per Day";
            priceCol.Name = "priceCol";
            priceCol.ReadOnly = true;
            // 
            // patientIdCol
            // 
            patientIdCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            patientIdCol.DataPropertyName = "PatientID";
            patientIdCol.HeaderText = "Patient ";
            patientIdCol.Name = "patientIdCol";
            patientIdCol.ReadOnly = true;
            // 
            // roomTheaterCol
            // 
            roomTheaterCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            roomTheaterCol.DataPropertyName = "Type";
            roomTheaterCol.HeaderText = "Room/Theater";
            roomTheaterCol.Name = "roomTheaterCol";
            roomTheaterCol.ReadOnly = true;
            roomTheaterCol.Width = 107;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(roomsTab);
            tabControl1.Controls.Add(theaterTab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(12, 5);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1325, 834);
            tabControl1.TabIndex = 0;
            // 
            // roomsTab
            // 
            roomsTab.BackgroundImage = (Image)resources.GetObject("roomsTab.BackgroundImage");
            roomsTab.Controls.Add(roomsTable);
            roomsTab.Controls.Add(DateLabel);
            roomsTab.Controls.Add(date);
            roomsTab.Controls.Add(isRoom);
            roomsTab.Controls.Add(thaterLable);
            roomsTab.Controls.Add(label1);
            roomsTab.Controls.Add(RoomClearBtn);
            roomsTab.Controls.Add(RoomDeleteBtn);
            roomsTab.Controls.Add(RoomUpdateBtn);
            roomsTab.Controls.Add(RoomSubmitBtn);
            roomsTab.Controls.Add(roomAllowcated);
            roomsTab.Controls.Add(priiceLabel);
            roomsTab.Controls.Add(roomPrice);
            roomsTab.Controls.Add(roomNumberLabel);
            roomsTab.Controls.Add(roomNumber);
            roomsTab.Controls.Add(roomType);
            roomsTab.Controls.Add(roomTypeLable);
            roomsTab.Location = new Point(4, 34);
            roomsTab.Name = "roomsTab";
            roomsTab.Padding = new Padding(3);
            roomsTab.Size = new Size(1317, 796);
            roomsTab.TabIndex = 0;
            roomsTab.Text = "Rooms";
            roomsTab.UseVisualStyleBackColor = true;
            roomsTab.Click += roomsTab_Click;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.BackColor = Color.Transparent;
            DateLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DateLabel.Location = new Point(379, 144);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(36, 17);
            DateLabel.TabIndex = 39;
            DateLabel.Text = "Date";
            // 
            // date
            // 
            date.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            date.Format = DateTimePickerFormat.Short;
            date.Location = new Point(379, 166);
            date.MinDate = new DateTime(2023, 8, 31, 0, 0, 0, 0);
            date.Name = "date";
            date.Size = new Size(285, 33);
            date.TabIndex = 38;
            // 
            // isRoom
            // 
            isRoom.AutoCompleteCustomSource.AddRange(new string[] { "General Ward Room", "Private Room", "Semi-Private Room", "Intensive Care Unit (ICU)", "Neonatal Intensive Care Unit (NICU)", "Pediatric Ward", "Maternity Room", "Operating Room (OR)", "Recovery Room", "Isolation Room" });
            isRoom.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            isRoom.FormattingEnabled = true;
            isRoom.Items.AddRange(new object[] { "Theater", "Room" });
            isRoom.Location = new Point(67, 166);
            isRoom.Name = "isRoom";
            isRoom.Size = new Size(286, 33);
            isRoom.TabIndex = 37;
            // 
            // thaterLable
            // 
            thaterLable.AutoSize = true;
            thaterLable.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            thaterLable.Location = new Point(67, 143);
            thaterLable.Name = "thaterLable";
            thaterLable.Size = new Size(109, 19);
            thaterLable.TabIndex = 36;
            thaterLable.Text = "Theater/ Room*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(65, 22);
            label1.Name = "label1";
            label1.Size = new Size(211, 36);
            label1.TabIndex = 35;
            label1.Text = "Rooms/ Theater";
            // 
            // RoomClearBtn
            // 
            RoomClearBtn.BackColor = Color.White;
            RoomClearBtn.BackgroundImageLayout = ImageLayout.None;
            RoomClearBtn.Cursor = Cursors.Hand;
            RoomClearBtn.FlatAppearance.BorderSize = 0;
            RoomClearBtn.FlatStyle = FlatStyle.Flat;
            RoomClearBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RoomClearBtn.ForeColor = SystemColors.Desktop;
            RoomClearBtn.Image = (Image)resources.GetObject("RoomClearBtn.Image");
            RoomClearBtn.ImageAlign = ContentAlignment.MiddleRight;
            RoomClearBtn.Location = new Point(764, 225);
            RoomClearBtn.Name = "RoomClearBtn";
            RoomClearBtn.Size = new Size(174, 37);
            RoomClearBtn.TabIndex = 34;
            RoomClearBtn.Text = "clear";
            RoomClearBtn.TextAlign = ContentAlignment.MiddleLeft;
            RoomClearBtn.UseVisualStyleBackColor = false;
            // 
            // RoomDeleteBtn
            // 
            RoomDeleteBtn.BackColor = Color.IndianRed;
            RoomDeleteBtn.BackgroundImageLayout = ImageLayout.None;
            RoomDeleteBtn.Cursor = Cursors.Hand;
            RoomDeleteBtn.FlatAppearance.BorderSize = 0;
            RoomDeleteBtn.FlatStyle = FlatStyle.Flat;
            RoomDeleteBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RoomDeleteBtn.ForeColor = SystemColors.ButtonHighlight;
            RoomDeleteBtn.Image = (Image)resources.GetObject("RoomDeleteBtn.Image");
            RoomDeleteBtn.ImageAlign = ContentAlignment.MiddleRight;
            RoomDeleteBtn.Location = new Point(478, 225);
            RoomDeleteBtn.Name = "RoomDeleteBtn";
            RoomDeleteBtn.Size = new Size(174, 37);
            RoomDeleteBtn.TabIndex = 33;
            RoomDeleteBtn.Text = "Delete";
            RoomDeleteBtn.TextAlign = ContentAlignment.MiddleLeft;
            RoomDeleteBtn.UseVisualStyleBackColor = false;
            // 
            // RoomUpdateBtn
            // 
            RoomUpdateBtn.BackColor = Color.Gold;
            RoomUpdateBtn.BackgroundImageLayout = ImageLayout.None;
            RoomUpdateBtn.Cursor = Cursors.Hand;
            RoomUpdateBtn.FlatAppearance.BorderSize = 0;
            RoomUpdateBtn.FlatStyle = FlatStyle.Flat;
            RoomUpdateBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RoomUpdateBtn.ForeColor = SystemColors.ActiveCaptionText;
            RoomUpdateBtn.Image = (Image)resources.GetObject("RoomUpdateBtn.Image");
            RoomUpdateBtn.ImageAlign = ContentAlignment.MiddleRight;
            RoomUpdateBtn.Location = new Point(272, 225);
            RoomUpdateBtn.Name = "RoomUpdateBtn";
            RoomUpdateBtn.Size = new Size(174, 37);
            RoomUpdateBtn.TabIndex = 32;
            RoomUpdateBtn.Text = "Update ";
            RoomUpdateBtn.TextAlign = ContentAlignment.MiddleLeft;
            RoomUpdateBtn.UseVisualStyleBackColor = false;
            // 
            // RoomSubmitBtn
            // 
            RoomSubmitBtn.BackColor = Color.MediumSeaGreen;
            RoomSubmitBtn.BackgroundImageLayout = ImageLayout.None;
            RoomSubmitBtn.Cursor = Cursors.Hand;
            RoomSubmitBtn.FlatAppearance.BorderSize = 0;
            RoomSubmitBtn.FlatStyle = FlatStyle.Flat;
            RoomSubmitBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RoomSubmitBtn.Image = (Image)resources.GetObject("RoomSubmitBtn.Image");
            RoomSubmitBtn.ImageAlign = ContentAlignment.MiddleRight;
            RoomSubmitBtn.Location = new Point(67, 225);
            RoomSubmitBtn.Name = "RoomSubmitBtn";
            RoomSubmitBtn.Size = new Size(174, 37);
            RoomSubmitBtn.TabIndex = 31;
            RoomSubmitBtn.Text = "Add Room";
            RoomSubmitBtn.TextAlign = ContentAlignment.MiddleLeft;
            RoomSubmitBtn.UseVisualStyleBackColor = false;
            RoomSubmitBtn.Click += RoomSubmitBtn_Click;
            // 
            // roomAllowcated
            // 
            roomAllowcated.AutoSize = true;
            roomAllowcated.Location = new Point(993, 100);
            roomAllowcated.Name = "roomAllowcated";
            roomAllowcated.Size = new Size(111, 25);
            roomAllowcated.TabIndex = 30;
            roomAllowcated.Text = "Allowcated";
            roomAllowcated.UseVisualStyleBackColor = true;
            // 
            // priiceLabel
            // 
            priiceLabel.AutoSize = true;
            priiceLabel.BackColor = Color.Transparent;
            priiceLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            priiceLabel.Location = new Point(685, 75);
            priiceLabel.Name = "priiceLabel";
            priiceLabel.Size = new Size(46, 19);
            priiceLabel.TabIndex = 29;
            priiceLabel.Text = "Price*";
            // 
            // roomPrice
            // 
            roomPrice.AutoCompleteCustomSource.AddRange(new string[] { "London", "Manchester", "Birmingham", "Edinburgh", "Glasgow", "Liverpool", "Leeds", "Bristol", "Sheffield", "Newcastle" });
            roomPrice.BorderStyle = BorderStyle.FixedSingle;
            roomPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            roomPrice.Location = new Point(685, 98);
            roomPrice.Name = "roomPrice";
            roomPrice.Size = new Size(286, 33);
            roomPrice.TabIndex = 28;
            // 
            // roomNumberLabel
            // 
            roomNumberLabel.AutoSize = true;
            roomNumberLabel.BackColor = Color.Transparent;
            roomNumberLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            roomNumberLabel.Location = new Point(379, 75);
            roomNumberLabel.Name = "roomNumberLabel";
            roomNumberLabel.Size = new Size(107, 19);
            roomNumberLabel.TabIndex = 27;
            roomNumberLabel.Text = "Room Number*";
            // 
            // roomNumber
            // 
            roomNumber.AutoCompleteCustomSource.AddRange(new string[] { "London", "Manchester", "Birmingham", "Edinburgh", "Glasgow", "Liverpool", "Leeds", "Bristol", "Sheffield", "Newcastle" });
            roomNumber.BorderStyle = BorderStyle.FixedSingle;
            roomNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            roomNumber.Location = new Point(379, 98);
            roomNumber.Name = "roomNumber";
            roomNumber.Size = new Size(286, 33);
            roomNumber.TabIndex = 26;
            // 
            // roomType
            // 
            roomType.AutoCompleteCustomSource.AddRange(new string[] { "General Ward Room", "Private Room", "Semi-Private Room", "Intensive Care Unit (ICU)", "Neonatal Intensive Care Unit (NICU)", "Pediatric Ward", "Maternity Room", "Operating Room (OR)", "Recovery Room", "Isolation Room" });
            roomType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            roomType.FormattingEnabled = true;
            roomType.Items.AddRange(new object[] { "London", "Manchester", "Birmingham", "Edinburgh", "Glasgow", "Liverpool", "Leeds", "Bristol", "Sheffield", "Newcastle" });
            roomType.Location = new Point(67, 98);
            roomType.Name = "roomType";
            roomType.Size = new Size(286, 33);
            roomType.TabIndex = 25;
            // 
            // roomTypeLable
            // 
            roomTypeLable.AutoSize = true;
            roomTypeLable.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            roomTypeLable.Location = new Point(67, 75);
            roomTypeLable.Name = "roomTypeLable";
            roomTypeLable.Size = new Size(83, 19);
            roomTypeLable.TabIndex = 24;
            roomTypeLable.Text = "Room type*";
            // 
            // theaterTab
            // 
            theaterTab.BackgroundImage = (Image)resources.GetObject("theaterTab.BackgroundImage");
            theaterTab.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            theaterTab.Location = new Point(4, 34);
            theaterTab.Name = "theaterTab";
            theaterTab.Padding = new Padding(3);
            theaterTab.Size = new Size(1317, 796);
            theaterTab.TabIndex = 1;
            theaterTab.Text = "Theater";
            theaterTab.UseVisualStyleBackColor = true;
            // 
            // RoomTheaterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1325, 834);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RoomTheaterForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rooms / Theater";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)roomsTable).EndInit();
            tabControl1.ResumeLayout(false);
            roomsTab.ResumeLayout(false);
            roomsTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage roomsTab;
        private TabPage theaterTab;
        private ComboBox roomType;
        private Label roomTypeLable;
        private CheckBox roomAllowcated;
        private Label priiceLabel;
        private TextBox roomPrice;
        private Label roomNumberLabel;
        private TextBox roomNumber;
        private Button RoomClearBtn;
        private Button RoomDeleteBtn;
        private Button RoomUpdateBtn;
        private Button RoomSubmitBtn;
        private Label label1;
        private ComboBox isRoom;
        private Label thaterLable;
        private Label DateLabel;
        private DateTimePicker date;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn roomTypeCol;
        private DataGridViewTextBoxColumn roomNumberCol;
        private DataGridViewTextBoxColumn allocatedCol;
        private DataGridViewTextBoxColumn priceCol;
        private DataGridViewTextBoxColumn patientIdCol;
        private DataGridViewTextBoxColumn roomTheaterCol;
        private DataGridView roomsTable;
    }
}