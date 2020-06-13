namespace MyTestsDB
{
    partial class MainMenuForn
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
            this.testsButton = new System.Windows.Forms.Button();
            this.attemptButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testsButton
            // 
            this.testsButton.Location = new System.Drawing.Point(49, 34);
            this.testsButton.Name = "testsButton";
            this.testsButton.Size = new System.Drawing.Size(128, 47);
            this.testsButton.TabIndex = 0;
            this.testsButton.Text = "Tests";
            this.testsButton.UseVisualStyleBackColor = true;
            this.testsButton.Click += new System.EventHandler(this.testsButton_Click);
            // 
            // attemptButton
            // 
            this.attemptButton.Location = new System.Drawing.Point(49, 104);
            this.attemptButton.Name = "attemptButton";
            this.attemptButton.Size = new System.Drawing.Size(128, 47);
            this.attemptButton.TabIndex = 1;
            this.attemptButton.Text = "Attempt a test";
            this.attemptButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(49, 177);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 47);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainMenuForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 282);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.attemptButton);
            this.Controls.Add(this.testsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenuForn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyTests";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testsButton;
        private System.Windows.Forms.Button attemptButton;
        private System.Windows.Forms.Button exitButton;
    }
}

