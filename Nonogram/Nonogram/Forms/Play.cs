using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Nonogram
{
    public partial class Play : Form
    {
        int m, n, q;        
        static int i, j;
        string st;
        static Button[ , ] Buttons;
        static int BTWidHe = 40;        
        public int IndexI, IndexJ;
        static bool[ , ] Mat;
        static Label[,] LabelsG, LabelsV;
       
        public Play(string str)
        {
            InitializeComponent();            
            Matrix Mn = new Matrix();
            Mn.Tabl(str);                 
            m = Mn.m;
            n = Mn.n;
            st = str;            
            q=Mn.Perev(n, m);
            Mat = new bool[m,n];
            Buttons = new Button[m,n];
            LabelsG = new Label[m, n];
            LabelsV = new Label[n, m];
            this.CenterToScreen();
            int Y = this.ClientRectangle.Height / 2 - (BTWidHe * m) / 2;
            int X = this.ClientRectangle.Width / 2 - (BTWidHe * n) / 2;            
            label1.Location = new Point(X - 100, Y - 20);
            label1.Text = m + "x" + n;
            for (IndexI = 0; IndexI < m; IndexI++)
            {  

                for (IndexJ = 0; IndexJ < n; IndexJ++)
                {
                    if (IndexI == 0) 
                    {
                        int O = Y;
                        for (int t = 0; t < (n / 2) + 1; t++)
                        {
                            O -= BTWidHe;
                            LabelsV[IndexJ, t] = new Label();
                            string s = IndexJ.ToString() + "_" + t.ToString();
                            LabelsV[IndexJ, t].Name = s;
                            LabelsV[IndexJ, t].AutoSize = true;                           
                            LabelsV[IndexJ, t].ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                            LabelsV[IndexJ, t].Size = new System.Drawing.Size(BTWidHe+10, BTWidHe+10);
                            if ((IndexJ == 0)&(t==0))
                                O += BTWidHe;
                            LabelsV[IndexJ, t].Location = new Point(X, O);
                            LabelsV[IndexJ, t].Font = new Font(FontFamily.GenericSansSerif, 24, FontStyle.Bold);
                            LabelsV[IndexJ, t].BackColor = System.Drawing.SystemColors.ActiveCaption;
                            LabelsV[IndexJ, t].Visible = true;
                            Mn.NomV();                           
                            if (Mn.PV(IndexJ,t)==0)
                                LabelsV[IndexJ, t].Text = "";
                            else
                                LabelsV[IndexJ, t].Text = Mn.PV(IndexJ, t).ToString();
                            this.Controls.Add(LabelsV[IndexJ, t]);
                            
                        }            
                    }
                    if (IndexJ == 0)
                    {
                        X = this.ClientRectangle.Width / 2 - (BTWidHe * m) / 2;
                        int O = X;
                        for (int t = 0; t < (n / 2) + 1; t++)
                        {
                            O -= BTWidHe;
                            LabelsG[IndexI, t] = new Label();
                            string s = IndexI.ToString() + "_" + t.ToString();
                            LabelsG[IndexI, t].Name = s;
                            LabelsG[IndexI, t].AutoSize = true;
                            LabelsG[IndexI, t].ForeColor = System.Drawing.SystemColors.ActiveCaptionText;                            
                            LabelsG[IndexI, t].Size = new System.Drawing.Size(BTWidHe, BTWidHe);                            
                            LabelsG[IndexI, t].Location = new Point(O, Y + BTWidHe);
                            LabelsG[IndexI, t].Font = new Font(FontFamily.GenericSansSerif, 24, FontStyle.Bold);
                            LabelsG[IndexI, t].FlatStyle = FlatStyle.Flat;
                            LabelsG[IndexI, t].Visible = true;
                            LabelsG[IndexI, t].BackColor = System.Drawing.SystemColors.ActiveCaption;
                            LabelsG[IndexI, t].Visible = true;
                            Mn.NomG();
                            if (Mn.PG(IndexI, t) == 0)
                                LabelsG[IndexI, t].Text = "";
                            else
                                LabelsG[IndexI, t].Text = Mn.PG(IndexI, t).ToString();
                            this.Controls.Add(LabelsG[IndexI, t]);                            
                        } 
                    }                

                    Mat[IndexI, IndexJ] = Mn.T[IndexI, IndexJ];
                    Buttons[IndexI, IndexJ] = new Button();
                    string s2 = IndexI.ToString() + "_" + IndexJ.ToString();
                    Buttons[IndexI, IndexJ].Name = s2;
                    Buttons[IndexI, IndexJ].Width = BTWidHe;
                    Buttons[IndexI, IndexJ].Height = BTWidHe;
                    Buttons[IndexI, IndexJ].Location = new Point(X, Y);
                    Buttons[IndexI, IndexJ].Font = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold);
                    Buttons[IndexI, IndexJ].FlatStyle = FlatStyle.Flat;
                    if (IndexJ == 0)
                    {
                        Y += BTWidHe;
                        X = this.ClientRectangle.Width / 2 - (BTWidHe * m) / 2;
                        Buttons[IndexI, IndexJ].Location = new Point(X, Y);
                    }

                    i = IndexI;
                    j = IndexJ;
                    Buttons[IndexI, IndexJ].Click += new EventHandler(ButtonClick);
                    Buttons[IndexI, IndexJ].Visible = true;
                    this.Controls.Add(Buttons[IndexI, IndexJ]);
                    X += BTWidHe;
                }                
            }
        }

        public int Pe()
        { 
            int l;
            l=0;
            for(IndexI=0;IndexI<n;IndexI++)
                for (IndexJ = 0; IndexJ < m; IndexJ++)
                {
                    if (Buttons[IndexI, IndexJ].BackColor == System.Drawing.SystemColors.ActiveCaption)
                        l++;                 
                }
            return l;                   
        }





        private void ButtonClick(object sender, EventArgs e)
        {            
            Button BT;
            BT = (Button)sender;
            string st=BT.Name;   
                 
            i = st.IndexOf("_");            
            int l = Convert.ToInt16(st.Substring(0, i));
            int w = Convert.ToInt16(st.Substring(i+1, st.Length-(i+1)));
            if (Mat[l, w] == true)
            {
                BT.BackColor = System.Drawing.SystemColors.ActiveCaption;
                
            }
            else
            {
                BT.Image = global::Nonogram.Properties.Resources.x;
                Console.Beep();
            }

            End();
            

        }

        private void End()
        {
            if (q == Pe())
            {
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"melod.wav");
                sp.Play();
                Thread.Sleep(5000);
                MessageBox.Show("Ви успішно розвязали кросворд");
                RecordRez rec = new RecordRez();
                rec.Read(st);
                if (rec.zawd < 3)
                    rec.ReadEnd(st,rec.level,rec.zawd+1);
                else if (rec.zawd==3)
                    rec.ReadEnd(st, rec.level+1, 1);                
                Level form = new Level(st,1);
                form.Show();
                Close();
            }
        }
        


        private void Play_Load(object sender, EventArgs e)
        {
            
        }               

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        
    }
}