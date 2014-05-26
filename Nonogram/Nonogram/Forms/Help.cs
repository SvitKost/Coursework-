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
    public partial class Help : Form
    {
        public int Index;

        public Help()
        {
            InitializeComponent();
            pictureBox1.Image = global::Nonogram.Properties.Resources._1;
            pictureBox2.Image = global::Nonogram.Properties.Resources._2;
            Index = 1;
           
        }

        public void Sv(int i)
        {
            switch (i)
            {
                case 1:
                    {
                        
                        label6.ForeColor = System.Drawing.Color.Red;
                        label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        pictureBox2.Visible = true;
                        pictureBox1.Image = global::Nonogram.Properties.Resources._1;
                        pictureBox2.Image = global::Nonogram.Properties.Resources._2;
                        textBox1.Text = "Перед нами простий кросворд розміром 9х9 клітинок. Ми будемо поступово розгадувати даний кросворд, по-кроково. Щоб Ви не заплутались, нові помітки будуть відмічені синім кольором.";
                        textBox2.Text = "Спочатку подивимось чи є в кросворді рядки, які мають бути повністю зафарбовані. Виявляється, в нашому випадку, це цифра 9 у четвертому рядку. ";
                        break;
                    }
                case 2:
                    {
                        label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        label6.ForeColor = System.Drawing.Color.DarkOrange;

                        label5.ForeColor = System.Drawing.Color.Red;
                        label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        pictureBox2.Visible = true;
                        pictureBox1.Image = global::Nonogram.Properties.Resources._3;
                        pictureBox2.Image = global::Nonogram.Properties.Resources._4;
                        textBox1.Text = "По аналогії шукаємо стовпці які мають бути повністю зафарбовані.";
                        textBox2.Text = "Подивимось на третій рядок. Запамятайте маленьке правило, яке нам дуже допоможе - якщо число в рядку або стовпці лише одне і є більше за половину довжини, то можна замальовувати декілька клітинок в середині. В нашому випадку це центральні 5 клітинок.Чому? Тому що як не розміщай в девяти клітинках групу із семи клітинок, 5 центральних обовязково будуть зафарбовані.";
                        break;
                    }
               case 3:
                    {
                        label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        label5.ForeColor = System.Drawing.Color.DarkOrange;

                        label4.ForeColor = System.Drawing.Color.Red;
                        label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));                        pictureBox2.Visible = true;
                        pictureBox1.Image = global::Nonogram.Properties.Resources._5;
                        pictureBox2.Image = global::Nonogram.Properties.Resources._6;
                        textBox1.Text = "Тепер ми можемо відмітити хрестиками (чи крапочками) клітинки, які однозначно не можуть бути зафарбованими. Погляньте на перший рядок - він повністю розгаданий, так як у нас вже є одна зафарбована клітинка, а більше тут бути і не повинно. Отже, всі інші клітинки відмічаємо хрестиками. Так само в шостому та сьомому рядках. ";
                        textBox2.Text = "В пятому рядку у нас є одна зафарбована клітинка, і так як у ньому лише поодинокі клітинки, ми можемо відмітити хрестиками клітинки зліва та справа від відгаданої.  Закреслювати цифру ми не можемо, так як не знаємо яку саме відгадали. Така ж ситуація у восьмому рядку. В девятому рядку ми можемо з упевненістю сказати, що перші дві клітинки та дві останні не будуть зафарбовані. Чому? Тому що в цьому рядку вже розгадана одна клітина, а єдина цифра тут - трійка, має бути частиною цієї зафарбованої клітинки. ";
                        break;
                    }
                case 4:
                    {
                        label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        label4.ForeColor = System.Drawing.Color.DarkOrange;

                        label3.ForeColor = System.Drawing.Color.Red;
                        label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));                        pictureBox2.Visible = true;
                        pictureBox1.Image = global::Nonogram.Properties.Resources._7;
                        pictureBox2.Image = global::Nonogram.Properties.Resources._8;
                        textBox1.Text = "Тепер подивимося на перший стовпчик - так само як і у попередньому кроці, у нас є лише одна цифра - двійка, і одна відгадана клітинка. Відповідно, перші дві, та останні чотири клітинки - точно будуть не зафарбовані. Та ж ситуація у другому та останніх чотирьох стовпчиках.";
                        textBox2.Text = "Можна відмітити, що в центральних пяти стовпчиках залишилось дуже мало порожніх клітинок, а саме -  їх кількімть відповідає цифрам, вказаним зверху. Отже, всі ці клітинки можна зафарбувати.";
                        break;
                    }
                 case 5:
                    {
                        label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        label3.ForeColor = System.Drawing.Color.DarkOrange;

                        label2.ForeColor = System.Drawing.Color.Red;
                        label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));                        pictureBox2.Visible = true;
                        pictureBox1.Image = global::Nonogram.Properties.Resources._9;
                        pictureBox2.Image = global::Nonogram.Properties.Resources._10;
                        textBox1.Text = " Повертаючись до рядків, ми можемо побачити, що другий та останній уже розгадані. А в пятому рядку можна поставити хрестики зліва та справа від зафарбованих клітин,так як вони мають бути одиничними.";
                        textBox2.Text = "Тепер стає видно, що в пятому рядку залишились лише дві вільні клітинки, які відповідають двом які потрібно зафарбувати. Варто відмітити, що цей рядок можна було розгадати на самому початку, так як в девяти клітинках розмістити пять одиничних клітин одного кольору можна лише одним способом.";
                        break;
                    }

                case 6:
                    {
                        label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        label2.ForeColor = System.Drawing.Color.DarkOrange;

                        label1.ForeColor = System.Drawing.Color.Red;
                        label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                                                    | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204))); pictureBox1.Image = global::Nonogram.Properties.Resources._11;
                        pictureBox2.Visible = false;
                        textBox1.Text = "Переходячи до стовпчиків, ми бачимо що перший та останній вже розгадані. Лишилось зафарбувати лише останні клітинки у другому та восьмому стовпці...";
                        textBox2.Text = "Отже, вітаю! Кросворд розгаданий! Тепер Ви можете спробувати самостійно";
                        break;
                    }          
                    
                    
            }
        
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }
        


        private void pictureBox4_Click(object sender, EventArgs e)
        {            
            Index++;
            Sv(Index);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Index--;
            Sv(Index);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
