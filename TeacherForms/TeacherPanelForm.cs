using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTestsDB
{
    public partial class TeacherPanelForm : Form
    {
        private string currentTestName;

        public Question CurrentQuestion { get; set; }
        public int CurrentQuestionNum { get; set; }
        public Test CurrentTest { get; set; }
        public string CurrentTestName
        {
            get => currentTestName;
            set
            {
                currentTestName = value;
                statusSelectedTestLabel.Text = "Test: " + value;
            }
        }
        public int TeacherCreatorID { get; }
        private MyTestsDataSetTableAdapters.TeachersTableAdapter TeachersTableAdapter { get; set; } = new MyTestsDataSetTableAdapters.TeachersTableAdapter();
        private MyTestsDataSetTableAdapters.TestsTableAdapter TestsTableAdapter { get; set; } = new MyTestsDataSetTableAdapters.TestsTableAdapter();
        private Timer TimeTimer { get; set; } = new Timer();

        public TeacherPanelForm(int creator)
        {
            InitializeComponent();
            TeacherCreatorID = creator;
            Text = "Tests workpanel | Logged as " + TeachersTableAdapter.GetData().Select("ID_teacher = " + TeacherCreatorID)[0][3] + ", ID: " + TeacherCreatorID;
            CurrentTestName = "None";
            TimeTimer.Interval = 1000;
            TimeTimer.Tick += PrintDate;
            TimeTimer.Start();
        }

        private void PrintDate(object sender, EventArgs e)
        {
            statusDateLabel.Text = DateTime.Now.ToString();
        }

        private void newTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTestNameForm newTestNameForm = new NewTestNameForm(this);
            if (newTestNameForm.ShowDialog() == DialogResult.OK)
            {
                LoadTest(new Test(TeacherCreatorID, CurrentTestName));
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            ChooseQuestionTypeForm chooseQuestionTypeForm = new ChooseQuestionTypeForm();
            chooseQuestionTypeForm.ShowDialog();
            CurrentQuestion = new Question(chooseQuestionTypeForm.SelectedType);
            LoadQuestion(CurrentQuestion);
        }

        private void LoadTest(Test test)
        {
            CurrentTest = test;
            statusSelectedTestLabel.Text = "Current test: " + test.Name;
            statusQuestionsCountLabel.Text = "Questions number: " + test.Questions.Count.ToString();
            statusSelectedQuestionTypeLabel.Text = "Question type: None";
            StatusSelectedQuestionLabel.Text = "Question: None";
            if (test.Questions.Count > 0)
                LoadQuestion(test.Questions[0]);

            addQuestionButton.Enabled = true;
            removeQuestionButton.Enabled = true;
            editQuestionButton.Enabled = true;

            addOptionButton.Enabled = false;
            removeOptionButton.Enabled = false;
            saveQuestionButton.Enabled = false;
            cancelQuestionButton.Enabled = false;
            questionTextBox.Enabled = false;

            questionsListBox.Items.Clear();
            foreach (Question question in test.Questions)
            {
                questionsListBox.Items.Add(question.QuestionText);
            }
            if (questionsListBox.Items.Count > 0)
                questionsListBox.SelectedIndex = 0;
        }

        private void LoadQuestion(Question question)
        {
            answersSplitContainer.Panel1.Controls.Clear();

            switch (question.Type)
            {
                case "Single choice":
                    for (int i = 0; i < question.Options.Count; i++)
                    {
                        RadioButton option = new RadioButton();
                        option.Name = "radioButton";
                        TextBox optionText = new TextBox();
                        optionText.Name = "optionText";
                        optionText.Text = question.Options[i];
                        option.Left = 10;
                        option.Top = i * 30 + 5;
                        option.Width = 30;
                        optionText.Top = option.Top;
                        optionText.Left = option.Left + 60;
                        optionText.Width = 150;
                        if (question.RightAnswers[i] == "True")
                            option.Checked = true;
                        answersSplitContainer.Panel1.Controls.Add(option);
                        answersSplitContainer.Panel1.Controls.Add(optionText);
                    }
                    break;
                case "Multiple choice":
                    for (int i = 0; i < question.Options.Count; i++)
                    {
                        CheckBox option = new CheckBox();
                        option.Name = "checkBox";
                        TextBox optionText = new TextBox();
                        optionText.Name = "optionText";
                        optionText.Text = question.Options[i];
                        option.Left = 10;
                        option.Top = i * 30 + 5;
                        option.Width = 30;
                        optionText.Width = 150;
                        optionText.Top = option.Top;
                        optionText.Left = option.Left + 40;
                        if (question.RightAnswers[i] == "True")
                            option.Checked = true;
                        answersSplitContainer.Panel1.Controls.Add(option);
                        answersSplitContainer.Panel1.Controls.Add(optionText);
                    }
                    break;
                case "Enter word":
                    TextBox answerBox = new TextBox();
                    answerBox.Name = "answerBox";
                    answerBox.Text = "Your answer here";
                    answerBox.Left = 10;
                    answerBox.Top = 20;
                    answerBox.Width += 40;

                    if (question.RightAnswers.Count > 0)
                        answerBox.Text = question.RightAnswers[0];

                    answersSplitContainer.Panel1.Controls.Add(answerBox);

                    break;
            }
            StatusSelectedQuestionLabel.Text = "Question: " + (CurrentTest.Questions.IndexOf(question) + 1);
            statusSelectedQuestionTypeLabel.Text = "Question type: " + question.Type;
            statusQuestionsCountLabel.Text = "Questions number: " + CurrentTest.Questions.Count;

            CurrentQuestionNum = CurrentTest.Questions.IndexOf(question);
            CurrentQuestion = question;
            questionTextBox.Text = question.QuestionText == "" ? "Enter question text here" : question.QuestionText;

            addOptionButton.Enabled = true;
            removeOptionButton.Enabled = true;
            saveQuestionButton.Enabled = true;
            cancelQuestionButton.Enabled = true;
            questionTextBox.Enabled = true;

        }

        private void addOptionButton_Click(object sender, EventArgs e)
        {
            CurrentQuestion.Options.Add("New option");
            CurrentQuestion.RightAnswers.Add("false");
            LoadQuestion(CurrentQuestion);
            SaveCurrentQuestion();
        }

        private void SaveCurrentQuestion()
        {
            CurrentQuestion.Options.Clear();
            CurrentQuestion.RightAnswers.Clear();
            switch (CurrentQuestion.Type)
            {
                case "Single choice":
                    Control[] radioButtons = answersSplitContainer.Panel1.Controls.Find("radioButton", false);
                    Control[] textBoxes = answersSplitContainer.Panel1.Controls.Find("optionText", false);
                    for (int i = 0; i < radioButtons.Length; i++)
                    {
                        CurrentQuestion.Options.Add(textBoxes[i].Text);
                        CurrentQuestion.RightAnswers.Add(((RadioButton)radioButtons[i]).Checked.ToString());
                    }
                    break;
                case "Multiple choice":
                    Control[] checkBoxes = answersSplitContainer.Panel1.Controls.Find("checkBox", false);
                    Control[] answers = answersSplitContainer.Panel1.Controls.Find("optionText", false);
                    for (int i = 0; i < checkBoxes.Length; i++)
                    {
                        CurrentQuestion.Options.Add(answers[i].Text);
                        CurrentQuestion.RightAnswers.Add(((CheckBox)checkBoxes[i]).Checked.ToString());
                    }
                    break;
                case "Enter word":
                    TextBox option = (answersSplitContainer.Panel1.Controls[0] as TextBox);
                    CurrentQuestion.Options.Add(option.Text);
                    CurrentQuestion.RightAnswers.Add(option.Text);
                    break;
            }

            CurrentQuestion.QuestionText = questionTextBox.Text;
        }

        private void saveQuestionButton_Click(object sender, EventArgs e)
        {
            SaveCurrentQuestion();
            CurrentTest.Questions.Add(CurrentQuestion);
            questionsListBox.Items.Add(CurrentQuestion.QuestionText);
        }

        private void questionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (questionsListBox.SelectedIndex >= 0)
                LoadQuestion(CurrentTest.Questions[questionsListBox.SelectedIndex]);
        }

        private void questionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CurrentQuestion != null)
                CurrentQuestion.QuestionText = questionTextBox.Text;
        }

        private void saveTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentTestName == "None")
            {
                if (MessageBox.Show("You must rename your test first. Do it now?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    renameTestToolStripMenuItem_Click(null, null);
                else
                    return;
            }

            SqlConnection connection = teachersTableAdapter.Connection;
            connection.Open();
            try
            {
                string tableName = CurrentTestName + "_" + TeacherCreatorID;
                SqlCommand cmd = new SqlCommand("CREATE TABLE " + tableName + " (" +
                    "[ID_Question] int identity(0,1) not null primary key," +
                    "[Text_Question] nvarchar(100) not null," +
                    "[Type_Question] nvarchar(20) not null," +
                    "[Answers] nvarchar(200) not null)", connection);
                cmd.ExecuteNonQuery();

                foreach (Question question in CurrentTest.Questions)
                {
                    cmd.CommandText = $"INSERT INTO {tableName} ([Text_Question], [Type_Question], [Answers]) " +
                        $"VALUES('{question.QuestionText}', '{question.Type}', '{question.AnswersToString()}')";
                    cmd.ExecuteNonQuery();
                }

                TestsTableAdapter.Insert(CurrentTest.CreatorsID, CurrentTest.Name, DateTime.Now, CurrentTest.Comment);

                MessageBox.Show("Test successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error has occured. Details:\n" + ex.Message);
                //if (MessageBox.Show("A test with the same name is already exists. Rename it now? or " + ex.Message, "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                //{
                //    renameTestToolStripMenuItem_Click(null, null);
                //}
            }
            connection.Close();

        }

        private void renameTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTestNameForm testNameForm = new NewTestNameForm(this);
            testNameForm.ShowDialog();
        }

        private void openTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTestForm openTestForm = new OpenTestForm(this);
            openTestForm.Show();
        }

        public void DownloadTest(string testName)
        {
            SqlConnection connection = teachersTableAdapter.Connection;
            connection.Open();

            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM " + testName, connection);
            DataTable testTable = new DataTable();
            ad.Fill(testTable);

            Test newTest = new Test(Convert.ToInt32(testName.Substring(testName.IndexOf('_') + 1)), testName.Substring(0, testName.IndexOf('_')));
            foreach (DataRow questionRow in testTable.Rows)
            {
                Question question = new Question(questionRow["Type_Question"].ToString());
                question.QuestionText = questionRow["Text_Question"].ToString();
                question.StringToAnswers(questionRow["Answers"].ToString());
                newTest.Questions.Add(question);
            }

            connection.Close();
            LoadTest(newTest);
        }

        private void testCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCommentForm editCommentForm = new EditCommentForm(this);
            editCommentForm.ShowDialog();
        }
    }
}
