namespace HealthCarePlus
{
    partial class Login
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
            Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            emailLabel = new Label();
            email = new TextBox();
            passwordLabel = new Label();
            password = new TextBox();
            LoginBtn = new Button();
            label1 = new Label();
            navigateRegister = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            emailLabel.ForeColor = Color.White;
            emailLabel.Location = new Point(66, 114);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(59, 25);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email";
            emailLabel.Click += emailLabel_Click;
            // 
            // email
            // 
            email.BorderStyle = BorderStyle.FixedSingle;
            email.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(71, 145);
            email.Margin = new Padding(6);
            email.MinimumSize = new Size(30, 30);
            email.Name = "email";
            email.Size = new Size(321, 31);
            email.TabIndex = 6;
            email.TextChanged += email_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(66, 217);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(97, 25);
            passwordLabel.TabIndex = 11;
            passwordLabel.Text = "Password";
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.FixedSingle;
            password.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            password.HideSelection = false;
            password.Location = new Point(71, 248);
            password.Margin = new Padding(6);
            password.MinimumSize = new Size(30, 30);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(321, 31);
            password.TabIndex = 10;
            password.UseSystemPasswordChar = true;
            password.TextChanged += password_TextChanged;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.DodgerBlue;
            LoginBtn.BackgroundImageLayout = ImageLayout.None;
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.FlatAppearance.BorderSize = 0;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(71, 330);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(321, 42);
            LoginBtn.TabIndex = 12;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(71, 422);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 13;
            label1.Text = "Don't have an account ?";
            // 
            // navigateRegister
            // 
            navigateRegister.BackColor = Color.Teal;
            navigateRegister.FlatAppearance.BorderSize = 0;
            navigateRegister.FlatStyle = FlatStyle.Flat;
            navigateRegister.ForeColor = Color.White;
            navigateRegister.Location = new Point(211, 418);
            navigateRegister.Name = "navigateRegister";
            navigateRegister.Size = new Size(75, 23);
            navigateRegister.TabIndex = 14;
            navigateRegister.Text = "Register";
            navigateRegister.UseVisualStyleBackColor = false;
            navigateRegister.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(714, 47);
            label2.Name = "label2";
            label2.Size = new Size(446, 78);
            label2.TabIndex = 15;
            label2.Text = "Healthcare Plus";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Location = new Point(1153, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 56);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1325, 834);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(navigateRegister);
            Controls.Add(label1);
            Controls.Add(LoginBtn);
            Controls.Add(passwordLabel);
            Controls.Add(password);
            Controls.Add(emailLabel);
            Controls.Add(email);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label emailLabel;
        private TextBox email;
        private Label passwordLabel;
        private TextBox password;
        private Button LoginBtn;
        private Label label1;
        private Button navigateRegister;
        private Label label2;
        private PictureBox pictureBox1;
    }
}