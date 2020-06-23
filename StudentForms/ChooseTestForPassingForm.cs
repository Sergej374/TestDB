using MyTestsDB.StudentForms;
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

namespace MyTestsDB
{
    public partial class ChooseTestForPassingForm : Form
    {
        private MainMenuForm MainMenuForm { get; set; }
        public int StudentID { get; private set; }
        public string StudentName { get; private set; }

        public ChooseTestForPassingForm(MainMenuForm mainMenuForm, int studentID, string studentName)
        {
            InitializeComponent();
            MainMenuForm = mainMenuForm;
            StudentID = studentID;
            StudentName = studentName;
        }

        private void ChooseTestForPassingForm_Load(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(groupsTableAdapter1.Connection.ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT Tests.Name_test as TestName, Teachers.Name_teacher as CreatorName," +
                " Tests.ID_teacher as CreatorID, Tests.Date_created as CreationDate FROM Tests INNER JOIN Teachers ON " +
                "Tests.ID_teacher = Teachers.ID_teacher ORDER BY Teachers.Name_teacher, Tests.Date_created", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow test = table.Rows[i];
                Button button = new Button();
                button.Left = 6;
                button.Top = i * (button.Height + 4) + 6;
                button.Text = test["TestName"].ToString() ;
                button.Name = test["TestName"] + "_" + test["CreatorID"];
                button.Click += OpenTest;
                Label label = new Label();
                label.AutoSize = true;
                label.Top = button.Top + button.Height / 3;
                label.Left = button.Right + 5;
                label.Text = "By " + test["CreatorName"].ToString() + " from " + test["CreationDate"].ToString();
                testButtonsPanel.Controls.Add(button);
                testButtonsPanel.Controls.Add(label);
            }

            if (testButtonsPanel.Controls.Count > 0)
            {
                Button cancelButton = new Button();
                cancelButton.Top = testButtonsPanel.Controls[testButtonsPanel.Controls.Count - 1].Top + cancelButton.Height + 16;
                cancelButton.Left = testButtonsPanel.Right - cancelButton.Width - 5;
                cancelButton.Click += cancelButton_Click;
                cancelButton.Text = "Cancel";
                testButtonsPanel.Controls.Add(cancelButton);
            }
            else
            {
                MessageBox.Show("There's no tests available yet!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cancelButton_Click(null, null);
            }

        }

        private void OpenTest(object sender, EventArgs e)
        {
            PassTestForm passTestForm = new PassTestForm(StudentName, StudentID, MainMenuForm, (sender as Button).Name);
            Close();
            passTestForm.Show();
            passTestForm.Select();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
            MainMenuForm.Show();
        }

    }
}
