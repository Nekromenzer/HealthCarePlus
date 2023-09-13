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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomTheaterForm));
            tabControl1 = new TabControl();
            roomsTab = new TabPage();
            roomType = new ComboBox();
            roomTypeLable = new Label();
            theaterTab = new TabPage();
            roomNumberLabel = new Label();
            roomNumber = new TextBox();
            priiceLabel = new Label();
            roomPrice = new TextBox();
            roomAllowcated = new CheckBox();
            tabControl1.SuspendLayout();
            roomsTab.SuspendLayout();
            SuspendLayout();
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
            // roomType
            // 
            roomType.AutoCompleteCustomSource.AddRange(new string[] { "General Ward Room", "Private Room", "Semi-Private Room", "Intensive Care Unit (ICU)", "Neonatal Intensive Care Unit (NICU)", "Pediatric Ward", "Maternity Room", "Operating Room (OR)", "Recovery Room", "Isolation Room" });
            roomType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            roomType.FormattingEnabled = true;
            roomType.Items.AddRange(new object[] { "London", "Manchester", "Birmingham", "Edinburgh", "Glasgow", "Liverpool", "Leeds", "Bristol", "Sheffield", "Newcastle" });
            roomType.Location = new Point(39, 140);
            roomType.Name = "roomType";
            roomType.Size = new Size(279, 33);
            roomType.TabIndex = 25;
            // 
            // roomTypeLable
            // 
            roomTypeLable.AutoSize = true;
            roomTypeLable.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            roomTypeLable.Location = new Point(39, 117);
            roomTypeLable.Name = "roomTypeLable";
            roomTypeLable.Size = new Size(77, 19);
            roomTypeLable.TabIndex = 24;
            roomTypeLable.Text = "Room type";
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
            // roomNumberLabel
            // 
            roomNumberLabel.AutoSize = true;
            roomNumberLabel.BackColor = Color.Transparent;
            roomNumberLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            roomNumberLabel.Location = new Point(351, 117);
            roomNumberLabel.Name = "roomNumberLabel";
            roomNumberLabel.Size = new Size(101, 19);
            roomNumberLabel.TabIndex = 27;
            roomNumberLabel.Text = "Room Number";
            // 
            // roomNumber
            // 
            roomNumber.AutoCompleteCustomSource.AddRange(new string[] { "London", "Manchester", "Birmingham", "Edinburgh", "Glasgow", "Liverpool", "Leeds", "Bristol", "Sheffield", "Newcastle" });
            roomNumber.BorderStyle = BorderStyle.FixedSingle;
            roomNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            roomNumber.Location = new Point(351, 140);
            roomNumber.Name = "roomNumber";
            roomNumber.Size = new Size(279, 33);
            roomNumber.TabIndex = 26;
            // 
            // priiceLabel
            // 
            priiceLabel.AutoSize = true;
            priiceLabel.BackColor = Color.Transparent;
            priiceLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            priiceLabel.Location = new Point(657, 117);
            priiceLabel.Name = "priiceLabel";
            priiceLabel.Size = new Size(40, 19);
            priiceLabel.TabIndex = 29;
            priiceLabel.Text = "Price";
            // 
            // roomPrice
            // 
            roomPrice.AutoCompleteCustomSource.AddRange(new string[] { "London", "Manchester", "Birmingham", "Edinburgh", "Glasgow", "Liverpool", "Leeds", "Bristol", "Sheffield", "Newcastle" });
            roomPrice.BorderStyle = BorderStyle.FixedSingle;
            roomPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            roomPrice.Location = new Point(657, 140);
            roomPrice.Name = "roomPrice";
            roomPrice.Size = new Size(279, 33);
            roomPrice.TabIndex = 28;
            // 
            // roomAllowcated
            // 
            roomAllowcated.AutoSize = true;
            roomAllowcated.Location = new Point(965, 142);
            roomAllowcated.Name = "roomAllowcated";
            roomAllowcated.Size = new Size(111, 25);
            roomAllowcated.TabIndex = 30;
            roomAllowcated.Text = "Allowcated";
            roomAllowcated.UseVisualStyleBackColor = true;
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
    }
}