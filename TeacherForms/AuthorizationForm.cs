using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTestsDB
{
    public partial class AuthorizationForm : Form
    {
        public MyTestsDataSetTableAdapters.TeachersTableAdapter adapter;

        public AuthorizationForm()
        {
            InitializeComponent();
            adapter = new MyTestsDataSetTableAdapters.TeachersTableAdapter();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {

        }

        private void showPasswdBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = !showPasswdBox.Checked;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm(this);
            if(signUpForm.ShowDialog() == DialogResult.OK)
            {
                usernameBox.Text = (string)adapter.GetData()[adapter.GetData().Count - 1]["Login"];
                passwordBox.Text = (string)adapter.GetData()[adapter.GetData().Count - 1]["Password"];
                signInButton_Click(null, null);
            }
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            MyTestsDataSet.TeachersDataTable teachersRows = adapter.GetData();
            foreach(var row in teachersRows)
            {
                if(row["Login"].ToString() == usernameBox.Text && row["Password"].ToString() == passwordBox.Text)
                {
                    TeacherPanelForm teacherPanelForm = new TeacherPanelForm(Convert.ToInt32(row["ID_teacher"]));
                    Close();
                    teacherPanelForm.Show();
                    return;
                }
            }

            if(MessageBox.Show("Such user is not registered. Start registration?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SignUpForm signUpForm = new SignUpForm(this);
                signUpForm.usernameBox.Text = usernameBox.Text;
                if (signUpForm.ShowDialog() == DialogResult.OK)
                {
                    usernameBox.Text = (string)adapter.GetData()[adapter.GetData().Count - 1]["Login"];
                    passwordBox.Text = (string)adapter.GetData()[adapter.GetData().Count - 1]["Password"];
                    signInButton_Click(null, null);
                }
            }
        }
    }
}
