namespace HealthcardWinForms
{
    partial class PrescriptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrescriptionForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fillInRequiredLabel = new System.Windows.Forms.Label();
            this.navigationLabel = new System.Windows.Forms.Label();
            this.MedicineLabel = new System.Windows.Forms.Label();
            this.MedicineNameTextBox = new System.Windows.Forms.TextBox();
            this.ToPatientLabel = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.entityCommand2 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.ToPatientTextBox = new System.Windows.Forms.TextBox();
            this.MorningDoseLabel = new System.Windows.Forms.Label();
            this.MorningDoseGroupBox = new System.Windows.Forms.GroupBox();
            this.one = new System.Windows.Forms.RadioButton();
            this.two = new System.Windows.Forms.RadioButton();
            this.three = new System.Windows.Forms.RadioButton();
            this.four = new System.Windows.Forms.RadioButton();
            this.AfternoonDoseLabel = new System.Windows.Forms.Label();
            this.AfternoonGroupBox = new System.Windows.Forms.GroupBox();
            this.a_four = new System.Windows.Forms.RadioButton();
            this.a_three = new System.Windows.Forms.RadioButton();
            this.a_two = new System.Windows.Forms.RadioButton();
            this.a_one = new System.Windows.Forms.RadioButton();
            this.NightDoseLabel = new System.Windows.Forms.Label();
            this.NightDoseGroupBox = new System.Windows.Forms.GroupBox();
            this.n_four = new System.Windows.Forms.RadioButton();
            this.n_three = new System.Windows.Forms.RadioButton();
            this.n_two = new System.Windows.Forms.RadioButton();
            this.n_one = new System.Windows.Forms.RadioButton();
            this.PrescriptionSaveButton = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.RadioButton();
            this.a_zero = new System.Windows.Forms.RadioButton();
            this.n_zero = new System.Windows.Forms.RadioButton();
            this.DaysLabel = new System.Windows.Forms.Label();
            this.DaysTextBox = new System.Windows.Forms.TextBox();
            this.HintLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MorningDoseGroupBox.SuspendLayout();
            this.AfternoonGroupBox.SuspendLayout();
            this.NightDoseGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.fillInRequiredLabel);
            this.panel1.Controls.Add(this.navigationLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 747);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // fillInRequiredLabel
            // 
            this.fillInRequiredLabel.AutoSize = true;
            this.fillInRequiredLabel.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillInRequiredLabel.Location = new System.Drawing.Point(83, 249);
            this.fillInRequiredLabel.Name = "fillInRequiredLabel";
            this.fillInRequiredLabel.Size = new System.Drawing.Size(0, 23);
            this.fillInRequiredLabel.TabIndex = 1;
            // 
            // navigationLabel
            // 
            this.navigationLabel.AutoSize = true;
            this.navigationLabel.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationLabel.Location = new System.Drawing.Point(52, 200);
            this.navigationLabel.Name = "navigationLabel";
            this.navigationLabel.Size = new System.Drawing.Size(251, 33);
            this.navigationLabel.TabIndex = 0;
            this.navigationLabel.Text = "Prescription Form";
            // 
            // MedicineLabel
            // 
            this.MedicineLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MedicineLabel.AutoSize = true;
            this.MedicineLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.MedicineLabel.Location = new System.Drawing.Point(414, 116);
            this.MedicineLabel.Name = "MedicineLabel";
            this.MedicineLabel.Size = new System.Drawing.Size(180, 23);
            this.MedicineLabel.TabIndex = 8;
            this.MedicineLabel.Text = "Medicine Name *";
            // 
            // MedicineNameTextBox
            // 
            this.MedicineNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MedicineNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.MedicineNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MedicineNameTextBox.Location = new System.Drawing.Point(620, 116);
            this.MedicineNameTextBox.Name = "MedicineNameTextBox";
            this.MedicineNameTextBox.Size = new System.Drawing.Size(274, 22);
            this.MedicineNameTextBox.TabIndex = 11;
            // 
            // ToPatientLabel
            // 
            this.ToPatientLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ToPatientLabel.AutoSize = true;
            this.ToPatientLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToPatientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.ToPatientLabel.Location = new System.Drawing.Point(474, 45);
            this.ToPatientLabel.Name = "ToPatientLabel";
            this.ToPatientLabel.Size = new System.Drawing.Size(120, 23);
            this.ToPatientLabel.TabIndex = 12;
            this.ToPatientLabel.Text = "To Patient *";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // entityCommand2
            // 
            this.entityCommand2.CommandTimeout = 0;
            this.entityCommand2.CommandTree = null;
            this.entityCommand2.Connection = null;
            this.entityCommand2.EnablePlanCaching = true;
            this.entityCommand2.Transaction = null;
            // 
            // ToPatientTextBox
            // 
            this.ToPatientTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ToPatientTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ToPatientTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ToPatientTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToPatientTextBox.Location = new System.Drawing.Point(620, 45);
            this.ToPatientTextBox.Name = "ToPatientTextBox";
            this.ToPatientTextBox.Size = new System.Drawing.Size(274, 22);
            this.ToPatientTextBox.TabIndex = 13;
            // 
            // MorningDoseLabel
            // 
            this.MorningDoseLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MorningDoseLabel.AutoSize = true;
            this.MorningDoseLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MorningDoseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.MorningDoseLabel.Location = new System.Drawing.Point(438, 188);
            this.MorningDoseLabel.Name = "MorningDoseLabel";
            this.MorningDoseLabel.Size = new System.Drawing.Size(147, 23);
            this.MorningDoseLabel.TabIndex = 14;
            this.MorningDoseLabel.Text = "Morning Dose ";
            // 
            // MorningDoseGroupBox
            // 
            this.MorningDoseGroupBox.Controls.Add(this.zero);
            this.MorningDoseGroupBox.Controls.Add(this.four);
            this.MorningDoseGroupBox.Controls.Add(this.three);
            this.MorningDoseGroupBox.Controls.Add(this.two);
            this.MorningDoseGroupBox.Controls.Add(this.one);
            this.MorningDoseGroupBox.Location = new System.Drawing.Point(620, 178);
            this.MorningDoseGroupBox.Name = "MorningDoseGroupBox";
            this.MorningDoseGroupBox.Size = new System.Drawing.Size(274, 42);
            this.MorningDoseGroupBox.TabIndex = 15;
            this.MorningDoseGroupBox.TabStop = false;
            // 
            // one
            // 
            this.one.AutoSize = true;
            this.one.Location = new System.Drawing.Point(59, 10);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(37, 21);
            this.one.TabIndex = 0;
            this.one.TabStop = true;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            // 
            // two
            // 
            this.two.AutoSize = true;
            this.two.Location = new System.Drawing.Point(116, 10);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(37, 21);
            this.two.TabIndex = 1;
            this.two.TabStop = true;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            // 
            // three
            // 
            this.three.AutoSize = true;
            this.three.Location = new System.Drawing.Point(175, 10);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(37, 21);
            this.three.TabIndex = 2;
            this.three.TabStop = true;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            // 
            // four
            // 
            this.four.AutoSize = true;
            this.four.Location = new System.Drawing.Point(231, 10);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(37, 21);
            this.four.TabIndex = 3;
            this.four.TabStop = true;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            // 
            // AfternoonDoseLabel
            // 
            this.AfternoonDoseLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AfternoonDoseLabel.AutoSize = true;
            this.AfternoonDoseLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfternoonDoseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.AfternoonDoseLabel.Location = new System.Drawing.Point(426, 259);
            this.AfternoonDoseLabel.Name = "AfternoonDoseLabel";
            this.AfternoonDoseLabel.Size = new System.Drawing.Size(168, 23);
            this.AfternoonDoseLabel.TabIndex = 16;
            this.AfternoonDoseLabel.Text = "Afternoon Dose ";
            // 
            // AfternoonGroupBox
            // 
            this.AfternoonGroupBox.Controls.Add(this.a_zero);
            this.AfternoonGroupBox.Controls.Add(this.a_four);
            this.AfternoonGroupBox.Controls.Add(this.a_three);
            this.AfternoonGroupBox.Controls.Add(this.a_two);
            this.AfternoonGroupBox.Controls.Add(this.a_one);
            this.AfternoonGroupBox.Location = new System.Drawing.Point(620, 249);
            this.AfternoonGroupBox.Name = "AfternoonGroupBox";
            this.AfternoonGroupBox.Size = new System.Drawing.Size(274, 42);
            this.AfternoonGroupBox.TabIndex = 16;
            this.AfternoonGroupBox.TabStop = false;
            // 
            // a_four
            // 
            this.a_four.AutoSize = true;
            this.a_four.Location = new System.Drawing.Point(231, 10);
            this.a_four.Name = "a_four";
            this.a_four.Size = new System.Drawing.Size(37, 21);
            this.a_four.TabIndex = 3;
            this.a_four.TabStop = true;
            this.a_four.Text = "4";
            this.a_four.UseVisualStyleBackColor = true;
            // 
            // a_three
            // 
            this.a_three.AutoSize = true;
            this.a_three.Location = new System.Drawing.Point(175, 10);
            this.a_three.Name = "a_three";
            this.a_three.Size = new System.Drawing.Size(37, 21);
            this.a_three.TabIndex = 2;
            this.a_three.TabStop = true;
            this.a_three.Text = "3";
            this.a_three.UseVisualStyleBackColor = true;
            // 
            // a_two
            // 
            this.a_two.AutoSize = true;
            this.a_two.Location = new System.Drawing.Point(116, 10);
            this.a_two.Name = "a_two";
            this.a_two.Size = new System.Drawing.Size(37, 21);
            this.a_two.TabIndex = 1;
            this.a_two.TabStop = true;
            this.a_two.Text = "2";
            this.a_two.UseVisualStyleBackColor = true;
            // 
            // a_one
            // 
            this.a_one.AutoSize = true;
            this.a_one.Location = new System.Drawing.Point(59, 10);
            this.a_one.Name = "a_one";
            this.a_one.Size = new System.Drawing.Size(37, 21);
            this.a_one.TabIndex = 0;
            this.a_one.TabStop = true;
            this.a_one.Text = "1";
            this.a_one.UseVisualStyleBackColor = true;
            // 
            // NightDoseLabel
            // 
            this.NightDoseLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NightDoseLabel.AutoSize = true;
            this.NightDoseLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NightDoseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.NightDoseLabel.Location = new System.Drawing.Point(464, 344);
            this.NightDoseLabel.Name = "NightDoseLabel";
            this.NightDoseLabel.Size = new System.Drawing.Size(121, 23);
            this.NightDoseLabel.TabIndex = 17;
            this.NightDoseLabel.Text = "Night Dose ";
            // 
            // NightDoseGroupBox
            // 
            this.NightDoseGroupBox.Controls.Add(this.n_zero);
            this.NightDoseGroupBox.Controls.Add(this.n_four);
            this.NightDoseGroupBox.Controls.Add(this.n_three);
            this.NightDoseGroupBox.Controls.Add(this.n_two);
            this.NightDoseGroupBox.Controls.Add(this.n_one);
            this.NightDoseGroupBox.Location = new System.Drawing.Point(620, 334);
            this.NightDoseGroupBox.Name = "NightDoseGroupBox";
            this.NightDoseGroupBox.Size = new System.Drawing.Size(274, 42);
            this.NightDoseGroupBox.TabIndex = 17;
            this.NightDoseGroupBox.TabStop = false;
            // 
            // n_four
            // 
            this.n_four.AutoSize = true;
            this.n_four.Location = new System.Drawing.Point(231, 15);
            this.n_four.Name = "n_four";
            this.n_four.Size = new System.Drawing.Size(37, 21);
            this.n_four.TabIndex = 3;
            this.n_four.TabStop = true;
            this.n_four.Text = "4";
            this.n_four.UseVisualStyleBackColor = true;
            // 
            // n_three
            // 
            this.n_three.AutoSize = true;
            this.n_three.Location = new System.Drawing.Point(175, 15);
            this.n_three.Name = "n_three";
            this.n_three.Size = new System.Drawing.Size(37, 21);
            this.n_three.TabIndex = 2;
            this.n_three.TabStop = true;
            this.n_three.Text = "3";
            this.n_three.UseVisualStyleBackColor = true;
            // 
            // n_two
            // 
            this.n_two.AutoSize = true;
            this.n_two.Location = new System.Drawing.Point(116, 15);
            this.n_two.Name = "n_two";
            this.n_two.Size = new System.Drawing.Size(37, 21);
            this.n_two.TabIndex = 1;
            this.n_two.TabStop = true;
            this.n_two.Text = "2";
            this.n_two.UseVisualStyleBackColor = true;
            // 
            // n_one
            // 
            this.n_one.AutoSize = true;
            this.n_one.Location = new System.Drawing.Point(59, 15);
            this.n_one.Name = "n_one";
            this.n_one.Size = new System.Drawing.Size(37, 21);
            this.n_one.TabIndex = 0;
            this.n_one.TabStop = true;
            this.n_one.Text = "1";
            this.n_one.UseVisualStyleBackColor = true;
            // 
            // PrescriptionSaveButton
            // 
            this.PrescriptionSaveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PrescriptionSaveButton.Location = new System.Drawing.Point(697, 479);
            this.PrescriptionSaveButton.Name = "PrescriptionSaveButton";
            this.PrescriptionSaveButton.Size = new System.Drawing.Size(90, 34);
            this.PrescriptionSaveButton.TabIndex = 23;
            this.PrescriptionSaveButton.Text = "Save";
            this.PrescriptionSaveButton.UseVisualStyleBackColor = true;
            this.PrescriptionSaveButton.Click += new System.EventHandler(this.PrescriptionSaveButton_Click);
            // 
            // zero
            // 
            this.zero.AutoSize = true;
            this.zero.Location = new System.Drawing.Point(7, 11);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(37, 21);
            this.zero.TabIndex = 4;
            this.zero.TabStop = true;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            // 
            // a_zero
            // 
            this.a_zero.AutoSize = true;
            this.a_zero.Location = new System.Drawing.Point(7, 10);
            this.a_zero.Name = "a_zero";
            this.a_zero.Size = new System.Drawing.Size(37, 21);
            this.a_zero.TabIndex = 5;
            this.a_zero.TabStop = true;
            this.a_zero.Text = "0";
            this.a_zero.UseVisualStyleBackColor = true;
            // 
            // n_zero
            // 
            this.n_zero.AutoSize = true;
            this.n_zero.Location = new System.Drawing.Point(7, 15);
            this.n_zero.Name = "n_zero";
            this.n_zero.Size = new System.Drawing.Size(37, 21);
            this.n_zero.TabIndex = 6;
            this.n_zero.TabStop = true;
            this.n_zero.Text = "0";
            this.n_zero.UseVisualStyleBackColor = true;
            // 
            // DaysLabel
            // 
            this.DaysLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DaysLabel.AutoSize = true;
            this.DaysLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaysLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.DaysLabel.Location = new System.Drawing.Point(512, 405);
            this.DaysLabel.Name = "DaysLabel";
            this.DaysLabel.Size = new System.Drawing.Size(73, 23);
            this.DaysLabel.TabIndex = 25;
            this.DaysLabel.Text = "Days *";
            // 
            // DaysTextBox
            // 
            this.DaysTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DaysTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.DaysTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DaysTextBox.Location = new System.Drawing.Point(614, 405);
            this.DaysTextBox.Name = "DaysTextBox";
            this.DaysTextBox.Size = new System.Drawing.Size(274, 22);
            this.DaysTextBox.TabIndex = 26;
            // 
            // HintLabel
            // 
            this.HintLabel.AutoSize = true;
            this.HintLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HintLabel.Location = new System.Drawing.Point(390, 567);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(780, 23);
            this.HintLabel.TabIndex = 3;
            this.HintLabel.Text = "Note: To add another medicine click on save, then you can add more to prescriptio" +
    "n";
            // 
            // PrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 747);
            this.Controls.Add(this.HintLabel);
            this.Controls.Add(this.DaysTextBox);
            this.Controls.Add(this.DaysLabel);
            this.Controls.Add(this.PrescriptionSaveButton);
            this.Controls.Add(this.NightDoseGroupBox);
            this.Controls.Add(this.NightDoseLabel);
            this.Controls.Add(this.AfternoonGroupBox);
            this.Controls.Add(this.AfternoonDoseLabel);
            this.Controls.Add(this.MorningDoseGroupBox);
            this.Controls.Add(this.MorningDoseLabel);
            this.Controls.Add(this.ToPatientTextBox);
            this.Controls.Add(this.ToPatientLabel);
            this.Controls.Add(this.MedicineNameTextBox);
            this.Controls.Add(this.MedicineLabel);
            this.Controls.Add(this.panel1);
            this.Name = "PrescriptionForm";
            this.Text = "PrescriptionForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrescriptionForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrescriptionForm_FormClosed);
            this.Load += new System.EventHandler(this.PrescriptionForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MorningDoseGroupBox.ResumeLayout(false);
            this.MorningDoseGroupBox.PerformLayout();
            this.AfternoonGroupBox.ResumeLayout(false);
            this.AfternoonGroupBox.PerformLayout();
            this.NightDoseGroupBox.ResumeLayout(false);
            this.NightDoseGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label fillInRequiredLabel;
        private System.Windows.Forms.Label navigationLabel;
        private System.Windows.Forms.Label MedicineLabel;
        private System.Windows.Forms.TextBox MedicineNameTextBox;
        private System.Windows.Forms.Label ToPatientLabel;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand2;
        private System.Windows.Forms.TextBox ToPatientTextBox;
        private System.Windows.Forms.Label MorningDoseLabel;
        private System.Windows.Forms.GroupBox MorningDoseGroupBox;
        private System.Windows.Forms.RadioButton four;
        private System.Windows.Forms.RadioButton three;
        private System.Windows.Forms.RadioButton two;
        private System.Windows.Forms.RadioButton one;
        private System.Windows.Forms.Label AfternoonDoseLabel;
        private System.Windows.Forms.GroupBox AfternoonGroupBox;
        private System.Windows.Forms.RadioButton a_four;
        private System.Windows.Forms.RadioButton a_three;
        private System.Windows.Forms.RadioButton a_two;
        private System.Windows.Forms.RadioButton a_one;
        private System.Windows.Forms.Label NightDoseLabel;
        private System.Windows.Forms.GroupBox NightDoseGroupBox;
        private System.Windows.Forms.RadioButton n_four;
        private System.Windows.Forms.RadioButton n_three;
        private System.Windows.Forms.RadioButton n_two;
        private System.Windows.Forms.RadioButton n_one;
        private System.Windows.Forms.Button PrescriptionSaveButton;
        private System.Windows.Forms.RadioButton zero;
        private System.Windows.Forms.RadioButton a_zero;
        private System.Windows.Forms.RadioButton n_zero;
        private System.Windows.Forms.Label DaysLabel;
        private System.Windows.Forms.TextBox DaysTextBox;
        private System.Windows.Forms.Label HintLabel;
    }
}