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
            theaterTab = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(roomsTab);
            tabControl1.Controls.Add(theaterTab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1325, 834);
            tabControl1.TabIndex = 0;
            // 
            // roomsTab
            // 
            roomsTab.Location = new Point(4, 24);
            roomsTab.Name = "roomsTab";
            roomsTab.Padding = new Padding(3);
            roomsTab.Size = new Size(1317, 806);
            roomsTab.TabIndex = 0;
            roomsTab.Text = "Rooms";
            roomsTab.UseVisualStyleBackColor = true;
            // 
            // theaterTab
            // 
            theaterTab.Location = new Point(4, 24);
            theaterTab.Name = "theaterTab";
            theaterTab.Padding = new Padding(3);
            theaterTab.Size = new Size(1317, 806);
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
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage roomsTab;
        private TabPage theaterTab;
    }
}