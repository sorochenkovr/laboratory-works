using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr3
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            int N = 1;
            double X = 0, Y = 0, Z = 0;
            N = Convert.ToInt32(Console.ReadLine());
            X = Convert.ToDouble(Console.ReadLine());
            Y = Convert.ToDouble(Console.ReadLine());

            int i = 1;

                for (i = 1; i <= N; i++)
                {

                    if (i % 2 == 0)
                    {
                        Z -= (Math.Pow(Math.Cos(Y), i*(i - 1)) * Math.Pow(X, i * 2)) / i * 2;
                    }
                    else
                    {
                        Z += (Math.Pow(Math.Sin(X), i*(i - 1)) * Math.Pow(Y, i * 2)) / i * 2;
                    }

                }

            Console.WriteLine(String.Format("{0:0.00}", Z));

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}
