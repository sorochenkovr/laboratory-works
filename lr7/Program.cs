using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace lr_7
{
    class Program
    {
        static void Main(string[] args)
        {
#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
#endif
            Geometry int1, int2;

#if !DEBUG
            int1 = Geometry.LoadNew();
            int1.Info();
            int2 = new Geometry(2, 4);
            int2.Info();
#endif
#if DEBUG
            int2 = new Geometry(5, 7);
            int2.Info(ConsoleColor.Green);
#endif
#if !DEBUG
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
#endif
#if DEBUG
            Console.ReadKey();
#endif
        }
    }

}