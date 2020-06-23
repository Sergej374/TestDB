namespace MyTestsDB
{
    partial class ChooseTestForPassingForm
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
            this.groupsTableAdapter1 = new MyTestsDB.MyTestsDataSetTableAdapters.GroupsTableAdapter();
            this.testsTableAdapter1 = new MyTestsDB.MyTestsDataSetTableAdapters.TestsTableAdapter();
            this.testButtonsPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // groupsTableAdapter1
            // 
            this.groupsTableAdapter1.ClearBeforeFill = true;
            // 
            // testsTableAdapter1
            // 
            this.testsTableAdapter1.ClearBeforeFill = true;
            // 
            // testButtonsPanel
            // 
            this.testButtonsPanel.AutoSize = true;
            this.testButtonsPanel.Location = new System.Drawing.Point(1, 1);
            this.testButtonsPanel.Name = "testButtonsPanel";
            this.testButtonsPanel.Size = new System.Drawing.Size(119, 43);
            this.testButtonsPanel.TabIndex = 1;
            // 
            // ChooseTestForPassingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(125, 52);
            this.ControlBox = false;
            this.Controls.Add(this.testButtonsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChooseTestForPassingForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose a test";
            this.Load += new System.EventHandler(this.ChooseTestForPassingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyTestsDataSetTableAdapters.GroupsTableAdapter groupsTableAdapter1;
        private MyTestsDataSetTableAdapters.TestsTableAdapter testsTableAdapter1;
        private System.Windows.Forms.Panel testButtonsPanel;
    }
}