using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_two
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

            double a, b, c, d, e;
            double s, k;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            e = Convert.ToDouble(Console.ReadLine());

            if ((15 * c - d <=0) || (b-c <=0))
                Console.WriteLine("ERROR");
            else
            {
                s = a/Math.Sqrt(b-c) + b/ Math.Sqrt(15*c-d);
                Console.WriteLine(String.Format("{0:0.000}", s));
            }

            if ((b == 0) || (3*d-e<=0))
                Console.WriteLine("ERROR");
            else 
            {
                k = a/b+c/Math.Sqrt(3*d-e);
                Console.WriteLine(String.Format("{0:0.00}", k));
            }
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}