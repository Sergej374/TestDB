namespace MyTestsDB.StudentForms
{
    partial class StudentAuthForm
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
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.fullNameBox = new System.Windows.Forms.TextBox();
            this.groupsBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.authButton = new System.Windows.Forms.Button();
            this.groupsTableAdapter = new MyTestsDB.MyTestsDataSetTableAdapters.GroupsTableAdapter();
            this.studentsTableAdapter = new MyTestsDB.MyTestsDataSetTableAdapters.StudentsTableAdapter();
            this.SuspendLayout();
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Location = new System.Drawing.Point(9, 10);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(52, 13);
            this.fullnameLabel.TabIndex = 0;
            this.fullnameLabel.Text = "Full name";
            // 
            // fullNameBox
            // 
            this.fullNameBox.Location = new System.Drawing.Point(12, 26);
            this.fullNameBox.Name = "fullNameBox";
            this.fullNameBox.Size = new System.Drawing.Size(209, 20);
            this.fullNameBox.TabIndex = 1;
            this.fullNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fullNameBox_KeyPress);
            // 
            // groupsBox
            // 
            this.groupsBox.FormattingEnabled = true;
            this.groupsBox.Location = new System.Drawing.Point(12, 71);
            this.groupsBox.Name = "groupsBox";
            this.groupsBox.Size = new System.Drawing.Size(209, 21);
            this.groupsBox.TabIndex = 2;
            this.groupsBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.groupsBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Group";
            // 
            // authButton
            // 
            this.authButton.Location = new System.Drawing.Point(15, 110);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(206, 39);
            this.authButton.TabIndex = 4;
            this.authButton.Text = "Authorize";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // StudentAuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 168);
            this.Controls.Add(this.authButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupsBox);
            this.Controls.Add(this.fullNameBox);
            this.Controls.Add(this.fullnameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StudentAuthForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.TextBox fullNameBox;
        private System.Windows.Forms.ComboBox groupsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button authButton;
        private MyTestsDataSetTableAdapters.GroupsTableAdapter groupsTableAdapter;
        private MyTestsDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
    }
}