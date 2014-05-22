using System;
using System.Windows.Forms;

namespace Nonogram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Players();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        public void Players()
        {
            Plays pl = new Plays();
            pl.Playss();
            for (int i = 0; i < pl.nomber; i++)
                list_plays.Items.Add(pl.plays[i]);
 
        }       
      
        

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            NewName form = new NewName();
            form.Show();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Level form = new Level();
            form.Show();
        }

        private void button_output_Click(object sender, EventArgs e)
        {
            if (list_plays.SelectedItem == null)
                MessageBox.Show("Виберіть гравця");
            else
            {
                int index = list_plays.SelectedIndex;                
                Plays pl = new Plays();               
                pl.Output(index);
                Players();
            }
        }               

        private void list_plays_MouseHover(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Список гравців. Виберіть гравця";
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button_input_MouseHover(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Створення нового гравця";
        }

        private void button_output_MouseHover(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Видалення гравця";

        }

        private void exit_MouseHover(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Вихід з гри";
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "ще не придумала";
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Продовжити гру";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Розпочати нову гру";
        }

        

       
    }
}
