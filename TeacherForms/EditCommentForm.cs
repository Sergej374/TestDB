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
    public partial class EditCommentForm : Form
    {
        private TeacherPanelForm parent;

        public EditCommentForm(TeacherPanelForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            commentBox.Text = parent.CurrentTest.Comment;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            parent.CurrentTest.Comment = commentBox.Text;
        }
    }
}
