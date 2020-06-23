using MyTestsDB.StudentForms;
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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void testsButton_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void attemptButton_Click(object sender, EventArgs e)
        {
            StudentAuthForm studentAuthForm = new StudentAuthForm(this);
            studentAuthForm.ShowDialog();
        }
    }
}
