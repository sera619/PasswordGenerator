using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class mainUI : Form
    {
        private int passwordLength = 0;
        private string symbols= "!§$%&=?@";
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
            return res.ToString();
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void mainUI_Load(object sender, EventArgs e)
        {
            errorMsgLabel.Text = "";
        }

        private void infoText_Click(object sender, EventArgs e)
        {

        }

        private void generateBTN_Click(object sender, EventArgs e)
        {
            if(passwordLength == 0)
            {
                errorMessage("Passwortlänge darf nicht 0 sein. Bitte wähle die Länge des Passworts!");
            }
            passwordText.Text = CreatePassword(passwordLength);
        }

        private void passwordText_Click(object sender, EventArgs e)
        {

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
            passwordLength = (int) lengthedit.Value;
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
            if(checkboxSymbol.Checked == true)
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
    }
}
