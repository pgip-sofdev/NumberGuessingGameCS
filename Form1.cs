using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numberGuessingGame
{
    public partial class Form1 : Form
    {
        int guessedNumber = 0;
        static int computerNumber = 0;
        static string msg;
        static int difference = 0;
        



        public Form1()
        {
            InitializeComponent();
            guessButton.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init();
            
        }

        private void guessButton_Click(object sender, EventArgs e)
        {


            guessedNumber = Convert.ToInt32(textBox1.Text);

        
            

            if ( (Math.Abs(computerNumber - guessedNumber)) < difference)
            {
                textBox1.BackColor = Color.Red;
            }
            else
            {
                textBox1.BackColor = Color.Blue;
            }

            if ((Math.Abs(guessedNumber)) > (Math.Abs(computerNumber)))
            {
                msg = "Too High!";
                textBox1.Focus();
            }
            else if (Math.Abs(guessedNumber) < (Math.Abs(computerNumber)))
            {
                msg = "Too Low!";
                textBox1.Focus();
            }
            else 
            {
                msg = "Correct!";
                textBox1.BackColor = Color.Green;
                textBox1.Focus();
                guessButton.Enabled = false;
                
            }

            


            resultBox.Text = msg;

            difference = Math.Abs(computerNumber - guessedNumber);






        }

        private void ngButton_Click(object sender, EventArgs e)
        {
            init();
            guessButton.Visible = true;
        }

        private void init()
        {
            
            var rand = new Random();
            computerNumber = rand.Next(1, 1001);
            guessButton.Enabled = true;

                        
            textBox1.Clear();
            textBox1.BackColor = Color.White;
            resultBox.Text = "";
            textBox1.Focus();
            
        }
    }
}
