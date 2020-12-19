using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr10
{
    class Matrix
    {
        private float[,] mat;
        int m, n;
        public Matrix() { }
        public void GenerateMat(int M, int N) 
        {
            m = M; n = N;
            Random r = new Random(DateTime.Now.Millisecond);
            mat = new float[M, N];
            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    mat[i, j] = (float)r.Next(1000) / 973f;
        }

        public void SaveMat(string pFileName) 
        {
            if (mat.Length > 0)
            {
                if (File.Exists(pFileName))
                    File.Delete(pFileName);

                FileInfo f = new FileInfo(pFileName);
                TextWriter tw = f.CreateText();

                tw.WriteLine(m.ToString());
                tw.WriteLine(n.ToString());

                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                        tw.WriteLine(i.ToString() + " " + j.ToString() + " " + mat[i, j].ToString("E10"));
                tw.Close();
            
            }
        }

        public float SummMat(string pFileName) 
        {
            float sub = 0;
            if (File.Exists(pFileName))
            {
                TextReader tr = File.OpenText(pFileName);
                m = Convert.ToInt32(tr.ReadLine());
                n = Convert.ToInt32(tr.ReadLine());
                
                mat = new float[m, n];
                string line;
                string[] substring;
                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                    {
                        line = tr.ReadLine();
                        substring = line.Split(new char[] { ' ' }, 3);
                        mat[i, j] = Convert.ToSingle(substring[2]);
                    }

                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                    {
                        sub += mat[i, j];
                    }

                        tr.Close();
                return sub;
            }
            return 0;
        }

    }
}
