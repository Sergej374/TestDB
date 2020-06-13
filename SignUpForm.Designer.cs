namespace MyTestsDB
{
    partial class SignUpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.realNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.repPasswordBox = new System.Windows.Forms.TextBox();
            this.passwordMatchLabel = new System.Windows.Forms.Label();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.captchaBox = new System.Windows.Forms.PictureBox();
            this.captchaEnterBox = new System.Windows.Forms.TextBox();
            this.captchaLabel = new System.Windows.Forms.Label();
            this.updateCaptchaButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.captchaBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(12, 28);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(100, 20);
            this.usernameBox.TabIndex = 1;
            // 
            // realNameBox
            // 
            this.realNameBox.Location = new System.Drawing.Point(12, 71);
            this.realNameBox.Name = "realNameBox";
            this.realNameBox.Size = new System.Drawing.Size(100, 20);
            this.realNameBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Real name";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(12, 114);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 5;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // repPasswordBox
            // 
            this.repPasswordBox.Location = new System.Drawing.Point(12, 158);
            this.repPasswordBox.Name = "repPasswordBox";
            this.repPasswordBox.Size = new System.Drawing.Size(100, 20);
            this.repPasswordBox.TabIndex = 7;
            this.repPasswordBox.UseSystemPasswordChar = true;
            this.repPasswordBox.TextChanged += new System.EventHandler(this.repPasswordBox_TextChanged);
            // 
            // passwordMatchLabel
            // 
            this.passwordMatchLabel.AutoSize = true;
            this.passwordMatchLabel.Location = new System.Drawing.Point(12, 141);
            this.passwordMatchLabel.Name = "passwordMatchLabel";
            this.passwordMatchLabel.Size = new System.Drawing.Size(90, 13);
            this.passwordMatchLabel.TabIndex = 6;
            this.passwordMatchLabel.Text = "Repeat password";
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(118, 116);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(53, 17);
            this.showPasswordCheckBox.TabIndex = 8;
            this.showPasswordCheckBox.Text = "Show";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // captchaBox
            // 
            this.captchaBox.Location = new System.Drawing.Point(12, 184);
            this.captchaBox.Name = "captchaBox";
            this.captchaBox.Size = new System.Drawing.Size(148, 57);
            this.captchaBox.TabIndex = 9;
            this.captchaBox.TabStop = false;
            this.captchaBox.Paint += new System.Windows.Forms.PaintEventHandler(this.captchaBox_Paint);
            // 
            // captchaEnterBox
            // 
            this.captchaEnterBox.Location = new System.Drawing.Point(12, 260);
            this.captchaEnterBox.Name = "captchaEnterBox";
            this.captchaEnterBox.Size = new System.Drawing.Size(100, 20);
            this.captchaEnterBox.TabIndex = 10;
            this.captchaEnterBox.Click += new System.EventHandler(this.captchaEnterBox_Click);
            // 
            // captchaLabel
            // 
            this.captchaLabel.AutoSize = true;
            this.captchaLabel.Location = new System.Drawing.Point(12, 244);
            this.captchaLabel.Name = "captchaLabel";
            this.captchaLabel.Size = new System.Drawing.Size(148, 13);
            this.captchaLabel.TabIndex = 11;
            this.captchaLabel.Text = "Enter symbols from the picture";
            // 
            // updateCaptchaButton
            // 
            this.updateCaptchaButton.Location = new System.Drawing.Point(166, 218);
            this.updateCaptchaButton.Name = "updateCaptchaButton";
            this.updateCaptchaButton.Size = new System.Drawing.Size(64, 23);
            this.updateCaptchaButton.TabIndex = 12;
            this.updateCaptchaButton.Text = "Refresh";
            this.updateCaptchaButton.UseVisualStyleBackColor = true;
            this.updateCaptchaButton.Click += new System.EventHandler(this.updateCaptchaButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(12, 286);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 13;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(96, 286);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // SignUpForm
            // 
            this.AcceptButton = this.finishButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(246, 338);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.updateCaptchaButton);
            this.Controls.Add(this.captchaLabel);
            this.Controls.Add(this.captchaEnterBox);
            this.Controls.Add(this.captchaBox);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.repPasswordBox);
            this.Controls.Add(this.passwordMatchLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.realNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SignUpForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)(this.captchaBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox realNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox repPasswordBox;
        private System.Windows.Forms.Label passwordMatchLabel;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.PictureBox captchaBox;
        private System.Windows.Forms.TextBox captchaEnterBox;
        private System.Windows.Forms.Label captchaLabel;
        private System.Windows.Forms.Button updateCaptchaButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.TextBox usernameBox;
    }
}