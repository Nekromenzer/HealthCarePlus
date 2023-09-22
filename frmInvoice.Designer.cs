namespace HealthCarePlus
{
    partial class frmInvoice
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
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            txtPid = new TextBox();
            btnSearch = new Button();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox6 = new TextBox();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            button6 = new Button();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            dataGridView2 = new DataGridView();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // txtPid
            // 
            txtPid.BorderStyle = BorderStyle.None;
            txtPid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPid.Location = new Point(37, 46);
            txtPid.Margin = new Padding(4);
            txtPid.Name = "txtPid";
            txtPid.PlaceholderText = "Enter Patient ID";
            txtPid.Size = new Size(431, 22);
            txtPid.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(915, 40);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(96, 32);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(476, 110);
            textBox5.Margin = new Padding(4);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "NIC";
            textBox5.Size = new Size(431, 22);
            textBox5.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(37, 148);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(142, 32);
            button1.TabIndex = 7;
            button1.Text = "Apoinments";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(187, 148);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(142, 32);
            button2.TabIndex = 8;
            button2.Text = "Medications";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(337, 148);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(142, 32);
            button3.TabIndex = 9;
            button3.Text = "Rooms";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(487, 148);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(142, 32);
            button4.TabIndex = 10;
            button4.Text = "Procedures";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(476, 46);
            textBox6.Margin = new Padding(4);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Date";
            textBox6.Size = new Size(431, 22);
            textBox6.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1624, 249);
            dataGridView1.TabIndex = 12;
            // 
            // button5
            // 
            button5.Location = new Point(1100, 472);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(142, 32);
            button5.TabIndex = 13;
            button5.Text = "Confirm";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(1019, 40);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(96, 32);
            button6.TabIndex = 14;
            button6.Text = "Add";
            button6.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(37, 482);
            textBox7.Margin = new Padding(4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(343, 22);
            textBox7.TabIndex = 15;
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(388, 482);
            textBox8.Margin = new Padding(4);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(343, 22);
            textBox8.TabIndex = 16;
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(739, 482);
            textBox9.Margin = new Padding(4);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(343, 22);
            textBox9.TabIndex = 17;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(37, 537);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(1624, 249);
            dataGridView2.TabIndex = 18;
            // 
            // button7
            // 
            button7.Location = new Point(37, 808);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.RightToLeft = RightToLeft.No;
            button7.Size = new Size(142, 32);
            button7.TabIndex = 19;
            button7.Text = "Generate Bill";
            button7.UseVisualStyleBackColor = true;
            // 
            // frmInvoice
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1704, 1061);
            Controls.Add(button7);
            Controls.Add(dataGridView2);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(textBox6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(btnSearch);
            Controls.Add(txtPid);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private TextBox txtPid;
        private Button btnSearch;
        private TextBox txtPname;
        private TextBox txtdate;
        private TextBox txtDob;
        private TextBox txt;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox6;
        private DataGridView dataGridView1;
        private Button button5;
        private Button button6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private DataGridView dataGridView2;
        private Button button7;
    }
}