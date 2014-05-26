using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Nonogram
{
    
    public partial class Level : Form
    {
        public int I,Lev,Za;
        string s, str;
        public Level(string st, int i)
        {
            InitializeComponent();
            RecordRez fl = new RecordRez();
            str = st;
            if (i == 0)
                fl.Stwor(str);
            else
                fl.Read(str);
            Lev = fl.level;
            Za = fl.zawd;
            if (Lev == 1)
            {
                pictureBox2.Image = global::Nonogram.Properties.Resources._002k;
                pictureBox5.Image = global::Nonogram.Properties.Resources._003k;
            }
            else 
            if (Lev==2)
                pictureBox5.Image = global::Nonogram.Properties.Resources._003k;


        }

        private void Level_Load(object sender, EventArgs e)
        {

        }        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Lev > 1)
            { 
                label2.Text = "";
                label1.Text = "Ви обрали І рівень";
                I = 1;
                if (panel1.Visible == false)
                {
                    label2.Text = "";
                    panel1.Visible = true;
                    pictureBox4.Image = global::Nonogram.Properties.Resources._022;
                    pictureBox6.Image = global::Nonogram.Properties.Resources._033;
                }            
            }
            else if (Lev == 1)
            {
                label2.Text = "";
                label1.Text = "Ви обрали І рівень";
                I = 1;
                if (panel1.Visible == false)
                {
                    label2.Text = "";
                    panel1.Visible = true;
                    if (Za == 0)
                    {
                        pictureBox4.Image = global::Nonogram.Properties.Resources._022k;
                        pictureBox6.Image = global::Nonogram.Properties.Resources._033k;
                    }
                    else if (Za == 1)
                        pictureBox6.Image = global::Nonogram.Properties.Resources._033k;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Lev > 2)
            { 
                I = 2;
                label2.Text = "";
                label1.Text = "Ви обрали ІІ рівень";

                if (panel1.Visible == false)
                {
                    label2.Text = "";
                    panel1.Visible = true;
                    pictureBox4.Image = global::Nonogram.Properties.Resources._022;
                    pictureBox6.Image = global::Nonogram.Properties.Resources._033;
                }
            }
            else if (Lev>=2)        
            {
                I = 2;
                label2.Text = "";
                label1.Text = "Ви обрали ІІ рівень";
            
                if (panel1.Visible == false)
                {                    
                    label2.Text = "";
                    panel1.Visible = true;
                    if (Za == 0)
                    {
                        pictureBox4.Image = global::Nonogram.Properties.Resources._022k;
                        pictureBox6.Image = global::Nonogram.Properties.Resources._033k;
                    }
                    else if (Za == 1)
                        pictureBox6.Image = global::Nonogram.Properties.Resources._033k;
                }
            }
            else Console.Beep();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Lev == 3)
            {
                label2.Text = "";
                label1.Text = "Ви обрали ІІІ рівень";
                I = 3;
                if (panel1.Visible == false)
                {
                    label2.Text = "";
                    panel1.Visible = true;
                    if (Za == 0)
                    {
                        pictureBox4.Image = global::Nonogram.Properties.Resources._022k;
                        pictureBox6.Image = global::Nonogram.Properties.Resources._033k;
                    }
                    else if (Za == 1)
                        pictureBox6.Image = global::Nonogram.Properties.Resources._033k;
                }
            }
            else Console.Beep();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (I == 1)
            {
                label2.Text = "I завдання";
                s = "P1_1.txt";
            }
            else
            {
                if (I == 2)
                {
                    label2.Text = "I завдання";
                    s = "P2_1.txt";
                }
                else
                {
                    label2.Text = "I завдання";
                    s = "P3_1.txt";
                }
            }            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Image != global::Nonogram.Properties.Resources._022)
                Console.Beep();
            else
            {
                if (I == 1)
                {
                    label2.Text = "II завдання";
                    s = "P1_2.txt";
                }
                else
                {
                    if (I == 2)
                    {
                        label2.Text = "II завдання";
                        s = "P2_2.txt";
                    }
                    else
                    {
                        label2.Text = "II завдання";
                        s = "P3_2.txt";
                    }
                }
            }   
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Image != global::Nonogram.Properties.Resources._033)
                Console.Beep();
            else   
            if (I == 1)
            {
                label2.Text = "III завдання";
                s = "P1_3.txt";
            }
            else
            {
                if (I == 2)
                {
                    label2.Text = "IIІ завдання";
                    s = "P2_3.txt";
                }
                else
                {
                    label2.Text = "ІІI завдання";
                    s = "P3_3.txt";
                }
            }           
                 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (s != null)
            {
                Play form = new Play(s, str);
                form.Show();
                Close();
            }
            else MessageBox.Show("Виберіть рівень та завдання");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
