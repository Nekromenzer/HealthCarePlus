namespace HealthCarePlus
{
    partial class PatientHsitory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientHsitory));
            tabControl1 = new TabControl();
            labTab = new TabPage();
            diagnosesTab = new TabPage();
            perscriptionTab = new TabPage();
            patient = new ComboBox();
            clearBtn = new Button();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(labTab);
            tabControl1.Controls.Add(diagnosesTab);
            tabControl1.Controls.Add(perscriptionTab);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 134);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1325, 700);
            tabControl1.TabIndex = 0;
            // 
            // labTab
            // 
            labTab.Location = new Point(4, 24);
            labTab.Name = "labTab";
            labTab.Padding = new Padding(3);
            labTab.Size = new Size(1317, 672);
            labTab.TabIndex = 0;
            labTab.Text = "Lab results";
            labTab.UseVisualStyleBackColor = true;
            labTab.Click += tabPage1_Click;
            // 
            // diagnosesTab
            // 
            diagnosesTab.Location = new Point(4, 24);
            diagnosesTab.Name = "diagnosesTab";
            diagnosesTab.Padding = new Padding(3);
            diagnosesTab.Size = new Size(192, 72);
            diagnosesTab.TabIndex = 1;
            diagnosesTab.Text = "Diagnoses";
            diagnosesTab.UseVisualStyleBackColor = true;
            // 
            // perscriptionTab
            // 
            perscriptionTab.Location = new Point(4, 24);
            perscriptionTab.Name = "perscriptionTab";
            perscriptionTab.Size = new Size(192, 72);
            perscriptionTab.TabIndex = 2;
            perscriptionTab.Text = "Perscription";
            perscriptionTab.UseVisualStyleBackColor = true;
            // 
            // patient
            // 
            patient.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            patient.FormattingEnabled = true;
            patient.Location = new Point(394, 67);
            patient.Name = "patient";
            patient.Size = new Size(272, 33);
            patient.TabIndex = 1;
            patient.Text = "Select Patient";
            patient.SelectedIndexChanged += patient_SelectedIndexChanged;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.PeachPuff;
            clearBtn.BackgroundImageLayout = ImageLayout.None;
            clearBtn.Cursor = Cursors.Hand;
            clearBtn.FlatAppearance.BorderSize = 0;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clearBtn.ForeColor = SystemColors.Desktop;
            clearBtn.Image = (Image)resources.GetObject("clearBtn.Image");
            clearBtn.ImageAlign = ContentAlignment.MiddleRight;
            clearBtn.Location = new Point(691, 65);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(228, 37);
            clearBtn.TabIndex = 39;
            clearBtn.Text = "clear patient selection";
            clearBtn.TextAlign = ContentAlignment.MiddleLeft;
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // PatientHsitory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 834);
            Controls.Add(clearBtn);
            Controls.Add(patient);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PatientHsitory";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient History  Mangement";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage labTab;
        private TabPage diagnosesTab;
        private TabPage perscriptionTab;
        private ComboBox patient;
        private Button clearBtn;
    }
}