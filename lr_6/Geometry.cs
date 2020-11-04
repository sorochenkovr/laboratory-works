using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_6
{
    class Geometry
    {
        private double x1, y1, x2, y2, l, l1, l2;
        
        public double GetLgth()
        {
            return
            l = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        public double GetLgth1()
        {
            return
            l1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
        }
        public double GetLgth2()
        {
            return
            l2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
        }
        public void Load()
        {
            x1 = Convert.ToDouble(Console.ReadLine());
            x2 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
        }
        public void Info()
        {
            Console.WriteLine(string.Format("Координата начала А ({0};{1}) \nКоордината конца В ({2};{3})", x1, y1, x2, y2));
            Console.WriteLine(string.Format("Длина отрезка AB {0:0.00}", GetLgth()));
            Console.WriteLine(string.Format("Расстояние АО = {0:0.00} \nРасстояние ВО = {1:0.00}", GetLgth1(), GetLgth2()));
        }

    }
}