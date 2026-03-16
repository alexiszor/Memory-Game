using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Form1 : Form
    {
        int ab = 1;

        Image image1 = Properties.Resources.apple1;
        Image image2 = Properties.Resources.banana;
        Image image3 = Properties.Resources.pear;
        Image image4 = Properties.Resources.watermelon;
        Image image5 = Properties.Resources.orange;
        Image image6 = Properties.Resources.lemon2;
        Image image7 = Properties.Resources.cherry;
        Image image8 = Properties.Resources.strawberry;
        Image image9 = Properties.Resources.blueberry;
        Image image10 = Properties.Resources.pineapple;


        int count = 0;

        int fails = 0;
        int sec = 0;
        Random r = new Random();

        List<PictureBox> pics = new List<PictureBox>();
        List<PictureBox> pics2 = new List<PictureBox>();
        //List<PictureBox> hide = new List<PictureBox>();

        public static List<Player> players = new List<Player>();
        

        int tries = 0;

        Image try1;
        Image try2;
        
        PictureBox pic1;
        PictureBox pic2;

        int open = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            int size1 = 33;
            int size2 = 29;
            //if ()
            for (int i = 1; i <= 4; i++)
            {
                size2 = 29 + (87 * (i - 1));
                for (int j = 1; j <= 5; j++)
                {
                    count = count + 1;
                    PictureBox p = new PictureBox();
                    p.Location = new Point(size1 + (87 * (j - 1)), size2);
                    p.Name = count.ToString();
                    // button.Text = i.ToString() + j.ToString();
                    p.Text = "";
                    p.BackColor = Color.FromName("Black");
                    p.Size = new Size(82, 58);
                    this.Controls.Add(p);
                    p.Click += new EventHandler(this.Pclick);
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                    
                    pics.Add(p);
                    pics2.Add(p);
                }
            }
            count = 0;
            Title.Visible = false;
            score.Visible = false;
            Settings.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "0";
            seconds.Text = "0";
            Time.Visible = true;
            seconds.Visible = true;
            sec = 0;
          ///  timer.Enabled = true;
            fails = 0;
            //PictureBox[] pictures = { 1, 2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20 };
            //pics.AddRange(pictures);
            for (int i = 0; i < pics.Count; i++)
            {
                pics[i].Visible = true;
            }


            int n = r.Next(pics.Count);
            pics[n].Image = image1;
            pics[n].ErrorImage = image1;
            pics.Remove(pics[n]);
            n = r.Next(pics.Count);
            pics[n].Image = image1;
            pics[n].ErrorImage = image1;
            pics.Remove(pics[n]);
            n = r.Next(pics.Count);
            pics[n].Image = image2;
            pics[n].ErrorImage = image2;
            pics.Remove(pics[n]);
            n = r.Next(pics.Count);
            pics[n].Image = image2;
            pics[n].ErrorImage = image2;
            pics.Remove(pics[n]);
            n = r.Next(pics.Count);
            pics[n].Image = image3;
            pics[n].ErrorImage = image3;
            pics.Remove(pics[n]);
            n = r.Next(pics.Count);
            pics[n].Image = image3;
            pics[n].ErrorImage = image3;
            pics.Remove(pics[n]);
            n = r.Next(pics.Count);
            pics[n].Image = image4;
            pics[n].ErrorImage = image4;
            pics.Remove(pics[n]);
            n = r.Next(pics.Count);
            pics[n].Image = image4;
            pics[n].ErrorImage = image4;
            pics.Remove(pics[n]);
            n = r.Next(pics.Count);
            pics[n].Image = image5;
            pics[n].ErrorImage = image5;
            pics.Remove(pics[n]);
            n = r.Next(pics.Count);
            pics[n].Image = image5;
            pics[n].ErrorImage = image5;
            pics.Remove(pics[n]);
            pics[n].Image = image6;
            pics[n].ErrorImage = image6;
            pics.Remove(pics[n]);
            n = r.Next(pics.Count);
            pics[n].Image = image6;
            pics[n].ErrorImage = image6;
            pics.Remove(pics[n]);
            n = r.Next(pics.Count);
            pics[n].Image = image7;
            pics[n].ErrorImage = image7;
            pics.Remove(pics[n]);
            n = r.Next(pics.Count);
            pics[n].Image = image7;
            pics[n].ErrorImage = image7;
            pics.Remove(pics[n]);
            n = r.Next(pics.Count);
            pics[n].Image = image8;
            pics[n].ErrorImage = image8;
            pics.Remove(pics[n]);
            n = r.Next(pics.Count);
            pics[n].Image = image8;
            pics[n].ErrorImage = image8;
            pics.Remove(pics[n]);
            n = r.Next(pics.Count);
            pics[n].Image = image9;
            pics[n].ErrorImage = image9;
            pics.Remove(pics[n]);
            n = r.Next(pics.Count);
            pics[n].Image = image9;
            pics[n].ErrorImage = image9;
            pics.Remove(pics[n]);
            n = r.Next(pics.Count);
            pics[n].Image = image10;
            pics[n].ErrorImage = image10;
            pics.Remove(pics[n]);
            n = r.Next(pics.Count);
            pics[n].Image = image10;
            pics[n].ErrorImage = image10;
            pics.AddRange(pics2);
            pics2.Clear();
            Start.Visible = false;
            StartTimer.Enabled = true;
        }

        void Pclick(object sender, EventArgs e)
        {
            for (int k = 0; k <= 0; k++)
            {
                PictureBox p2 = sender as PictureBox;
                p2.Image = p2.ErrorImage;
                p2.Enabled = false;
                if (tries == 1)
                {
                    try2 = p2.ErrorImage;
                    pic2 = p2;
                    tries = tries + 1;
                    Check c = new Check();
                    Bitmap b1 = (Bitmap)try1;
                    Bitmap b2 = (Bitmap)try2;
                    bool b=c.Check1(b1,b2);
                    
                    
                    if (b == true)
                    {
                        //p2.Enabled = false;
                        pic1.Enabled = false;
                        pic2.Enabled = false;
                       //Find f = new Find();
                       // PictureBox fp = f.find2(num1, pics);
                        //for (int i = 0; i < fp.Count; i++)
                       // {
                        //f//p.Enabled = false;
                       // }
                        open = open + 2;

                        if (open == 20)
                        {
                            for (int i = 0; i < pics.Count; i++)
                            {
                                this.Controls.Remove(pics[i]);
                                
                                
                            }
                            open = 0;
                            timer.Enabled = false;
                            label1.Visible = false;
                            label2.Visible = false;
                            Time.Visible = false;
                            seconds.Visible = false;
                            label3.Visible = true;
                            Username.Visible = true;
                            OK.Visible = true;                     
                            MessageBox.Show("Congratulations!");
                            pics.Clear();
                        }
                        
                        tries = 0;
                        
                        break;
                        //MessageBox.Show("aaaaaa");
                        //Start.Text = b.ToString();

                    }
                    else
                    {
                        // Find f = new Find();
                        //if (num1 == num2)
                        //{
                        //    tries = 0;
                        //   for (int i = 0; i < pics.Count(); i++)
                        //    {
                        //       if (pics[i].Name == num1.ToString())
                        //     {
                        //         pics[i].Image = null;

                        //     }
                        //   }

                        //}
                        //hide = f.find1(num1, num2, pics);
                        // label1.Text = hide[0].ToString() + hide[1].ToString();
                        // Start.Text = num1.ToString() + num2.ToString();
                        //PictureBox fp = f.find2(num2, pics);
                        // hide.Add(p2);
                        // hide.Add(fp);
                        for (int i = 0; i < pics.Count; i++)
                        {
                            if ((pics[i].Enabled == true) & (pics[i].Image == null))
                            {
                                pics[i].Enabled = false;
                            }
                            
                        }
                        fails = fails + 1;
                        label2.Text = fails.ToString();
                        HideTimer.Enabled = true;
                        break;
                        
                        //pictureBox1.Image = null;
                    }
                }
                if (tries == 0)
                {
                    try1 = p2.ErrorImage;
                    pic1 = p2;
                    tries = tries + 1;
                }
            }
        }

        private void StartTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < pics.Count; i++)
            {
                
                pics[i].Image = null;
                //pics[i].Visible = true;
            }
            Time.Visible = true;
            seconds.Visible = true;
            timer.Enabled = true;
            StartTimer.Enabled = false;
        }

        private void HideTimer_Tick(object sender, EventArgs e)
        {
            //for (int i = 0; i < hide.Count; i++)
           // {
           //     hide[i].Image = null;
           // }

            pic1.Image = null;
            pic2.Image = null;
            pic1.Enabled = true;
            pic2.Enabled = true;
            for (int i = 0; i < pics.Count; i++)
            {
                if ((pics[i].Enabled == false) & (pics[i].Image == null))
                {
                    pics[i].Enabled = true;
                }

            }
            tries = 0;
            
            HideTimer.Enabled = false;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Player pl = new Player();
            pl.username = Username.Text;
            pl.failedTries = fails;
            pl.time = sec;
            players.Add(pl);
            players.Sort((a, b) => a.time - b.time);
            score.Visible = true;
            Title.Visible = true;
            Start.Visible = true;
            Settings.Visible = true;
            label3.Visible = false;
            Username.Visible = false;
            Username.Text = "";
            OK.Visible = false;
            String a2 = "";
            TextWriter names = new StreamWriter("Name.txt");
            TextWriter time = new StreamWriter("Time.txt");
            TextWriter fail = new StreamWriter("Fail.txt");

            for (int i = 0; i < players.Count; i++)
            {
                a2 = players[i].username;
                names.WriteLine(a2);
                a2 = players[i].time.ToString();
                time.WriteLine(a2);
                a2 = players[i].failedTries.ToString();
                fail.WriteLine(a2);


            }
            names.Close();
            fail.Close();
            time.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            sec = sec + 1;
            seconds.Text = sec.ToString();
        }

        private void score_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            //MessageBox.Show(a);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Name.txt")&(ab == 1)){
                String n;
                int  f;
                int  t;
                System.IO.StreamReader fileN = new System.IO.StreamReader("Name.txt");

                System.IO.StreamReader fileT = new System.IO.StreamReader("Time.txt");
                System.IO.StreamReader fileF = new System.IO.StreamReader("Fail.txt");
                while ((n = fileN.ReadLine()) != null)
                {
                    f = int.Parse(fileF.ReadLine());
                    t= int.Parse(fileT.ReadLine());
                    Player p = new Player();
                    p.username = n;
                    p.failedTries = f;
                    p.time = t;
                    players.Add(p);
                }
                ab = 0;
                fileN.Close();
                fileF.Close();
                fileT.Close();
            }

           // openFileDialog1.Filter=

        }

        private void Settings_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            Back.Visible = true;
            Title.Visible = false;
            score.Visible = false;
            Start.Visible = false;
            Settings.Visible = false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            Back.Visible = false;
            Title.Visible = true;
            score.Visible = true;
            Start.Visible = true;
            Settings.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                image1 = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = image1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image2 = new Bitmap(openFileDialog1.FileName);
                pictureBox2.Image = image2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image3 = new Bitmap(openFileDialog1.FileName);
                pictureBox3.Image = image3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image4 = new Bitmap(openFileDialog1.FileName);
                pictureBox4.Image = image4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image5 = new Bitmap(openFileDialog1.FileName);
                pictureBox5.Image = image5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image6 = new Bitmap(openFileDialog1.FileName);
                pictureBox6.Image = image6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image7 = new Bitmap(openFileDialog1.FileName);
                pictureBox7.Image = image7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image8 = new Bitmap(openFileDialog1.FileName);
                pictureBox8.Image = image8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image9 = new Bitmap(openFileDialog1.FileName);
                pictureBox9.Image = image9;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image10 = new Bitmap(openFileDialog1.FileName);
                pictureBox10.Image = image10;
            }
        }
    }
}
