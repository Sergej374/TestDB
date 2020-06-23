namespace MyTestsDB
{
    partial class AuthorizationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.showPasswdBox = new System.Windows.Forms.CheckBox();
            this.cheatDataView = new System.Windows.Forms.DataGridView();
            this.iDteacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameteacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myTestsDataSet = new MyTestsDB.MyTestsDataSet();
            this.teachersTableAdapter = new MyTestsDB.MyTestsDataSetTableAdapters.TeachersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cheatDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTestsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(12, 29);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(100, 20);
            this.usernameBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(12, 68);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(13, 106);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(75, 23);
            this.signInButton.TabIndex = 4;
            this.signInButton.Text = "Sign in";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(108, 106);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(75, 23);
            this.signUpButton.TabIndex = 5;
            this.signUpButton.Text = "Sign up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // showPasswdBox
            // 
            this.showPasswdBox.AutoSize = true;
            this.showPasswdBox.Location = new System.Drawing.Point(119, 70);
            this.showPasswdBox.Name = "showPasswdBox";
            this.showPasswdBox.Size = new System.Drawing.Size(53, 17);
            this.showPasswdBox.TabIndex = 6;
            this.showPasswdBox.Text = "Show";
            this.showPasswdBox.UseVisualStyleBackColor = true;
            this.showPasswdBox.CheckedChanged += new System.EventHandler(this.showPasswdBox_CheckedChanged);
            // 
            // cheatDataView
            // 
            this.cheatDataView.AutoGenerateColumns = false;
            this.cheatDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cheatDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDteacherDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.nameteacherDataGridViewTextBoxColumn});
            this.cheatDataView.DataSource = this.teachersBindingSource;
            this.cheatDataView.Location = new System.Drawing.Point(13, 177);
            this.cheatDataView.Name = "cheatDataView";
            this.cheatDataView.Size = new System.Drawing.Size(178, 150);
            this.cheatDataView.TabIndex = 7;
            // 
            // iDteacherDataGridViewTextBoxColumn
            // 
            this.iDteacherDataGridViewTextBoxColumn.DataPropertyName = "ID_teacher";
            this.iDteacherDataGridViewTextBoxColumn.HeaderText = "ID_teacher";
            this.iDteacherDataGridViewTextBoxColumn.Name = "iDteacherDataGridViewTextBoxColumn";
            this.iDteacherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // nameteacherDataGridViewTextBoxColumn
            // 
            this.nameteacherDataGridViewTextBoxColumn.DataPropertyName = "Name_teacher";
            this.nameteacherDataGridViewTextBoxColumn.HeaderText = "Name_teacher";
            this.nameteacherDataGridViewTextBoxColumn.Name = "nameteacherDataGridViewTextBoxColumn";
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.myTestsDataSet;
            // 
            // myTestsDataSet
            // 
            this.myTestsDataSet.DataSetName = "MyTestsDataSet";
            this.myTestsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 345);
            this.Controls.Add(this.cheatDataView);
            this.Controls.Add(this.showPasswdBox);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AuthorizationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cheatDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTestsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.CheckBox showPasswdBox;
        private System.Windows.Forms.DataGridView cheatDataView;
        private MyTestsDataSet myTestsDataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private MyTestsDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDteacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameteacherDataGridViewTextBoxColumn;
    }
}