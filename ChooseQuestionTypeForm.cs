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
    public partial class ChooseQuestionTypeForm : Form
    {
        public string SelectedType { get; set; }

        public ChooseQuestionTypeForm()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            foreach(RadioButton radioButton in choicesPanel.Controls)
            {
                if (radioButton.Checked)
                {
                    SelectedType = radioButton.Text;
                    Close();
                    return;
                }
            }
        }
    }
}
