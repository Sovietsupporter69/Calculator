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
            InitializeComponent(); //USE Sin(41+(9*Log(72)*(62-(6/871))) AS A TEST
        }

        void Calcualte()
        {
            String Input = OutputBox.Text; //Changeing the input into an array of strings in the calculation order
            char[] SplitInput = Input.ToCharArray(); //split the string into individual characters
            int Priority = 0;
            int Sum = 0;
            string Holder = "";
            int[] Hold = new int[SplitInput.Length];
            List<string> CalcOrder = new List<string>();
            for (int i = 0; i < SplitInput.Length; i++)
            {
                if (SplitInput[i] == '(') //searches the character array for a left bracket
                {
                    Priority++; //Makes the priority higher
                    Hold[i] = Priority; //and asigns that to the bracket in the hold array
                }
                else if (SplitInput[i] == ')') //then once it finds the corresponding right bracket
                {
                    for (int x = (Hold.Length-1); x >= 0; x++) 
                    {
                        if (Hold[x] == Priority) //it searches backwards in the priority list
                        {
                            string temp = "";
                            for (int y = (x+1); y < i; y++) //and grabs the length of characters that fit the priority
                            {
                                temp = temp + SplitInput[y]; //turns them back into a string
                                SplitInput[y] = '$';
                            }
                            int RunCount = int.Parse(Sum/26); //Sets the amount of Letter grabs so that every placeholder will have a unique link
                            Sum = Sum%26 //getting the number needed to find the letter for link
                            for (int d = 0; d < RunCount; d++) //Finds as many numbers as RunCount sets
                            {
                                switch (Sum) //getting the correct link
                                {
                                    case 1: Holder++"A";
                                    case 2: Holder++"B";
                                    case 3: Holder++"C";
                                    case 4: Holder++"D";
                                    case 5: Holder++"E";
                                    case 6: Holder++"F";
                                    case 7: Holder++"G";
                                    case 8: Holder++"H";
                                    case 9: Holder++"I";
                                    case 10: Holder++"J";
                                    case 11: Holder++"K";
                                    case 12: Holder++"L";
                                    case 13: Holder++"M";
                                    case 14: Holder++"N";
                                    case 15: Holder++"O";
                                    case 16: Holder++"P";
                                    case 17: Holder++"Q";
                                    case 18: Holder++"R";
                                    case 19: Holder++"S";
                                    case 20: Holder++"T";
                                    case 21: Holder++"U";
                                    case 22: Holder++"V";
                                    case 23: Holder++"W";
                                    case 24: Holder++"X";
                                    case 25: Holder++"Y";
                                    case 26: Holder++"Z";
                                }
                            }
                            CalcOrder.Append(temp); //adds the placeholder to the output string so it can be used later
                            SplitInput[i] = '$'; //replace the last bracket
                            for (int d = 0; d < (); d++)
                            {
                                SplitInput[x+d] = Holder; //asigns the placeholder to the char array
                                //does this by asigning the placeholder one letter at a time as the array is char so can only accept one letter
                            }
                        }
                    }
                }
            }
        }

        bool Verify()
        {
            char[] Hold = OutputBox.Text.ToCharArray(); //spliting the string into an array of characters so its easier to search through
            List<char> SplitString = new List<char>();
            for (int f = 0; f < Hold.Length; f++) //converting the array to a list for removal of elements later
            {
                SplitString.Append(Hold[f]);
            }
            int LeftBrak = 0;
            int RightBrak = 0;
            int RightCheck = 0;
            for (int i = (SplitString.Count - 1); i >= 0; i--)
            {
                if (SplitString[i] == '(') //searching, in reverse order, through the array list for a left bracket
                {
                    LeftBrak++;
                    for (int x = i; x < SplitString.Count; x++)
                    {
                        if (SplitString[x] == ')') //searching, in normal order, from the location of the found left bracket, to find a corresponding right bracket
                        {
                            RightBrak++;
                            SplitString.RemoveAt(x); //removing the bracket so it doesn't get found again
                            break;
                        }
                    }
                }
            }
            for (int i = 0; i < SplitString.Count; i++)
            {
                if (SplitString[i] == ')') //calcualting the acctual ammount of right brackets incase there is a right on its own
                {
                    RightCheck++;
                }
            }
            if (LeftBrak != RightBrak || RightCheck != RightBrak) //checks to see if the backet totals are equal and to see if there are no spare right brackets
            {
                MessageBox.Show("Incorrect anount of brackets", "Error"); //shows the user an error box if the brackets aren't right
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
