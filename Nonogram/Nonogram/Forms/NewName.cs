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
            textBox1.Select();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Input()
        {
            if (textBox1.Text != "")
            {
                name = Convert.ToString(textBox1.Text);
                Plays pl = new Plays();
                Form1 fr = new Form1();
                pl.Playss();
                pl.Input(name);
            }
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            Input();                               
            Close();           
           
        }

        private void NewName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Input();
                Close();
            }

        }

       
    }
}
