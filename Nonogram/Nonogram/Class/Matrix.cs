using System;
using System.IO;

namespace Nonogram
{
    class Matrix
    {
        public int n,m,i,j;
        string str;
        public bool[,] T;
        public static int[,] G,V;               
        
        public void Tabl(string f)
        {
            using (StreamReader file = new StreamReader(f))
            {
                m = Convert.ToInt16(file.ReadLine());
                n = Convert.ToInt16(file.ReadLine());
                T = new bool[m, n];
                int x;                
                for (i = 0; i < n; i++)
                {                    
                    str = file.ReadLine();
                    x = 0;
                    for (j = 0; j < m; j++)
                    {
                       int  a = Convert.ToInt16(str.Substring(x, 1));
                        if (a == 1)
                            T[i, j] = true;
                        else
                            T[i, j] = false;
                        x += 2;
                    }
                }
                file.Close();
            }
        }

        public int Perev(int n, int m)
        {
            int g;
            g=0;
            //T = new bool[m, n];
            for(int i=0;i<n;i++)
                for (int j = 0; j < m; j++)
                {
                    if (T[i, j] == true)
                        g++;
                }
            return g;
        
        }

        public void NomG()
        {
            G = new int[n, (n / 2) + 1];
            for (i = 0; i < n; i++)
            {
                int r = 0;
                int x = 0;
                for (j = m - 1; j >= 0; j--)
                {

                    if (T[i, j] == true)
                        x++;
                    else
                        if (x > 0)
                        {
                            G[i, r] = x;
                            x = 0;
                            r++;
                        }
                }
                G[i, r] = x;

            }
        }


        public void NomV()
        {            
            V = new int[n, (n / 2) + 1];
            for (j = 0; j < m; j++)
                {
                    int r = 0;
                    int x = 0;
                    for (i = m - 1; i >= 0; i--)
                    {
                        
                        if (T[i, j] == true)
                            x++;
                        else
                            if (x > 0)
                            {
                                V[j, r] = x;
                                x = 0;
                                r++;
                            }
                    }
                    V[j, r] = x;                 
                   
                }
            }

        public int PV(int i,int j)
        { 
            int r=V[i,j];
            return r;
        }

        public int PG(int i, int j)
        {
            int r = G[i, j];
            return r;
        }      
        


        }

    }


