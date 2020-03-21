namespace HealthcardWinForms
{
    partial class RegisterForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fillInRequiredLabel = new System.Windows.Forms.Label();
            this.registerLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.userTypeLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.mobileNoLabel = new System.Windows.Forms.Label();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.genderGroupBox = new System.Windows.Forms.GroupBox();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordtTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.userTypeComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.genderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.fillInRequiredLabel);
            this.panel1.Controls.Add(this.registerLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 747);
            this.panel1.TabIndex = 1;
            // 
            // fillInRequiredLabel
            // 
            this.fillInRequiredLabel.AutoSize = true;
            this.fillInRequiredLabel.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillInRequiredLabel.Location = new System.Drawing.Point(83, 249);
            this.fillInRequiredLabel.Name = "fillInRequiredLabel";
            this.fillInRequiredLabel.Size = new System.Drawing.Size(195, 23);
            this.fillInRequiredLabel.TabIndex = 1;
            this.fillInRequiredLabel.Text = "* Fields are required";
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel.Location = new System.Drawing.Point(83, 189);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(123, 33);
            this.registerLabel.TabIndex = 0;
            this.registerLabel.Text = "Register";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.firstNameLabel.Location = new System.Drawing.Point(482, 27);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(117, 23);
            this.firstNameLabel.TabIndex = 7;
            this.firstNameLabel.Text = "Firstname *";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.lastNameLabel.Location = new System.Drawing.Point(921, 26);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(115, 23);
            this.lastNameLabel.TabIndex = 8;
            this.lastNameLabel.Text = "Lastname*";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameTextBox.Location = new System.Drawing.Point(618, 27);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(274, 22);
            this.firstNameTextBox.TabIndex = 9;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameTextBox.Location = new System.Drawing.Point(1042, 27);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(274, 22);
            this.lastNameTextBox.TabIndex = 10;
            // 
            // userTypeLabel
            // 
            this.userTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userTypeLabel.AutoSize = true;
            this.userTypeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.userTypeLabel.Location = new System.Drawing.Point(482, 89);
            this.userTypeLabel.Name = "userTypeLabel";
            this.userTypeLabel.Size = new System.Drawing.Size(110, 23);
            this.userTypeLabel.TabIndex = 11;
            this.userTypeLabel.Text = "Usertype *";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.emailLabel.Location = new System.Drawing.Point(921, 86);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(77, 23);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "Email *";
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Location = new System.Drawing.Point(1042, 86);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(274, 22);
            this.email.TabIndex = 14;
            // 
            // mobileNoLabel
            // 
            this.mobileNoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mobileNoLabel.AutoSize = true;
            this.mobileNoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.mobileNoLabel.Location = new System.Drawing.Point(482, 162);
            this.mobileNoLabel.Name = "mobileNoLabel";
            this.mobileNoLabel.Size = new System.Drawing.Size(118, 23);
            this.mobileNoLabel.TabIndex = 15;
            this.mobileNoLabel.Text = "Mobile No*";
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mobileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mobileTextBox.Location = new System.Drawing.Point(618, 162);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(274, 22);
            this.mobileTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(921, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Age *";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ageTextBox.Location = new System.Drawing.Point(1042, 158);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(274, 22);
            this.ageTextBox.TabIndex = 18;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.passwordLabel.Location = new System.Drawing.Point(921, 223);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(112, 23);
            this.passwordLabel.TabIndex = 19;
            this.passwordLabel.Text = "Password*";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.label3.Location = new System.Drawing.Point(482, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Gender *";
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.genderGroupBox.Controls.Add(this.femaleRadioButton);
            this.genderGroupBox.Controls.Add(this.maleRadioButton);
            this.genderGroupBox.Location = new System.Drawing.Point(618, 223);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Size = new System.Drawing.Size(274, 36);
            this.genderGroupBox.TabIndex = 21;
            this.genderGroupBox.TabStop = false;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(115, 9);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(75, 21);
            this.femaleRadioButton.TabIndex = 1;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(7, 9);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(59, 21);
            this.maleRadioButton.TabIndex = 0;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Location = new System.Drawing.Point(1042, 223);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(274, 22);
            this.passwordTextBox.TabIndex = 22;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(851, 286);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(193, 23);
            this.confirmPasswordLabel.TabIndex = 23;
            this.confirmPasswordLabel.Text = "Confirm Password*";
            // 
            // confirmPasswordtTextBox
            // 
            this.confirmPasswordtTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.confirmPasswordtTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmPasswordtTextBox.Location = new System.Drawing.Point(803, 312);
            this.confirmPasswordtTextBox.Name = "confirmPasswordtTextBox";
            this.confirmPasswordtTextBox.Size = new System.Drawing.Size(274, 22);
            this.confirmPasswordtTextBox.TabIndex = 24;
            this.confirmPasswordtTextBox.UseSystemPasswordChar = true;
            // 
            // registerButton
            // 
            this.registerButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.registerButton.Location = new System.Drawing.Point(869, 350);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(164, 34);
            this.registerButton.TabIndex = 25;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // userTypeComboBox
            // 
            this.userTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userTypeComboBox.FormattingEnabled = true;
            this.userTypeComboBox.Items.AddRange(new object[] {
            "patient",
            "doctor"});
            this.userTypeComboBox.Location = new System.Drawing.Point(618, 86);
            this.userTypeComboBox.Name = "userTypeComboBox";
            this.userTypeComboBox.Size = new System.Drawing.Size(274, 24);
            this.userTypeComboBox.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 747);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.confirmPasswordtTextBox);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.genderGroupBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mobileTextBox);
            this.Controls.Add(this.mobileNoLabel);
            this.Controls.Add(this.email);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.userTypeComboBox);
            this.Controls.Add(this.userTypeLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.genderGroupBox.ResumeLayout(false);
            this.genderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fillInRequiredLabel;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label userTypeLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label mobileNoLabel;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox genderGroupBox;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox confirmPasswordtTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.ComboBox userTypeComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}