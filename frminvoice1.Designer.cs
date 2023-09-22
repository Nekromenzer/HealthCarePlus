namespace HealthCarePlus
{
    partial class frminvoice1
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
            txtpid = new TextBox();
            txtPname = new TextBox();
            btnSearch = new Button();
            txtDOB = new TextBox();
            txtGender = new TextBox();
            txtPno = new TextBox();
            txtAddress = new TextBox();
            txtNic = new TextBox();
            btnAppoinment = new Button();
            dataGridView1 = new DataGridView();
            dtp1 = new DateTimePicker();
            btnAddtoDb = new Button();
            dataGridView2 = new DataGridView();
            btnInvoice = new Button();
            btnRooms = new Button();
            btnMedi = new Button();
            btmProce = new Button();
            btnConsultation = new Button();
            lblTot = new Label();
            lbl2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // txtpid
            // 
            txtpid.Location = new Point(145, 85);
            txtpid.Name = "txtpid";
            txtpid.Size = new Size(327, 23);
            txtpid.TabIndex = 0;
            // 
            // txtPname
            // 
            txtPname.Location = new Point(145, 114);
            txtPname.Name = "txtPname";
            txtPname.Size = new Size(327, 23);
            txtPname.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.Location = new Point(478, 85);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(153, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(478, 114);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(327, 23);
            txtDOB.TabIndex = 3;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(811, 114);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(327, 23);
            txtGender.TabIndex = 4;
            // 
            // txtPno
            // 
            txtPno.Location = new Point(144, 143);
            txtPno.Name = "txtPno";
            txtPno.Size = new Size(328, 23);
            txtPno.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(478, 143);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(327, 23);
            txtAddress.TabIndex = 6;
            // 
            // txtNic
            // 
            txtNic.Location = new Point(811, 143);
            txtNic.Name = "txtNic";
            txtNic.Size = new Size(327, 23);
            txtNic.TabIndex = 7;
            // 
            // btnAppoinment
            // 
            btnAppoinment.Location = new Point(478, 183);
            btnAppoinment.Name = "btnAppoinment";
            btnAppoinment.Size = new Size(153, 23);
            btnAppoinment.TabIndex = 8;
            btnAppoinment.Text = "Appoinments";
            btnAppoinment.UseVisualStyleBackColor = true;
            btnAppoinment.Click += btnAppoinment_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(144, 221);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(994, 228);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dtp1
            // 
            dtp1.CustomFormat = "";
            dtp1.Format = DateTimePickerFormat.Short;
            dtp1.Location = new Point(144, 183);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(327, 23);
            dtp1.TabIndex = 10;
            // 
            // btnAddtoDb
            // 
            btnAddtoDb.Location = new Point(144, 464);
            btnAddtoDb.Name = "btnAddtoDb";
            btnAddtoDb.Size = new Size(147, 23);
            btnAddtoDb.TabIndex = 11;
            btnAddtoDb.Text = "Add to Invoice";
            btnAddtoDb.UseVisualStyleBackColor = true;
            btnAddtoDb.Click += btnAddtoDb_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(145, 502);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(993, 229);
            dataGridView2.TabIndex = 12;
            // 
            // btnInvoice
            // 
            btnInvoice.Location = new Point(145, 747);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(147, 23);
            btnInvoice.TabIndex = 13;
            btnInvoice.Text = "Load Invoice";
            btnInvoice.UseVisualStyleBackColor = true;
            // 
            // btnRooms
            // 
            btnRooms.Location = new Point(1114, 183);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(153, 23);
            btnRooms.TabIndex = 14;
            btnRooms.Text = "Rooms/Theater";
            btnRooms.UseVisualStyleBackColor = true;
            // 
            // btnMedi
            // 
            btnMedi.Location = new Point(637, 183);
            btnMedi.Name = "btnMedi";
            btnMedi.Size = new Size(153, 23);
            btnMedi.TabIndex = 15;
            btnMedi.Text = "Medication";
            btnMedi.UseVisualStyleBackColor = true;
            btnMedi.Click += btnMedi_Click;
            // 
            // btmProce
            // 
            btmProce.Location = new Point(955, 183);
            btmProce.Name = "btmProce";
            btmProce.Size = new Size(153, 23);
            btmProce.TabIndex = 16;
            btmProce.Text = "Procedures";
            btmProce.UseVisualStyleBackColor = true;
            // 
            // btnConsultation
            // 
            btnConsultation.Location = new Point(796, 183);
            btnConsultation.Name = "btnConsultation";
            btnConsultation.Size = new Size(153, 23);
            btnConsultation.TabIndex = 17;
            btnConsultation.Text = "Consultation";
            btnConsultation.UseVisualStyleBackColor = true;
            btnConsultation.Click += btnConsultation_Click;
            // 
            // lblTot
            // 
            lblTot.AutoSize = true;
            lblTot.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTot.Location = new Point(930, 747);
            lblTot.Name = "lblTot";
            lblTot.Size = new Size(73, 28);
            lblTot.TabIndex = 18;
            lblTot.Text = "Total -";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.Location = new Point(1009, 747);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(70, 28);
            lbl2.TabIndex = 19;
            lbl2.Text = "label1";
            // 
            // frminvoice1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1325, 834);
            Controls.Add(lbl2);
            Controls.Add(lblTot);
            Controls.Add(btnConsultation);
            Controls.Add(btmProce);
            Controls.Add(btnMedi);
            Controls.Add(btnRooms);
            Controls.Add(btnInvoice);
            Controls.Add(dataGridView2);
            Controls.Add(btnAddtoDb);
            Controls.Add(dtp1);
            Controls.Add(dataGridView1);
            Controls.Add(btnAppoinment);
            Controls.Add(txtNic);
            Controls.Add(txtAddress);
            Controls.Add(txtPno);
            Controls.Add(txtGender);
            Controls.Add(txtDOB);
            Controls.Add(btnSearch);
            Controls.Add(txtPname);
            Controls.Add(txtpid);
            Name = "frminvoice1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frminvoice1";
            Load += frminvoice1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtpid;
        private TextBox txtPname;
        private Button btnSearch;
        private TextBox txtDOB;
        private TextBox txtGender;
        private TextBox txtPno;
        private TextBox txtAddress;
        private TextBox txtNic;
        private Button btnAppoinment;
        private DataGridView dataGridView1;
        private DateTimePicker dtp1;
        private Button btnAddtoDb;
        private DataGridView dataGridView2;
        private Button btnInvoice;
        private Button btnRooms;
        private Button btnMedi;
        private Button btmProce;
        private Button btnConsultation;
        private Label lblTot;
        private Label lbl2;
    }
}