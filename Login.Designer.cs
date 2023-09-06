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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            emailLabel = new Label();
            email = new TextBox();
            passwordLabel = new Label();
            password = new TextBox();
            LoginBtn = new Button();
            label1 = new Label();
            navigateRegister = new Button();
            SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(441, 233);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email";
            // 
            // email
            // 
            email.BorderStyle = BorderStyle.FixedSingle;
            email.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(441, 251);
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
            passwordLabel.Location = new Point(441, 321);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 11;
            passwordLabel.Text = "Password";
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.FixedSingle;
            password.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            password.HideSelection = false;
            password.Location = new Point(441, 339);
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
            LoginBtn.BackgroundImageLayout = ImageLayout.None;
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.FlatAppearance.BorderSize = 2;
            LoginBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.Location = new Point(441, 431);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(321, 42);
            LoginBtn.TabIndex = 12;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(441, 515);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 13;
            label1.Text = "Don't have an account ?";
            // 
            // navigateRegister
            // 
            navigateRegister.BackColor = Color.Transparent;
            navigateRegister.ForeColor = Color.Black;
            navigateRegister.Location = new Point(581, 511);
            navigateRegister.Name = "navigateRegister";
            navigateRegister.Size = new Size(75, 23);
            navigateRegister.TabIndex = 14;
            navigateRegister.Text = "Register";
            navigateRegister.UseVisualStyleBackColor = false;
            navigateRegister.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1325, 834);
            Controls.Add(navigateRegister);
            Controls.Add(label1);
            Controls.Add(LoginBtn);
            Controls.Add(passwordLabel);
            Controls.Add(password);
            Controls.Add(emailLabel);
            Controls.Add(email);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
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
    }
}