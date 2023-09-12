namespace HealthCarePlus
{
    partial class Register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            Label label3;
            registerBtn = new Button();
            fullName = new TextBox();
            label1 = new Label();
            fullNameLabel = new Label();
            emailLabel = new Label();
            email = new TextBox();
            positionLabel = new Label();
            passwordLabel = new Label();
            password = new TextBox();
            confirmPasswordLabel = new Label();
            confirmPassword = new TextBox();
            navigateLogin = new Button();
            label2 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            position = new ComboBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.DodgerBlue;
            registerBtn.BackgroundImageLayout = ImageLayout.None;
            registerBtn.Cursor = Cursors.Hand;
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            registerBtn.ForeColor = Color.White;
            registerBtn.Location = new Point(37, 489);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(321, 42);
            registerBtn.TabIndex = 0;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += button1_Click;
            // 
            // fullName
            // 
            fullName.BorderStyle = BorderStyle.FixedSingle;
            fullName.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            fullName.Location = new Point(37, 67);
            fullName.Margin = new Padding(6);
            fullName.MinimumSize = new Size(30, 30);
            fullName.Name = "fullName";
            fullName.Size = new Size(321, 31);
            fullName.TabIndex = 1;
            fullName.TextChanged += fullName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 47);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.BackColor = Color.Transparent;
            fullNameLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            fullNameLabel.Location = new Point(36, 39);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(100, 25);
            fullNameLabel.TabIndex = 3;
            fullNameLabel.Text = "Full Name";
            fullNameLabel.Click += label2_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            emailLabel.Location = new Point(37, 124);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(59, 25);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email";
            emailLabel.Click += label3_Click;
            // 
            // email
            // 
            email.BackColor = SystemColors.Window;
            email.BorderStyle = BorderStyle.FixedSingle;
            email.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(35, 151);
            email.Margin = new Padding(6);
            email.MinimumSize = new Size(30, 30);
            email.Name = "email";
            email.Size = new Size(321, 31);
            email.TabIndex = 4;
            email.TextChanged += textBox1_TextChanged;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.BackColor = Color.Transparent;
            positionLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            positionLabel.Location = new Point(38, 211);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(80, 25);
            positionLabel.TabIndex = 7;
            positionLabel.Text = "Position";
            positionLabel.Click += label2_Click_1;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(37, 302);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(91, 25);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Password";
            passwordLabel.Click += label2_Click_2;
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.FixedSingle;
            password.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(37, 329);
            password.Margin = new Padding(6);
            password.MinimumSize = new Size(30, 30);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(321, 31);
            password.TabIndex = 8;
            password.TextChanged += password_TextChanged;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.BackColor = Color.Transparent;
            confirmPasswordLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            confirmPasswordLabel.Location = new Point(37, 391);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(166, 25);
            confirmPasswordLabel.TabIndex = 11;
            confirmPasswordLabel.Text = "Confirm Password";
            // 
            // confirmPassword
            // 
            confirmPassword.BorderStyle = BorderStyle.FixedSingle;
            confirmPassword.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPassword.Location = new Point(37, 418);
            confirmPassword.Margin = new Padding(6);
            confirmPassword.MinimumSize = new Size(30, 30);
            confirmPassword.Name = "confirmPassword";
            confirmPassword.PasswordChar = '*';
            confirmPassword.Size = new Size(321, 31);
            confirmPassword.TabIndex = 10;
            confirmPassword.TextChanged += confirmPassword_TextChanged;
            // 
            // navigateLogin
            // 
            navigateLogin.BackColor = Color.Yellow;
            navigateLogin.FlatAppearance.BorderSize = 0;
            navigateLogin.FlatStyle = FlatStyle.Flat;
            navigateLogin.ForeColor = Color.Black;
            navigateLogin.Location = new Point(193, 558);
            navigateLogin.Name = "navigateLogin";
            navigateLogin.Size = new Size(75, 23);
            navigateLogin.TabIndex = 16;
            navigateLogin.Text = "Login";
            navigateLogin.UseVisualStyleBackColor = false;
            navigateLogin.Click += navigateLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(42, 562);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 15;
            label2.Text = "Don't have an account ?";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // position
            // 
            position.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            position.FormattingEnabled = true;
            position.Items.AddRange(new object[] { "Doctor", "Nurse", "Other" });
            position.Location = new Point(37, 237);
            position.Name = "position";
            position.Size = new Size(319, 31);
            position.TabIndex = 17;
            position.SelectedIndexChanged += position_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Location = new Point(1166, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 56);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(714, 47);
            label3.Name = "label3";
            label3.Size = new Size(446, 78);
            label3.TabIndex = 18;
            label3.Text = "Healthcare Plus";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1325, 834);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(position);
            Controls.Add(navigateLogin);
            Controls.Add(label2);
            Controls.Add(confirmPasswordLabel);
            Controls.Add(confirmPassword);
            Controls.Add(passwordLabel);
            Controls.Add(password);
            Controls.Add(positionLabel);
            Controls.Add(emailLabel);
            Controls.Add(email);
            Controls.Add(fullNameLabel);
            Controls.Add(label1);
            Controls.Add(fullName);
            Controls.Add(registerBtn);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerBtn;
        private TextBox fullName;
        private Label label1;
        private Label fullNameLabel;
        private Label emailLabel;
        private TextBox email;
        private Label positionLabel;
        private Label passwordLabel;
        private TextBox password;
        private Label confirmPasswordLabel;
        private TextBox confirmPassword;
        private Button navigateLogin;
        private Label label2;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private ComboBox position;
        private PictureBox pictureBox1;
    }
}