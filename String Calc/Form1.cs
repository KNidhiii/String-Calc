using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.string1text.Equals("")|| this.string2text.Equals(""))
                MessageBox.Show("Enter valid strings", "Concatination");
            else
                MessageBox.Show(this.string1text.Text + this.string2text.Text,"Concatination");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
           bool rs = this.string1text.Text.Equals(this.string2text.Text);
           // if(this.string1text.Text="")

            if (rs == true)
                MessageBox.Show("Strings are same","Compare");
            else
                MessageBox.Show("Strings are different","Compare");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.string1text.Clear();
            this.string2text.Clear();
            this.inputtext.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = this.inputtext.Text;
            string rev = "";
            if (s == "")
                MessageBox.Show("Enter the string", "Check palindrome");
            else
            {
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    rev += s[i].ToString();
                }
                if (s == rev)
                    MessageBox.Show("Is palindrome", "Check palindrome");
                else
                    MessageBox.Show("Not a palindrome", "Check palindrome");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            string s = this.inputtext.Text;
            string rev = "";
            if (s == "")
                MessageBox.Show("Enter the string","Reverse");
            else
            {
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    rev += s[i].ToString();
                }
                MessageBox.Show(rev, "Reverse");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
