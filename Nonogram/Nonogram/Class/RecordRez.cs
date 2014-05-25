using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Nonogram
{
    class RecordRez
    {
        public int level, zawd;

        public void Stwor(string s)
        {
            using (StreamWriter filee = new StreamWriter(s))
            {
                level = 1;
                zawd = 0;
                filee.WriteLine(level);                
                filee.WriteLine(zawd);
                filee.Close();                
            }
        }

        public void Read(string s)
        {
            using (StreamReader file = new StreamReader(s))
            {
                level = Convert.ToInt16(file.ReadLine());
                zawd = Convert.ToInt16(file.ReadLine());
                file.Close();
            }
        }

        public void ReadEnd(string s,int i,int j)
        {
            using (StreamWriter filee = new StreamWriter(s))
            {                
                filee.WriteLine(i);
                filee.WriteLine(j);
                filee.Close();
            }
        
        }

    }
}
