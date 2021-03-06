using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Calculate()
        {
            
        }

        bool Verify()
        {
            char[] SplitString = OutputBox.Text.ToCharArray();
            int LeftBrak = 0;
            int RightBrak = 0;
            int RightCheck = 0;
            for (int i = (OutputBox.Text.Length-1); i > 0; i--)
            {
                if (SplitString[i] == '(')
                {
                    LeftBrak++;
                    for (int x = i; x < OutputBox.Text.Length; x++)
                    {
                        if (SplitString[x] == ')')
                        {
                            RightBrak++;
                            break;
                        }
                    }
                }
            }
            for (int i = 0; 1 < OutputBox.Text.Length; 1++)
            {
                if (SplitString[i] == ')')
                {
                    RightCheck++;
                }
            }
            if (LeftBrak != RightBrak || RightCheck != RightBrak)
            {
                MessageBox.Show("Incorrect anount of brackets", "Error");
                return false;
            }
            return true;
        }

        private void Root_Click(object sender, EventArgs e){ OutputBox.AppendText("√"); }
        private void Divide_Click(object sender, EventArgs e){ OutputBox.AppendText("/"); }
        private void Multiply_Click(object sender, EventArgs e){ OutputBox.AppendText("*"); }
        private void Add_Click(object sender, EventArgs e){ OutputBox.AppendText("+"); }
        private void Minus_Click(object sender, EventArgs e){ OutputBox.AppendText("-"); }
        private void Delete_Click(object sender, EventArgs e){ if (OutputBox.Text.Length > 0) { OutputBox.Text = OutputBox.Text.Substring(0, OutputBox.Text.Length - 1); } }
        private void Equals_Click(object sender, EventArgs e) { if (Verify() == true) { Calculate(); } }
        private void Three_Click(object sender, EventArgs e){ OutputBox.AppendText("3"); }
        private void Six_Click(object sender, EventArgs e){ OutputBox.AppendText("6"); }
        private void Nine_Click(object sender, EventArgs e){ OutputBox.AppendText("9"); }
        private void Clear_Click(object sender, EventArgs e){ OutputBox.Text = ""; }
        private void Zero_Click(object sender, EventArgs e){ OutputBox.AppendText("0"); }
        private void Two_Click(object sender, EventArgs e){ OutputBox.AppendText("2"); }
        private void Five_Click(object sender, EventArgs e){ OutputBox.AppendText("5"); }
        private void Eight_Click(object sender, EventArgs e){ OutputBox.AppendText("8"); }
        private void Power_Click(object sender, EventArgs e){ OutputBox.AppendText("^"); }
        private void Point_Click(object sender, EventArgs e){ OutputBox.AppendText("."); }
        private void One_Click(object sender, EventArgs e){ OutputBox.AppendText("1"); }
        private void Four_Click(object sender, EventArgs e){ OutputBox.AppendText("4"); }
        private void Seven_Click(object sender, EventArgs e){ OutputBox.AppendText("7"); }
        private void Factorial_Click(object sender, EventArgs e){ OutputBox.AppendText("!"); }
        private void Log_Click(object sender, EventArgs e){ OutputBox.AppendText("Log("); }
        private void LogE_Click(object sender, EventArgs e){ OutputBox.AppendText("ln("); }
        private void Random_Click(object sender, EventArgs e){ OutputBox.AppendText("Ran("); }
        private void RBracket_Click(object sender, EventArgs e){ OutputBox.AppendText(")"); }
        private void LBracket_Click(object sender, EventArgs e){ OutputBox.AppendText("("); }
        private void Pi_Click(object sender, EventArgs e){ OutputBox.AppendText("π"); }
        private void Sin_Click(object sender, EventArgs e){ OutputBox.AppendText("Sin("); }
        private void Cos_Click(object sender, EventArgs e){ OutputBox.AppendText("Cos("); }
        private void Tan_Click(object sender, EventArgs e){ OutputBox.AppendText("Tan("); }
    }
}
