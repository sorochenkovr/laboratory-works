using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_7
{
    class Geometry
    {
        private double a, b, i, l;
        private Geometry() { }
        public Geometry(double A, double B) 
        {
            a = A;
            b = B;
        }

        public double GetIntegral()
        {
            return
            i = Math.Pow(b, 2)/2 - Math.Pow(a, 2)/2;
        }

        public double GetLgth()
        {
            return
            l = Math.Sqrt(Math.Pow(b - a, 2) + Math.Pow(b - a, 2));
        }
 
        public void Load()
        {
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
        }
        public static Geometry LoadNew() 
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            return new Geometry(x, y);
        }
        public void Info()
        {
            Console.WriteLine(string.Format("a = {0} \nb = {1}", a, b));
            Console.WriteLine(string.Format("Интеграл = {0:0.00}", GetIntegral()));
            Console.WriteLine(string.Format("Длина отрезка a, y(a) до b, y(b) = {0:0.00}", GetLgth()));
        }
        public void Info(ConsoleColor bcgrc)
        {
            Console.BackgroundColor = bcgrc;
            Console.Clear();
            Info();
        }

    }
}