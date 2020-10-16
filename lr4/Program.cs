using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr4
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

            int N = Convert.ToInt32(Console.ReadLine());
            String str_all = Console.ReadLine();
            string[] str_elem = str_all.Split(' ');

            int[] mas = new int[N];
            for (int i = 0; i<N; i++)
            {
                mas[i] = Convert.ToInt32(str_elem[i]);
            }

            int x = 0, max = mas[0];
            for (int i = 0; i < N; i++)
            {
                if (mas[i] % 10 == 0)
                {
                    x++;
                    if (mas[i] > max)
                    {
                        max = mas[i];
                    }
                }
            }
            if(x == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(max);
            }

            Console.WriteLine("\n");
            int y = 0, min = mas[0];
            for (int i = 0; i < N; i++)
            {
                if (mas[i] % 100 == 0)
                {
                    y++;
                    if (mas[i] < min)
                    {
                        min = mas[i];
                    }
                }
            }
            if (y == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(min);
            }

            Console.WriteLine("\n");
            for (int i = 0; i < N; i++)
            {
                if (mas[i] % 2 == 0)
                {
                    Console.WriteLine("ч");
                }
                else
                {
                    Console.WriteLine("нч");
                }

            }

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}
