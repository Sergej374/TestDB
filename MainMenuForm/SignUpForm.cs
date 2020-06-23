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
    public partial class SignUpForm : Form
    {
        private AuthorizationForm parent;
        private Bitmap captchaImage;
        private string captchaString;
        private Random randomizer = new Random();

        public SignUpForm(AuthorizationForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            UpdateCaptcha();
        }

        private void UpdateCaptcha()
        {
            string captcha = "";
            for (int i = 0; i < 7; i++)
            {
                captcha += char.ConvertFromUtf32(randomizer.Next(64, 122));
            }
            captchaString = captcha;
            captchaImage = new Bitmap(captchaBox.Width, captchaBox.Height);
            Graphics drawer = Graphics.FromImage(captchaImage);
            drawer.Clear(Color.FromArgb(randomizer.Next(1, 255), randomizer.Next(1, 255), randomizer.Next(1, 255)));
            drawer.DrawString(captcha, new Font(FontFamily.GenericMonospace, 25), new Pen(Color.FromArgb(randomizer.Next(1, 255), randomizer.Next(1, 255), randomizer.Next(1, 255))).Brush, 0, 0);

            captchaBox.Invalidate();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = !showPasswordCheckBox.Checked;
        }

        private void captchaBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(captchaImage, 0, 0);
        }

        private void updateCaptchaButton_Click(object sender, EventArgs e)
        {
            UpdateCaptcha();
        }

        private void captchaEnterBox_Click(object sender, EventArgs e)
        {
            captchaEnterBox.BackColor = SystemColors.Window;
            if (captchaLabel.Text == "Failed captcha")
                captchaLabel.Text = "Enter symbols from the picture";
        }

        private void repPasswordBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordBox.Text != repPasswordBox.Text)
            {
                passwordMatchLabel.Text = "Passwords don't match!";
                passwordMatchLabel.ForeColor = Color.Red;
            }
            else if (passwordBox.Text != string.Empty)
            {
                passwordMatchLabel.Text = "Alright";
                passwordMatchLabel.ForeColor = Color.Green;
            }
            else
            {
                passwordMatchLabel.Text = "Repeat password";
                passwordMatchLabel.ForeColor = Color.Black;
            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == string.Empty || realNameBox.Text == string.Empty || passwordBox.Text == string.Empty)
            {
                MessageBox.Show("Fill all the fields first!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (passwordMatchLabel.ForeColor != Color.Green)
            {
                MessageBox.Show("Passwords don't match", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passwordMatchLabel.Text = "Passwords don't match!";
                passwordMatchLabel.ForeColor = Color.Red;
                passwordMatchLabel.Select();
                return;
            }

            if (captchaEnterBox.Text != captchaString)
            {
                captchaEnterBox.BackColor = Color.IndianRed;
                captchaLabel.Text = "Failed captcha";
                captchaEnterBox.Text = string.Empty;
                UpdateCaptcha();
                MessageBox.Show("Failed captcha", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (parent.adapter.GetData().Select("Login = '" + usernameBox.Text + "'").Length != 0)
            {
                MessageBox.Show("This username is already taken!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            parent.adapter.Insert(usernameBox.Text, passwordBox.Text, realNameBox.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
