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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomTheaterForm));
            roomsTable = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            roomTypeCol = new DataGridViewTextBoxColumn();
            roomNumberCol = new DataGridViewTextBoxColumn();
            allocatedCol = new DataGridViewTextBoxColumn();
            priceCol = new DataGridViewTextBoxColumn();
            patientIdCol = new DataGridViewTextBoxColumn();
            roomTheaterCol = new DataGridViewTextBoxColumn();
            dateCol = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            roomsTab = new TabPage();
            isRoom = new ComboBox();
            thaterLable = new Label();
            label1 = new Label();
            RoomClearBtn = new Button();
            roomDeleteBtn = new Button();
            roomUpdateBtn = new Button();
            roomSubmitBtn = new Button();
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            roomsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            roomsTable.Columns.AddRange(new DataGridViewColumn[] { id, roomTypeCol, roomNumberCol, allocatedCol, priceCol, patientIdCol, roomTheaterCol, dateCol });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            roomsTable.DefaultCellStyle = dataGridViewCellStyle4;
            roomsTable.EnableHeadersVisualStyles = false;
            roomsTable.GridColor = SystemColors.Control;
            roomsTable.Location = new Point(65, 258);
            roomsTable.Name = "roomsTable";
            roomsTable.RowHeadersVisible = false;
            roomsTable.RowTemplate.Height = 25;
            roomsTable.ScrollBars = ScrollBars.Vertical;
            roomsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            roomsTable.Size = new Size(1193, 484);
            roomsTable.TabIndex = 0;
            roomsTable.CellFormatting += roomsTable_CellFormatting;
            roomsTable.SelectionChanged += roomsTable_SelectionChanged;
            // 
            // id
            // 
            id.DataPropertyName = "RoomID";
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 50;
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
            roomNumberCol.Width = 142;
            // 
            // allocatedCol
            // 
            allocatedCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            allocatedCol.DataPropertyName = "Allocated";
            allocatedCol.HeaderText = "Allocated";
            allocatedCol.Name = "allocatedCol";
            allocatedCol.ReadOnly = true;
            allocatedCol.Width = 104;
            // 
            // priceCol
            // 
            priceCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            priceCol.DataPropertyName = "PricePerDay";
            priceCol.HeaderText = "Price Per Day";
            priceCol.Name = "priceCol";
            priceCol.ReadOnly = true;
            priceCol.Width = 128;
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
            roomTheaterCol.Width = 141;
            // 
            // dateCol
            // 
            dateCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dateCol.DataPropertyName = "Date";
            dateCol.HeaderText = "Availabe after";
            dateCol.Name = "dateCol";
            dateCol.Width = 135;
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
            roomsTab.Controls.Add(isRoom);
            roomsTab.Controls.Add(thaterLable);
            roomsTab.Controls.Add(label1);
            roomsTab.Controls.Add(RoomClearBtn);
            roomsTab.Controls.Add(roomDeleteBtn);
            roomsTab.Controls.Add(roomUpdateBtn);
            roomsTab.Controls.Add(roomSubmitBtn);
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
            roomsTab.Text = "Rooms/Theater";
            roomsTab.UseVisualStyleBackColor = true;
            roomsTab.Click += roomsTab_Click;
            // 
            // isRoom
            // 
            isRoom.AutoCompleteCustomSource.AddRange(new string[] { "General Ward Room", "Private Room", "Semi-Private Room", "Intensive Care Unit (ICU)", "Neonatal Intensive Care Unit (NICU)", "Pediatric Ward", "Maternity Room", "Operating Room (OR)", "Recovery Room", "Isolation Room" });
            isRoom.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            isRoom.FormattingEnabled = true;
            isRoom.Items.AddRange(new object[] { "Theater", "Room" });
            isRoom.Location = new Point(972, 96);
            isRoom.Name = "isRoom";
            isRoom.Size = new Size(286, 33);
            isRoom.TabIndex = 37;
            isRoom.SelectedIndexChanged += isRoom_SelectedIndexChanged;
            // 
            // thaterLable
            // 
            thaterLable.AutoSize = true;
            thaterLable.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            thaterLable.Location = new Point(972, 73);
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
            RoomClearBtn.Location = new Point(764, 166);
            RoomClearBtn.Name = "RoomClearBtn";
            RoomClearBtn.Size = new Size(174, 37);
            RoomClearBtn.TabIndex = 34;
            RoomClearBtn.Text = "clear";
            RoomClearBtn.TextAlign = ContentAlignment.MiddleLeft;
            RoomClearBtn.UseVisualStyleBackColor = false;
            RoomClearBtn.Click += RoomClearBtn_Click;
            // 
            // roomDeleteBtn
            // 
            roomDeleteBtn.BackColor = Color.IndianRed;
            roomDeleteBtn.BackgroundImageLayout = ImageLayout.None;
            roomDeleteBtn.Cursor = Cursors.Hand;
            roomDeleteBtn.FlatAppearance.BorderSize = 0;
            roomDeleteBtn.FlatStyle = FlatStyle.Flat;
            roomDeleteBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            roomDeleteBtn.ForeColor = SystemColors.ButtonHighlight;
            roomDeleteBtn.Image = (Image)resources.GetObject("roomDeleteBtn.Image");
            roomDeleteBtn.ImageAlign = ContentAlignment.MiddleRight;
            roomDeleteBtn.Location = new Point(478, 166);
            roomDeleteBtn.Name = "roomDeleteBtn";
            roomDeleteBtn.Size = new Size(174, 37);
            roomDeleteBtn.TabIndex = 33;
            roomDeleteBtn.Text = "Delete";
            roomDeleteBtn.TextAlign = ContentAlignment.MiddleLeft;
            roomDeleteBtn.UseVisualStyleBackColor = false;
            // 
            // roomUpdateBtn
            // 
            roomUpdateBtn.BackColor = Color.Gold;
            roomUpdateBtn.BackgroundImageLayout = ImageLayout.None;
            roomUpdateBtn.Cursor = Cursors.Hand;
            roomUpdateBtn.FlatAppearance.BorderSize = 0;
            roomUpdateBtn.FlatStyle = FlatStyle.Flat;
            roomUpdateBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            roomUpdateBtn.ForeColor = SystemColors.ActiveCaptionText;
            roomUpdateBtn.Image = (Image)resources.GetObject("roomUpdateBtn.Image");
            roomUpdateBtn.ImageAlign = ContentAlignment.MiddleRight;
            roomUpdateBtn.Location = new Point(272, 166);
            roomUpdateBtn.Name = "roomUpdateBtn";
            roomUpdateBtn.Size = new Size(174, 37);
            roomUpdateBtn.TabIndex = 32;
            roomUpdateBtn.Text = "Update ";
            roomUpdateBtn.TextAlign = ContentAlignment.MiddleLeft;
            roomUpdateBtn.UseVisualStyleBackColor = false;
            // 
            // roomSubmitBtn
            // 
            roomSubmitBtn.BackColor = Color.MediumSeaGreen;
            roomSubmitBtn.BackgroundImageLayout = ImageLayout.None;
            roomSubmitBtn.Cursor = Cursors.Hand;
            roomSubmitBtn.FlatAppearance.BorderSize = 0;
            roomSubmitBtn.FlatStyle = FlatStyle.Flat;
            roomSubmitBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            roomSubmitBtn.Image = (Image)resources.GetObject("roomSubmitBtn.Image");
            roomSubmitBtn.ImageAlign = ContentAlignment.MiddleRight;
            roomSubmitBtn.Location = new Point(67, 166);
            roomSubmitBtn.Name = "roomSubmitBtn";
            roomSubmitBtn.Size = new Size(174, 37);
            roomSubmitBtn.TabIndex = 31;
            roomSubmitBtn.Text = "Add Room";
            roomSubmitBtn.TextAlign = ContentAlignment.MiddleLeft;
            roomSubmitBtn.UseVisualStyleBackColor = false;
            roomSubmitBtn.Click += RoomSubmitBtn_Click;
            // 
            // priiceLabel
            // 
            priiceLabel.AutoSize = true;
            priiceLabel.BackColor = Color.Transparent;
            priiceLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            priiceLabel.Location = new Point(670, 75);
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
            roomPrice.Location = new Point(670, 98);
            roomPrice.Name = "roomPrice";
            roomPrice.Size = new Size(286, 33);
            roomPrice.TabIndex = 28;
            roomPrice.TextChanged += roomPrice_TextChanged;
            // 
            // roomNumberLabel
            // 
            roomNumberLabel.AutoSize = true;
            roomNumberLabel.BackColor = Color.Transparent;
            roomNumberLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            roomNumberLabel.Location = new Point(370, 75);
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
            roomNumber.Location = new Point(370, 98);
            roomNumber.Name = "roomNumber";
            roomNumber.Size = new Size(286, 33);
            roomNumber.TabIndex = 26;
            roomNumber.TextChanged += roomNumber_TextChanged;
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
            roomType.SelectedIndexChanged += roomType_SelectedIndexChanged;
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
            Text = "Rooms ";
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
        private Label priiceLabel;
        private TextBox roomPrice;
        private Label roomNumberLabel;
        private TextBox roomNumber;
        private Button RoomClearBtn;
        private Button roomDeleteBtn;
        private Button roomUpdateBtn;
        private Button roomSubmitBtn;
        private Label label1;
        private ComboBox isRoom;
        private Label thaterLable;
        private DataGridView roomsTable;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn roomTypeCol;
        private DataGridViewTextBoxColumn roomNumberCol;
        private DataGridViewTextBoxColumn allocatedCol;
        private DataGridViewTextBoxColumn priceCol;
        private DataGridViewTextBoxColumn patientIdCol;
        private DataGridViewTextBoxColumn roomTheaterCol;
        private DataGridViewTextBoxColumn dateCol;
    }
}