namespace MyTestsDB.StudentForms
{
    partial class PassTestForm
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
            this.teachersTableAdapter = new MyTestsDB.MyTestsDataSetTableAdapters.TeachersTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.endTestButton = new System.Windows.Forms.Button();
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.preQuestionButton = new System.Windows.Forms.Button();
            this.testProgressBar = new System.Windows.Forms.ProgressBar();
            this.resultsTableAdapter = new MyTestsDB.MyTestsDataSetTableAdapters.ResultsTableAdapter();
            this.questionsCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.questionTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(796, 446);
            this.splitContainer1.SplitterDistance = 70;
            this.splitContainer1.TabIndex = 0;
            // 
            // questionTextBox
            // 
            this.questionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionTextBox.Location = new System.Drawing.Point(0, 0);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ReadOnly = true;
            this.questionTextBox.Size = new System.Drawing.Size(796, 70);
            this.questionTextBox.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.questionsCountLabel);
            this.splitContainer2.Panel2.Controls.Add(this.endTestButton);
            this.splitContainer2.Panel2.Controls.Add(this.nextQuestionButton);
            this.splitContainer2.Panel2.Controls.Add(this.preQuestionButton);
            this.splitContainer2.Panel2.Controls.Add(this.testProgressBar);
            this.splitContainer2.Size = new System.Drawing.Size(796, 372);
            this.splitContainer2.SplitterDistance = 302;
            this.splitContainer2.TabIndex = 0;
            // 
            // endTestButton
            // 
            this.endTestButton.Location = new System.Drawing.Point(664, 12);
            this.endTestButton.Name = "endTestButton";
            this.endTestButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.endTestButton.Size = new System.Drawing.Size(118, 42);
            this.endTestButton.TabIndex = 3;
            this.endTestButton.Text = "End test";
            this.endTestButton.UseVisualStyleBackColor = true;
            this.endTestButton.Click += new System.EventHandler(this.endTestButton_Click);
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.Location = new System.Drawing.Point(547, 12);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(111, 42);
            this.nextQuestionButton.TabIndex = 2;
            this.nextQuestionButton.Text = "Next question";
            this.nextQuestionButton.UseVisualStyleBackColor = true;
            this.nextQuestionButton.Click += new System.EventHandler(this.nextQuestionButton_Click);
            // 
            // preQuestionButton
            // 
            this.preQuestionButton.Location = new System.Drawing.Point(434, 12);
            this.preQuestionButton.Name = "preQuestionButton";
            this.preQuestionButton.Size = new System.Drawing.Size(107, 42);
            this.preQuestionButton.TabIndex = 1;
            this.preQuestionButton.Text = "Previous question";
            this.preQuestionButton.UseVisualStyleBackColor = true;
            this.preQuestionButton.Click += new System.EventHandler(this.preQuestionButton_Click);
            // 
            // testProgressBar
            // 
            this.testProgressBar.Location = new System.Drawing.Point(12, 12);
            this.testProgressBar.Name = "testProgressBar";
            this.testProgressBar.Size = new System.Drawing.Size(293, 42);
            this.testProgressBar.TabIndex = 0;
            // 
            // resultsTableAdapter
            // 
            this.resultsTableAdapter.ClearBeforeFill = true;
            // 
            // questionsCountLabel
            // 
            this.questionsCountLabel.AutoSize = true;
            this.questionsCountLabel.Location = new System.Drawing.Point(311, 27);
            this.questionsCountLabel.Name = "questionsCountLabel";
            this.questionsCountLabel.Size = new System.Drawing.Size(49, 13);
            this.questionsCountLabel.TabIndex = 4;
            this.questionsCountLabel.Text = "Question";
            // 
            // PassTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 446);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PassTestForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassTestForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PassTestForm_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MyTestsDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button endTestButton;
        private System.Windows.Forms.Button nextQuestionButton;
        private System.Windows.Forms.Button preQuestionButton;
        private System.Windows.Forms.ProgressBar testProgressBar;
        private MyTestsDataSetTableAdapters.ResultsTableAdapter resultsTableAdapter;
        private System.Windows.Forms.Label questionsCountLabel;
    }
}