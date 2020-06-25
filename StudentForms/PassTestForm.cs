using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTestsDB.StudentForms
{
    public partial class PassTestForm : Form
    {
        private Question currentQuestion;

        public string StudentName { get; set; }
        public int StudentID { get; }
        public int TestID { get; }
        public Test Test { get; set; }
        public Question CurrentQuestion
        {
            get => currentQuestion;
            set
            {
                currentQuestion = value;
                CurrentQuestionID = Test.Questions.IndexOf(value);
                testProgressBar.Value = CurrentQuestionID;
                questionsCountLabel.Text = "Question " + Test.Questions.IndexOf(currentQuestion) + " from " + Test.Questions.Count;
            }
        }
        public int Result { get; private set; }
        private MainMenuForm mainMenu { get; }
        public string[][] Answers { get; set; }
        private int CurrentQuestionID { get; set; }

        public PassTestForm(string sName, int sID, MainMenuForm mainMenu, string testName, int testID)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
            StudentName = sName;
            StudentID = sID;
            TestID = testID;
            LoadTest(testName);
            Text = "Logged in as: " + sName + ", ID: " + sID + ", Test: " + Test.Name;
            testProgressBar.Minimum = 0;
            testProgressBar.Maximum = Test.Questions.Count - 1;
        }

        private void LoadQuestion(Question question)
        {
            if (CurrentQuestion != null)
                SaveAnswer();

            splitContainer2.Panel1.Controls.Clear();
            questionTextBox.Text = question.QuestionText;

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
                        optionText.ReadOnly = true;

                        if (Answers[Test.Questions.IndexOf(question)] != null && Answers[Test.Questions.IndexOf(question)][i] == "True")
                            option.Checked = true;

                        splitContainer2.Panel1.Controls.Add(option);
                        splitContainer2.Panel1.Controls.Add(optionText);
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
                        optionText.ReadOnly = true;

                        if (Answers[Test.Questions.IndexOf(question)] != null && Answers[Test.Questions.IndexOf(question)][i] == "True")
                            option.Checked = true;

                        splitContainer2.Panel1.Controls.Add(option);
                        splitContainer2.Panel1.Controls.Add(optionText);
                    }
                    break;
                case "Enter word":
                    TextBox answerBox = new TextBox();
                    answerBox.Left = 10;
                    answerBox.Top = 35;
                    answerBox.Width = 150;

                    if (Answers[Test.Questions.IndexOf(question)] != null)
                        answerBox.Text = Answers[Test.Questions.IndexOf(question)][0];
                    splitContainer2.Panel1.Controls.Add(answerBox);
                    break;
                case "Matching":
                    Random rnd = new Random();
                    for (int i = 0; i < question.Options.Count; i++)
                    {
                        Label optionMatchText = new Label();
                        optionMatchText.Top = i * 30 + 5;
                        optionMatchText.Left = 10;
                        optionMatchText.Width = 50;
                        optionMatchText.Text = question.Options[i];
                        optionMatchText.Name = "optionMatchText";
                        ComboBox answersBox = new ComboBox();
                        answersBox.Top = optionMatchText.Top;
                        answersBox.Left = optionMatchText.Right + 40;
                        answersBox.Name = "answerMatch";

                        List<string> itemsBunch = new List<string>();
                        itemsBunch.AddRange(question.RightAnswers.ToArray());
                        string[] items = new string[question.RightAnswers.Count];

                        for(int j = itemsBunch.Count - 1; j >= 0; j--)
                        {
                            string opt = itemsBunch[rnd.Next(itemsBunch.Count)];
                            itemsBunch.Remove(opt);
                            items[j] = opt;
                        }

                        answersBox.Items.AddRange(items);

                        splitContainer2.Panel1.Controls.Add(optionMatchText);
                        splitContainer2.Panel1.Controls.Add(answersBox);
                    }
                    break;
            }
            CurrentQuestion = question;
        }

        private void SaveAnswer()
        {
            switch (currentQuestion.Type)
            {
                case "Single choice":
                    Control[] radioButtons = splitContainer2.Panel1.Controls.Find("radioButton", false);
                    Answers[CurrentQuestionID] = new string[radioButtons.Length];
                    for (int i = 0; i < radioButtons.Length; i++)
                    {
                        Answers[CurrentQuestionID][i] = (radioButtons[i] as RadioButton).Checked.ToString();
                    }
                    break;
                case "Multiple choice":
                    Control[] checkBoxes = splitContainer2.Panel1.Controls.Find("checkBox", false);
                    Answers[CurrentQuestionID] = new string[checkBoxes.Length];
                    for (int i = 0; i < checkBoxes.Length; i++)
                    {
                        Answers[CurrentQuestionID][i] = (checkBoxes[i] as CheckBox).Checked.ToString();
                    }
                    break;
                case "Enter word":
                    string answer = (splitContainer2.Panel1.Controls[0] as TextBox).Text;
                    Answers[CurrentQuestionID] = new string[1];
                    Answers[CurrentQuestionID][0] = answer;
                    break;
                case "Matching":
                    Control[] matchedAnswers = splitContainer2.Panel1.Controls.Find("answerMatch", false);
                    Answers[CurrentQuestionID] = new string[matchedAnswers.Length];
                    for(int i = 0; i < matchedAnswers.Length; i++)
                    {
                        Answers[CurrentQuestionID][i] = matchedAnswers[i].Text;
                    }
                    break;
            }
        }

        private void LoadTest(string testName)
        {
            SqlConnection connection = teachersTableAdapter.Connection;
            connection.Open();

            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM " + testName, connection);
            DataTable testTable = new DataTable();
            ad.Fill(testTable);

            Test neededTest = new Test(Convert.ToInt32(testName.Substring(testName.IndexOf("_") + 1)), testName.Substring(0, testName.IndexOf("_")));
            foreach (DataRow questionRow in testTable.Rows)
            {
                Question question = new Question(questionRow["Type_Question"].ToString());
                question.QuestionText = questionRow["Text_Question"].ToString();
                question.StringToAnswers(questionRow["Answers"].ToString());
                neededTest.Questions.Add(question);
            }

            connection.Close();
            Test = neededTest;
            Answers = new string[Test.Questions.Count][];

            LoadQuestion(Test.Questions[0]);
        }

        private void PassTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenu.Show();
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            if (CurrentQuestionID >= Test.Questions.Count - 1)
                return;

            LoadQuestion(Test.Questions[CurrentQuestionID + 1]);
        }

        private void endTestButton_Click(object sender, EventArgs e)
        {
            SaveAnswer();

            int accuracy = Test.MeasureAccuracy(Answers);

            string grade = "F";
            if (accuracy >= 50)
                grade = "D";
            if (accuracy >= 58)
                grade = "C";
            if (accuracy >= 69)
                grade = "B";
            if (accuracy >= 81)
                grade = "A";

            resultsTableAdapter.Insert(StudentID, TestID, DateTime.Today, grade);
            MessageBox.Show(accuracy + "% of right answers. Your grade is " + grade);
            Close();
        }

        private void preQuestionButton_Click(object sender, EventArgs e)
        {
            if (CurrentQuestionID > 0)
            {
                LoadQuestion(Test.Questions[CurrentQuestionID - 1]);

            }
        }
    }
}
