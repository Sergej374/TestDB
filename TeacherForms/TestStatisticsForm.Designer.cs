namespace MyTestsDB.TeacherForms
{
    partial class TestStatisticsForm
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
            this.statisticsDateView = new System.Windows.Forms.DataGridView();
            this.groupsTableAdapter1 = new MyTestsDB.MyTestsDataSetTableAdapters.GroupsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsDateView)).BeginInit();
            this.SuspendLayout();
            // 
            // statisticsDateView
            // 
            this.statisticsDateView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisticsDateView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisticsDateView.Location = new System.Drawing.Point(0, 0);
            this.statisticsDateView.Name = "statisticsDateView";
            this.statisticsDateView.Size = new System.Drawing.Size(704, 328);
            this.statisticsDateView.TabIndex = 0;
            // 
            // groupsTableAdapter1
            // 
            this.groupsTableAdapter1.ClearBeforeFill = true;
            // 
            // TestStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 328);
            this.Controls.Add(this.statisticsDateView);
            this.Name = "TestStatisticsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.statisticsDateView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView statisticsDateView;
        private MyTestsDataSetTableAdapters.GroupsTableAdapter groupsTableAdapter1;
    }
}