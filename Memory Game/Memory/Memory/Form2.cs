using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.players.Count; i++)
            {
                if (i == 0)
                {
                   n1.Text = Form1.players[i].username;
                    t1.Text = Form1.players[i].time.ToString();
                    f1.Text = Form1.players[i].failedTries.ToString();
                    //label1.Text = "1       " + Form1.players[i].username + "                     " + Form1.players[i].time.ToString() + "                  " + Form1.players[i].failedTries.ToString();
                }
                if (i == 1)
                {
                    n2.Text = Form1.players[i].username;
                    t2.Text = Form1.players[i].time.ToString();
                    f2.Text = Form1.players[i].failedTries.ToString();
                }
                if (i == 2)
                {
                    n3.Text = Form1.players[i].username;
                    t3.Text = Form1.players[i].time.ToString();
                    f3.Text = Form1.players[i].failedTries.ToString();
                    //label3.Text = "3       " + Form1.players[i].username + "                     " + Form1.players[i].time.ToString() + "                  " + Form1.players[i].failedTries.ToString();
                }
                if (i == 3)
                {
                    n4.Text = Form1.players[i].username;
                    t4.Text = Form1.players[i].time.ToString();
                    f4.Text = Form1.players[i].failedTries.ToString();
                   // label4.Text = "4       " + Form1.players[i].username + "                     " + Form1.players[i].time.ToString() + "                  " + Form1.players[i].failedTries.ToString();
                }

                if (i == 4)
                {
                    n5.Text = Form1.players[i].username;
                    t5.Text = Form1.players[i].time.ToString();
                    f5.Text = Form1.players[i].failedTries.ToString();
                   // label5.Text = "5       " + Form1.players[i].username + "                     " + Form1.players[i].time.ToString() + "                  " + Form1.players[i].failedTries.ToString();
                }
                if (i == 5)
                {
                    n6.Text = Form1.players[i].username;
                    t6.Text = Form1.players[i].time.ToString();
                    f6.Text = Form1.players[i].failedTries.ToString();
                    //label6.Text = "6       " + Form1.players[i].username + "                     " + Form1.players[i].time.ToString() + "                  " + Form1.players[i].failedTries.ToString();
                }
                if (i == 6)
                {
                    n7.Text = Form1.players[i].username;
                    t7.Text = Form1.players[i].time.ToString();
                    f7.Text = Form1.players[i].failedTries.ToString();
                    //label7.Text = "7       " + Form1.players[i].username + "                     " + Form1.players[i].time.ToString() + "                  " + Form1.players[i].failedTries.ToString();
                }
                if (i == 7)
                {
                    n8.Text = Form1.players[i].username;
                    t8.Text = Form1.players[i].time.ToString();
                    f8.Text = Form1.players[i].failedTries.ToString();
                   // label8.Text = "8       " + Form1.players[i].username + "                     " + Form1.players[i].time.ToString() + "                  " + Form1.players[i].failedTries.ToString();
                }
                if (i == 8)
                {
                    n9.Text = Form1.players[i].username;
                    t9.Text = Form1.players[i].time.ToString();
                    f9.Text = Form1.players[i].failedTries.ToString();
                    //label9.Text = "9       " + Form1.players[i].username + "                     " + Form1.players[i].time.ToString() + "                  " + Form1.players[i].failedTries.ToString();
                }
                if (i == 9)
                {
                    n10.Text = Form1.players[i].username;
                    t10.Text = Form1.players[i].time.ToString();
                    f10.Text = Form1.players[i].failedTries.ToString();
                    //label10.Text = "10       " + Form1.players[i].username + "                     " + Form1.players[i].time.ToString() + "                  " + Form1.players[i].failedTries.ToString();
                }
                if (i >= 10)
                {
                    break;
                }
            }

        }
    }
}
