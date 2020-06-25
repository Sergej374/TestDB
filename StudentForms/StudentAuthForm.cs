using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTestsDB.StudentForms
{
    public partial class StudentAuthForm : Form
    {
        private DataTable groupsTable { get; }
        private DataTable studentsTable { get; set; }
        private MainMenuForm parent { get; set; }

        public StudentAuthForm(MainMenuForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            groupsTable = groupsTableAdapter.GetData();
            studentsTable = studentsTableAdapter.GetData();

            foreach (DataRow group in groupsTable.Rows)
            {
                groupsBox.Items.Add(group["GroupNumber"]);
            }

            if (groupsBox.Items.Count > 0)
                groupsBox.SelectedIndex = 0;
        }

        private void groupsBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            if (fullNameBox.Text == "")
            {
                MessageBox.Show("Enter your full name!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                fullNameBox.Select();
                return;
            }

            string studentName = fullNameBox.Text;
            int idGroup = Convert.ToInt32(groupsTable.Select("GroupNumber = " + groupsBox.Text)[0]["ID_Group"]);

            DataRow[] foundStudents = studentsTableAdapter.GetData().Select($"Name_student = '{studentName}' AND ID_group = {idGroup}");

            if (foundStudents.Length > 0)
            {
                int studentID = Convert.ToInt32(foundStudents[0]["ID_student"]);
                ChooseTestForPassingForm chooseTestForm = new ChooseTestForPassingForm(parent, studentID, studentName);
                Close();
                parent.Hide();
                chooseTestForm.Show();
            }
            else
            {
                if (MessageBox.Show("Such user does not exit. Create one?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    studentsTableAdapter.Insert(studentName, idGroup);
                    DataRow[] foundStudent = studentsTableAdapter.GetData().Select($"Name_student = '{studentName}' AND ID_group = {idGroup}");
                    int studentID = Convert.ToInt32(foundStudent[0]["ID_student"]);
                    ChooseTestForPassingForm testForPassingForm = new ChooseTestForPassingForm(parent, studentID, studentName);
                    Close();
                    testForPassingForm.Show();
                    testForPassingForm.Select();
                }
            }
        }

        private void fullNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == 32 || e.KeyChar == 190))
                e.Handled = true;
        }
    }
}
