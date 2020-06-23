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
        public string StudentName { get; set; }
        public int StudentID { get; }
        public Test Test { get; set; }
        public Question CurrentQuestion { get; set; } 
        public int Result { get; private set; }
        private MainMenuForm mainMenu { get; }
        public string[][] Answers { get; set; }

        public PassTestForm(string sName, int sID, MainMenuForm mainMenu, string testName)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
            StudentName = sName;
            StudentID = sID;
            LoadTest(testName);
            Text = "Logged in as: " + sName + ", ID: " + sID + ", Test: " + Test.Name;

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
            }
        }

        private void SaveAnswer()
        {

        }

        private void LoadTest(string testName)
        {
            SqlConnection connection = teachersTableAdapter.Connection;
            connection.Open();

            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM " + testName, connection);
            DataTable testTable = new DataTable();
            ad.Fill(testTable);

            Test neededTest = new Test(Convert.ToInt32(testName.Substring(testName.IndexOf('_') + 1)), testName.Substring(0, testName.IndexOf('_')));
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
    }
}
