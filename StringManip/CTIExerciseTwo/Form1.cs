using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace CTIExerciseTwo
{
    public partial class Form1 : Form
    {
        ArrayList characters = new ArrayList();
        ArrayList integers = new ArrayList();
        string originalValue;

        public Form1()
        {
            InitializeComponent();
            lblPassWord.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnChar_Click(object sender, EventArgs e)
        {
            int randomnumber;
            int UpperRandomNumber; 

            Random number = new Random();
            randomnumber = number.Next(1, 26);
            UpperRandomNumber = number.Next(1, 3);

            if (randomnumber == 1)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "a";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "A";
                }
            }
            else if (randomnumber == 2)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "b";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "B";
                }
            }
            else if (randomnumber == 3)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "c";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "C";
                }
            }
            else if (randomnumber == 4)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "d";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "D";
                }
            }
            else if (randomnumber == 5)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "e";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "E";
                }
            }
            else if (randomnumber == 6)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "f";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "F";
                }
            }
            else if (randomnumber == 7)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "g";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "G";
                }
            }
            else if (randomnumber == 8)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "h";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "H";
                }
            }
            else if (randomnumber == 9)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "i";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "I";
                }
            }
            else if (randomnumber == 10)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "j";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "J";
                }
            }
            else if (randomnumber == 11)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "k";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "K";
                }
            }
            else if (randomnumber == 12)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "l";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "L";
                }
            }
            else if (randomnumber == 13)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "m";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "M";
                }
            }
            else if (randomnumber == 14)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "n";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "N";
                };
            }
            else if (randomnumber == 15)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "o";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "O";
                }
            }
            else if (randomnumber == 16)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "p";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "P";
                }
            }
            else if (randomnumber == 17)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "q";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "Q";
                }
            }
            else if (randomnumber == 18)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "r";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "R";
                }
            }
            else if (randomnumber == 19)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "s";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "S";
                }
            }
            else if (randomnumber == 20)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "t";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "T";
                }
            }
            else if (randomnumber == 21)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "u";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "U";
                }
            }
            else if (randomnumber == 22)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "v";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "V";
                }
            }
            else if (randomnumber == 23)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "w";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "W";
                }
            }
            else if (randomnumber == 24)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "x";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "X";
                }
            }
            else if (randomnumber == 25)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "y";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "Y";
                }
            }
            else if (randomnumber == 26)
            {
                if (UpperRandomNumber == 1)
                {
                    lblPassWord.Text = lblPassWord.Text + "z";
                }
                else
                {
                    lblPassWord.Text = lblPassWord.Text + "Z";
                }
            }
            
        
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Random number = new Random();
            lblPassWord.Text = lblPassWord.Text + number.Next(0, 9).ToString();
        }

        private void btnRemoveLast_Click(object sender, EventArgs e)
        {
            string labelvalue = lblPassWord.Text;
            string newLabelValue; 

            int lastletter = labelvalue.Count();
            lastletter = lastletter - 1;

            newLabelValue = labelvalue.Remove(lastletter);

            lblPassWord.Text = newLabelValue;
        }

        private void brnUpperCase_Click(object sender, EventArgs e)
        {
            originalValue = lblPassWord.Text; 
            lblPassWord.Text = lblPassWord.Text.ToUpper();
        }

        private void btnLowerCase_Click(object sender, EventArgs e)
        {
            originalValue = lblPassWord.Text; 
            lblPassWord.Text = lblPassWord.Text.ToLower();
        }

        private void btnNormalCase_Click(object sender, EventArgs e)
        {
            lblPassWord.Text = originalValue;
        }
    }
}
