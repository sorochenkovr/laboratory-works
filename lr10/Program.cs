using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            float x, x2;
            Matrix m = new Matrix();
            m.GenerateMat(10, 5);
            m.SaveMat("FileForFirstMatrix.txt");
            x = m.SummMat("FileForFirstMatrix.txt");
           

            Matrix m2 = new Matrix();
            m2.GenerateMat(7, 6);
            m2.SaveMat("FileForSecondMatrix.txt");
            x2 = m.SummMat("FileForSecondMatrix.txt");

            Console.WriteLine("Разность сумм элементов матриц = {0}", (x + x2));
            Console.ReadKey();
        }
    }
}
