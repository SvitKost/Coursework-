using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Nonogram
{
    public partial class NewName : Form
    {
        public string name;
        public NewName()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            name = Convert.ToString(textBox1.Text);
            Plays pl = new Plays();
            pl.Playss();
            pl.Input(name);
            Form1 fr = new Form1();
            for (int i = 0; i < pl.nomber; i++)
                fr.list_plays.Items.Add(pl.plays[pl.nomber-1]);
            Close();
        }

       
    }
}
