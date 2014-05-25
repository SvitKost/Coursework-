using System;
using System.IO;

namespace Nonogram
{
    class Plays
    {          
        public int nomber;
        public string[] plays = new string[10];

        public void Playss()
        {
            using (StreamReader file = new StreamReader("players.txt"))
            {
                nomber = Convert.ToInt16(file.ReadLine());
                for (int i = 0; i < nomber; i++)
                    plays[i] = file.ReadLine();
                file.Close();
            }
        }

        public void Input(string n)
        {
            using (StreamWriter filee = new StreamWriter("players.txt"))
            {
                filee.WriteLine(nomber + 1);
                for (int i = 0; i < nomber; i++)
                    filee.WriteLine(plays[i]);
                    filee.WriteLine(n);
                    filee.Close();
            }                               
        }

        public void Output(int n)
        {
            Playss();
            nomber--;
            for (int i = n; i < nomber; i++)
                plays[i] = plays[i + 1];
            
            using (StreamWriter filee = new StreamWriter("players.txt"))
            {
                filee.WriteLine(nomber);
                for (int j = 0; j < nomber; j++)
                    filee.WriteLine(plays[j]);      
                filee.WriteLine();
                filee.Close();

            }
 

        }
       
    }
}
