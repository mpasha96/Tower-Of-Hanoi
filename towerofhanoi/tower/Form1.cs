using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tower
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int moves=0;
        
        stack stackA = new stack();
        stack stackB = new stack();
        stack stackC = new stack();

        private void button1_Click(object sender, EventArgs e)
        {
            moves++;
            if (B1.Text == "" || Convert.ToInt32(stackA.Peek()) < Convert.ToInt32(stackB.Peek()))
            {
            int text = stackA.Pop();
          stackB.Push(text);
          if (A3.Text!="")
          {
              A3.Text = "";
          }
          else if (A2.Text != "")
          {
              A2.Text = "";
          }
          else
          {
              A1.Text = "";
          }

          if (B1.Text=="")
          {
              B1.Text = text.ToString();
          }
          else if (B2.Text == "")
          {
              B2.Text = text.ToString();
          }
          else
          {
              B3.Text = text.ToString();
          }
         }
            else
            {
                MessageBox.Show("Illegal move !");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stackA.Push(3);
            stackA.Push(2);
            stackA.Push(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moves++;
            if (C1.Text == "" || Convert.ToInt32(stackA.Peek()) < Convert.ToInt32(stackC.Peek()))
            {
                int text = stackA.Pop();
                stackC.Push(text);
                if (A3.Text != "")
                {
                    A3.Text = "";
                }
                else if (A2.Text != "")
                {
                    A2.Text = "";
                }
                else
                {
                    A1.Text = "";
                }

                if (C1.Text == "")
                {
                    C1.Text = text.ToString();
                }
                else if (C2.Text == "")
                {
                    C2.Text = text.ToString();
                }
                else
                {
                    C3.Text = text.ToString();
                }

            if ((C3.Text == "1") && (C2.Text == "2") &&(C1.Text == "3"))
            {
                MessageBox.Show(string.Format("congratulations! \n You completed in {0} moves. \n Minimum number of moves required is 7.", moves.ToString()));
            }

        }
            else
            {
                MessageBox.Show("Illegal move !");
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moves++;
            if (A1.Text == "" || Convert.ToInt32(stackB.Peek()) < Convert.ToInt32(stackA.Peek()))
            {
                int text = stackB.Pop();
                stackA.Push(text);
                if (B3.Text != "")
                {
                    B3.Text = "";
                }
                else if (B2.Text != "")
                {
                    B2.Text = "";
                }
                else
                {
                    B1.Text = "";
                }

                if (A1.Text == "")
                {
                    A1.Text = text.ToString();
                }
                else if (A2.Text == "")
                {
                    A2.Text = text.ToString();
                }
                else
                {
                    A3.Text = text.ToString();
                }
            }
            else
            {
                MessageBox.Show("Illegal move !");
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            moves++;
            if (A1.Text == "" || Convert.ToInt32(stackC.Peek()) < Convert.ToInt32(stackA.Peek()))
            {
                int text = stackC.Pop();
                stackA.Push(text);
                if (C3.Text != "")
                {
                    C3.Text = "";
                }
                else if (C2.Text != "")
                {
                    C2.Text = "";
                }
                else
                {
                    C1.Text = "";
                }

                if (A1.Text == "")
                {
                    A1.Text = text.ToString();
                }
                else if (A2.Text == "")
                {
                    A2.Text = text.ToString();
                }
                else
                {
                    A3.Text = text.ToString();
                }
            }
            else
            {
                MessageBox.Show("Illegal move !");
            }
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            moves++;
            if (C1.Text == "" || Convert.ToInt32(stackB.Peek()) < Convert.ToInt32(stackC.Peek()))
            {
                int text = stackB.Pop();
                stackC.Push(text);
                if (B3.Text != "")
                {
                    B3.Text = "";
                }
                else if (B2.Text != "")
                {
                    B2.Text = "";
                }
                else
                {
                    B1.Text = "";
                }

                if (C1.Text == "")
                {
                    C1.Text = text.ToString();
                }
                else if (C2.Text == "")
                {
                    C2.Text = text.ToString();
                }
                else
                {
                    C3.Text = text.ToString();
                }

                if ((C3.Text == "1") && (C2.Text == "2") && (C1.Text == "3"))
                {
                    MessageBox.Show(string.Format("congratulations! \n You completed in {0} moves. \n Minimum number of moves required is 7.", moves.ToString()));
                }
            }
            else
            {
                MessageBox.Show("Illegal move !");
            }
            
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            moves++;
            if (B1.Text == "" || Convert.ToInt32(stackC.Peek()) < Convert.ToInt32(stackB.Peek()))
            {
                int text = stackC.Pop();
                stackB.Push(text);
                if (C3.Text != "")
                {
                    C3.Text = "";
                }
                else if (C2.Text != "")
                {
                    C2.Text = "";
                }
                else
                {
                    C1.Text = "";
                }

                if (B1.Text == "")
                {
                    B1.Text = text.ToString();
                }
                else if (B2.Text == "")
                {
                    B2.Text = text.ToString();
                }
                else
                {
                    B3.Text = text.ToString();
                }   
            }
            else
            {
                MessageBox.Show("Illegal move !");
            }
           
        }

        private void A3_Click(object sender, EventArgs e)
        {

        }

        private void A2_Click(object sender, EventArgs e)
        {

        }

        private void A1_Click(object sender, EventArgs e)
        {

        }

        private void B1_Click(object sender, EventArgs e)
        {

        }

        private void B2_Click(object sender, EventArgs e)
        {

        }

        private void B3_Click(object sender, EventArgs e)
        {

        }

        private void C3_Click(object sender, EventArgs e)
        {

        }

        private void C2_Click(object sender, EventArgs e)
        {

        }

        private void C1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
