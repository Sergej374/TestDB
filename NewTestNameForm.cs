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
    public partial class NewTestNameForm : Form
    {
        TeacherPanelForm parent;

        public NewTestNameForm(TeacherPanelForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            switch (testNameBox.Text)
            {
                case "":
                    MessageBox.Show("Enter the test's name!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "None":
                    MessageBox.Show("This name is reserved, please choose another one.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    testNameBox.Text = "";
                    break;
                default:
                    parent.CurrentTestName = testNameBox.Text;
                    DialogResult = DialogResult.OK;
                    Close();
                    break;
            }
        }
    }
}
