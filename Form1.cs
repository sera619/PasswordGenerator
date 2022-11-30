using System;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class mainUI : Form
    {
        private int passwordLength = 0;
        private string symbols = "!§$%&=?@";
        private string numbers = "0123456789";
        private bool allowNums = false;
        private bool allowSymbols = false;

        public mainUI()
        {
            InitializeComponent();
        }

        public string CreatePassword(int length)
        {
            string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (allowSymbols == true)
            {
                valid += symbols;
            }
            if (allowNums == true)
            {
                valid += numbers;
            }
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            CopyButton.Enabled = true;
            CopyButton.Visible = true;
            return res.ToString();
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void mainUI_Load(object sender, EventArgs e)
        {
            errorMessage("");
            CopyButton.Enabled = false;
            CopyButton.Visible = false;

        }

        private void infoText_Click(object sender, EventArgs e)
        {

        }

        private void generateBTN_Click(object sender, EventArgs e)
        {
            if (passwordLength == 0)
            {
                errorMessage("Passwortlänge darf nicht 0 sein. Bitte wähle die Länge des Passworts!");
                return;
            }
            passwordText.Text = CreatePassword(passwordLength);

        }


        private void errorMessage(string msg)
        {
            errorMsgLabel.Text = msg;
        }

        private void lengthedit_ValueChanged(object sender, EventArgs e)
        {
            if (errorMsgLabel.Text != "")
            {
                errorMsgLabel.Text = "";
            }
            passwordLength = (int)lengthedit.Value;
        }

        private void checkboxNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxNumber.Checked == true)
            {
                allowNums = true;
            }
            else
            {
                allowNums = false;
            }

        }

        private void checkboxSymbol_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxSymbol.Checked == true)
            {
                allowSymbols = true;
            }
            else
            {
                allowSymbols = false;
            }
        }

        private void moreButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.github.com/sera619");
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passwordText.Text);
        }
    }
}
