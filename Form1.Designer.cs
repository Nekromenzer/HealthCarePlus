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
            registerBtn = new Button();
            fullName = new TextBox();
            label1 = new Label();
            fullNameLabel = new Label();
            emailLabel = new Label();
            email = new TextBox();
            positionLabel = new Label();
            position = new TextBox();
            passwordLabel = new Label();
            password = new TextBox();
            confirmPasswordLabel = new Label();
            confirmPassword = new TextBox();
            navigateLogin = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // registerBtn
            // 
            registerBtn.BackgroundImageLayout = ImageLayout.None;
            registerBtn.Cursor = Cursors.Hand;
            registerBtn.FlatAppearance.BorderSize = 2;
            registerBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            registerBtn.Location = new Point(37, 434);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(321, 42);
            registerBtn.TabIndex = 0;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
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
            fullNameLabel.Location = new Point(37, 49);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(61, 15);
            fullNameLabel.TabIndex = 3;
            fullNameLabel.Text = "Full Name";
            fullNameLabel.Click += label2_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(37, 115);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email";
            emailLabel.Click += label3_Click;
            // 
            // email
            // 
            email.BorderStyle = BorderStyle.FixedSingle;
            email.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(37, 133);
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
            positionLabel.Location = new Point(37, 192);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(50, 15);
            positionLabel.TabIndex = 7;
            positionLabel.Text = "Position";
            positionLabel.Click += label2_Click_1;
            // 
            // position
            // 
            position.BorderStyle = BorderStyle.FixedSingle;
            position.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            position.Location = new Point(37, 210);
            position.Margin = new Padding(6);
            position.MinimumSize = new Size(30, 30);
            position.Name = "position";
            position.Size = new Size(321, 31);
            position.TabIndex = 6;
            position.TextChanged += position_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(37, 269);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Password";
            passwordLabel.Click += label2_Click_2;
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.FixedSingle;
            password.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(37, 287);
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
            confirmPasswordLabel.Location = new Point(37, 345);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(103, 15);
            confirmPasswordLabel.TabIndex = 11;
            confirmPasswordLabel.Text = "Confirm Password";
            // 
            // confirmPassword
            // 
            confirmPassword.BorderStyle = BorderStyle.FixedSingle;
            confirmPassword.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPassword.Location = new Point(37, 363);
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
            navigateLogin.BackColor = Color.Transparent;
            navigateLogin.ForeColor = Color.Black;
            navigateLogin.Location = new Point(193, 503);
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
            label2.BackColor = SystemColors.ButtonFace;
            label2.Location = new Point(42, 507);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 15;
            label2.Text = "Don't have an account ?";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(976, 588);
            Controls.Add(navigateLogin);
            Controls.Add(label2);
            Controls.Add(confirmPasswordLabel);
            Controls.Add(confirmPassword);
            Controls.Add(passwordLabel);
            Controls.Add(password);
            Controls.Add(positionLabel);
            Controls.Add(position);
            Controls.Add(emailLabel);
            Controls.Add(email);
            Controls.Add(fullNameLabel);
            Controls.Add(label1);
            Controls.Add(fullName);
            Controls.Add(registerBtn);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Register";
            Text = "Register";
            Load += Form1_Load;
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
        private TextBox position;
        private Label passwordLabel;
        private TextBox password;
        private Label confirmPasswordLabel;
        private TextBox confirmPassword;
        private Button navigateLogin;
        private Label label2;
    }
}