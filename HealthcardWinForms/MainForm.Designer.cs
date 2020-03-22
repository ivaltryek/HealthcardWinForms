namespace HealthcardWinForms
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.LogInLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 747);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1304, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 747);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.registerButton);
            this.panel3.Controls.Add(this.loginButton);
            this.panel3.Controls.Add(this.passwordTextBox);
            this.panel3.Controls.Add(this.passwordLabel);
            this.panel3.Controls.Add(this.emailTextBox);
            this.panel3.Controls.Add(this.emailLabel);
            this.panel3.Controls.Add(this.LogInLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.MinimumSize = new System.Drawing.Size(1000, 800);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1104, 800);
            this.panel3.TabIndex = 5;
            // 
            // registerButton
            // 
            this.registerButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.registerButton.Location = new System.Drawing.Point(597, 356);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(118, 38);
            this.registerButton.TabIndex = 11;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginButton.Location = new System.Drawing.Point(441, 356);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(118, 38);
            this.loginButton.TabIndex = 10;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Location = new System.Drawing.Point(441, 299);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(274, 22);
            this.passwordTextBox.TabIndex = 9;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.passwordLabel.Location = new System.Drawing.Point(332, 299);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(103, 23);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Location = new System.Drawing.Point(443, 238);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(274, 22);
            this.emailTextBox.TabIndex = 7;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.emailLabel.Location = new System.Drawing.Point(332, 237);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(62, 23);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email";
            // 
            // LogInLabel
            // 
            this.LogInLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogInLabel.AutoSize = true;
            this.LogInLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.LogInLabel.Location = new System.Drawing.Point(533, 183);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Size = new System.Drawing.Size(68, 23);
            this.LogInLabel.TabIndex = 5;
            this.LogInLabel.Text = "Log In";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 747);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Healthcard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label LogInLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
    }
}

