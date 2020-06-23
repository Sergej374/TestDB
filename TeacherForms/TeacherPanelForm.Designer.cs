namespace MyTestsDB
{
    partial class TeacherPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherPanelForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusDateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSelectedTestLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusQuestionsCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusSelectedQuestionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSelectedQuestionTypeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.addQuestionButton = new System.Windows.Forms.ToolStripButton();
            this.removeQuestionButton = new System.Windows.Forms.ToolStripButton();
            this.editQuestionButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.newTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionsListBox = new System.Windows.Forms.ListBox();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.questionWorkSplitContainer = new System.Windows.Forms.SplitContainer();
            this.answersSplitContainer = new System.Windows.Forms.SplitContainer();
            this.removeOptionButton = new System.Windows.Forms.Button();
            this.cancelQuestionButton = new System.Windows.Forms.Button();
            this.saveQuestionButton = new System.Windows.Forms.Button();
            this.addOptionButton = new System.Windows.Forms.Button();
            this.teachersTableAdapter = new MyTestsDB.MyTestsDataSetTableAdapters.TeachersTableAdapter();
            this.testsTableAdapter1 = new MyTestsDB.MyTestsDataSetTableAdapters.TestsTableAdapter();
            this.testCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionWorkSplitContainer)).BeginInit();
            this.questionWorkSplitContainer.Panel1.SuspendLayout();
            this.questionWorkSplitContainer.Panel2.SuspendLayout();
            this.questionWorkSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.answersSplitContainer)).BeginInit();
            this.answersSplitContainer.Panel2.SuspendLayout();
            this.answersSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusDateLabel,
            this.statusSelectedTestLabel,
            this.statusQuestionsCountLabel,
            this.StatusSelectedQuestionLabel,
            this.statusSelectedQuestionTypeLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusDateLabel
            // 
            this.statusDateLabel.Name = "statusDateLabel";
            this.statusDateLabel.Size = new System.Drawing.Size(90, 17);
            this.statusDateLabel.Text = "statusDateLabel";
            // 
            // statusSelectedTestLabel
            // 
            this.statusSelectedTestLabel.Name = "statusSelectedTestLabel";
            this.statusSelectedTestLabel.Size = new System.Drawing.Size(118, 17);
            this.statusSelectedTestLabel.Text = "toolStripStatusLabel1";
            // 
            // statusQuestionsCountLabel
            // 
            this.statusQuestionsCountLabel.Name = "statusQuestionsCountLabel";
            this.statusQuestionsCountLabel.Size = new System.Drawing.Size(118, 17);
            this.statusQuestionsCountLabel.Text = "toolStripStatusLabel1";
            // 
            // StatusSelectedQuestionLabel
            // 
            this.StatusSelectedQuestionLabel.Name = "StatusSelectedQuestionLabel";
            this.StatusSelectedQuestionLabel.Size = new System.Drawing.Size(118, 17);
            this.StatusSelectedQuestionLabel.Text = "toolStripStatusLabel1";
            // 
            // statusSelectedQuestionTypeLabel
            // 
            this.statusSelectedQuestionTypeLabel.Name = "statusSelectedQuestionTypeLabel";
            this.statusSelectedQuestionTypeLabel.Size = new System.Drawing.Size(182, 17);
            this.statusSelectedQuestionTypeLabel.Text = "statusSelectedQuestionTypeLabel";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addQuestionButton,
            this.removeQuestionButton,
            this.editQuestionButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 5;
            this.toolStrip.Text = "toolStrip1";
            // 
            // addQuestionButton
            // 
            this.addQuestionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addQuestionButton.Enabled = false;
            this.addQuestionButton.Image = ((System.Drawing.Image)(resources.GetObject("addQuestionButton.Image")));
            this.addQuestionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.Size = new System.Drawing.Size(33, 22);
            this.addQuestionButton.Text = "Add";
            this.addQuestionButton.Click += new System.EventHandler(this.addQuestionButton_Click);
            // 
            // removeQuestionButton
            // 
            this.removeQuestionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.removeQuestionButton.Enabled = false;
            this.removeQuestionButton.Image = ((System.Drawing.Image)(resources.GetObject("removeQuestionButton.Image")));
            this.removeQuestionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeQuestionButton.Name = "removeQuestionButton";
            this.removeQuestionButton.Size = new System.Drawing.Size(54, 22);
            this.removeQuestionButton.Text = "Remove";
            // 
            // editQuestionButton
            // 
            this.editQuestionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editQuestionButton.Enabled = false;
            this.editQuestionButton.Image = ((System.Drawing.Image)(resources.GetObject("editQuestionButton.Image")));
            this.editQuestionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editQuestionButton.Name = "editQuestionButton";
            this.editQuestionButton.Size = new System.Drawing.Size(31, 22);
            this.editQuestionButton.Text = "Edit";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTestToolStripMenuItem,
            this.saveTestToolStripMenuItem,
            this.openTestToolStripMenuItem,
            this.testStatisticsToolStripMenuItem,
            this.renameTestToolStripMenuItem,
            this.testCommentToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // newTestToolStripMenuItem
            // 
            this.newTestToolStripMenuItem.Name = "newTestToolStripMenuItem";
            this.newTestToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.newTestToolStripMenuItem.Text = "New test";
            this.newTestToolStripMenuItem.Click += new System.EventHandler(this.newTestToolStripMenuItem_Click);
            // 
            // saveTestToolStripMenuItem
            // 
            this.saveTestToolStripMenuItem.Name = "saveTestToolStripMenuItem";
            this.saveTestToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.saveTestToolStripMenuItem.Text = "Save test";
            this.saveTestToolStripMenuItem.Click += new System.EventHandler(this.saveTestToolStripMenuItem_Click);
            // 
            // openTestToolStripMenuItem
            // 
            this.openTestToolStripMenuItem.Name = "openTestToolStripMenuItem";
            this.openTestToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.openTestToolStripMenuItem.Text = "Open test";
            this.openTestToolStripMenuItem.Click += new System.EventHandler(this.openTestToolStripMenuItem_Click);
            // 
            // testStatisticsToolStripMenuItem
            // 
            this.testStatisticsToolStripMenuItem.Name = "testStatisticsToolStripMenuItem";
            this.testStatisticsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.testStatisticsToolStripMenuItem.Text = "Test statistics";
            // 
            // renameTestToolStripMenuItem
            // 
            this.renameTestToolStripMenuItem.Name = "renameTestToolStripMenuItem";
            this.renameTestToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.renameTestToolStripMenuItem.Text = "Rename test";
            this.renameTestToolStripMenuItem.Click += new System.EventHandler(this.renameTestToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // questionsListBox
            // 
            this.questionsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionsListBox.FormattingEnabled = true;
            this.questionsListBox.Location = new System.Drawing.Point(0, 0);
            this.questionsListBox.Name = "questionsListBox";
            this.questionsListBox.Size = new System.Drawing.Size(138, 379);
            this.questionsListBox.TabIndex = 7;
            this.questionsListBox.SelectedIndexChanged += new System.EventHandler(this.questionsListBox_SelectedIndexChanged);
            // 
            // questionTextBox
            // 
            this.questionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionTextBox.Enabled = false;
            this.questionTextBox.Location = new System.Drawing.Point(0, 0);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(658, 77);
            this.questionTextBox.TabIndex = 8;
            this.questionTextBox.TextChanged += new System.EventHandler(this.questionTextBox_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.questionsListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.questionWorkSplitContainer);
            this.splitContainer1.Size = new System.Drawing.Size(800, 379);
            this.splitContainer1.SplitterDistance = 138;
            this.splitContainer1.TabIndex = 9;
            // 
            // questionWorkSplitContainer
            // 
            this.questionWorkSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionWorkSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.questionWorkSplitContainer.Name = "questionWorkSplitContainer";
            this.questionWorkSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // questionWorkSplitContainer.Panel1
            // 
            this.questionWorkSplitContainer.Panel1.Controls.Add(this.questionTextBox);
            // 
            // questionWorkSplitContainer.Panel2
            // 
            this.questionWorkSplitContainer.Panel2.Controls.Add(this.answersSplitContainer);
            this.questionWorkSplitContainer.Size = new System.Drawing.Size(658, 379);
            this.questionWorkSplitContainer.SplitterDistance = 77;
            this.questionWorkSplitContainer.TabIndex = 9;
            // 
            // answersSplitContainer
            // 
            this.answersSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answersSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.answersSplitContainer.Name = "answersSplitContainer";
            this.answersSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // answersSplitContainer.Panel1
            // 
            this.answersSplitContainer.Panel1.AccessibleName = "answersWorkPanel";
            // 
            // answersSplitContainer.Panel2
            // 
            this.answersSplitContainer.Panel2.Controls.Add(this.removeOptionButton);
            this.answersSplitContainer.Panel2.Controls.Add(this.cancelQuestionButton);
            this.answersSplitContainer.Panel2.Controls.Add(this.saveQuestionButton);
            this.answersSplitContainer.Panel2.Controls.Add(this.addOptionButton);
            this.answersSplitContainer.Size = new System.Drawing.Size(658, 298);
            this.answersSplitContainer.SplitterDistance = 242;
            this.answersSplitContainer.TabIndex = 4;
            // 
            // removeOptionButton
            // 
            this.removeOptionButton.Enabled = false;
            this.removeOptionButton.Location = new System.Drawing.Point(96, 14);
            this.removeOptionButton.Name = "removeOptionButton";
            this.removeOptionButton.Size = new System.Drawing.Size(88, 23);
            this.removeOptionButton.TabIndex = 3;
            this.removeOptionButton.Text = "Remove option";
            this.removeOptionButton.UseVisualStyleBackColor = true;
            // 
            // cancelQuestionButton
            // 
            this.cancelQuestionButton.Enabled = false;
            this.cancelQuestionButton.Location = new System.Drawing.Point(356, 14);
            this.cancelQuestionButton.Name = "cancelQuestionButton";
            this.cancelQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.cancelQuestionButton.TabIndex = 2;
            this.cancelQuestionButton.Text = "Cancel";
            this.cancelQuestionButton.UseVisualStyleBackColor = true;
            // 
            // saveQuestionButton
            // 
            this.saveQuestionButton.Enabled = false;
            this.saveQuestionButton.Location = new System.Drawing.Point(266, 14);
            this.saveQuestionButton.Name = "saveQuestionButton";
            this.saveQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.saveQuestionButton.TabIndex = 1;
            this.saveQuestionButton.Text = "Save";
            this.saveQuestionButton.UseVisualStyleBackColor = true;
            this.saveQuestionButton.Click += new System.EventHandler(this.saveQuestionButton_Click);
            // 
            // addOptionButton
            // 
            this.addOptionButton.Enabled = false;
            this.addOptionButton.Location = new System.Drawing.Point(14, 14);
            this.addOptionButton.Name = "addOptionButton";
            this.addOptionButton.Size = new System.Drawing.Size(75, 23);
            this.addOptionButton.TabIndex = 0;
            this.addOptionButton.Text = "Add option";
            this.addOptionButton.UseVisualStyleBackColor = true;
            this.addOptionButton.Click += new System.EventHandler(this.addOptionButton_Click);
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // testsTableAdapter1
            // 
            this.testsTableAdapter1.ClearBeforeFill = true;
            // 
            // testCommentToolStripMenuItem
            // 
            this.testCommentToolStripMenuItem.Name = "testCommentToolStripMenuItem";
            this.testCommentToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.testCommentToolStripMenuItem.Text = "Test comment";
            this.testCommentToolStripMenuItem.Click += new System.EventHandler(this.testCommentToolStripMenuItem_Click);
            // 
            // TeacherPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TeacherPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tests workpanel | Logged as";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.questionWorkSplitContainer.Panel1.ResumeLayout(false);
            this.questionWorkSplitContainer.Panel1.PerformLayout();
            this.questionWorkSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.questionWorkSplitContainer)).EndInit();
            this.questionWorkSplitContainer.ResumeLayout(false);
            this.answersSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.answersSplitContainer)).EndInit();
            this.answersSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ListBox questionsListBox;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer questionWorkSplitContainer;
        private System.Windows.Forms.SplitContainer answersSplitContainer;
        private System.Windows.Forms.ToolStripStatusLabel statusDateLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusSelectedTestLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusQuestionsCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel StatusSelectedQuestionLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusSelectedQuestionTypeLabel;
        private System.Windows.Forms.ToolStripButton addQuestionButton;
        private System.Windows.Forms.ToolStripButton removeQuestionButton;
        private System.Windows.Forms.ToolStripButton editQuestionButton;
        private System.Windows.Forms.ToolStripMenuItem newTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button addOptionButton;
        private System.Windows.Forms.Button removeOptionButton;
        private System.Windows.Forms.Button cancelQuestionButton;
        private System.Windows.Forms.Button saveQuestionButton;
        private MyTestsDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem renameTestToolStripMenuItem;
        private MyTestsDataSetTableAdapters.TestsTableAdapter testsTableAdapter1;
        private System.Windows.Forms.ToolStripMenuItem testCommentToolStripMenuItem;
    }
}