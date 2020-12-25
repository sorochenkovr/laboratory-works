using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lr11
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader f_in = new StreamReader("lr11_25.csv");

#if !DEBUG 
            TextWriter save_out = Console.Out;
            var new_out = new StreamWriter(@"lr11_output.txt");
            Console.SetOut(new_out);
#endif
            List<Person> all = new List<Person>();

                String line = f_in.ReadLine();
                while ((line = f_in.ReadLine()) != null)
                {
                    all.Add(Person.Load(line));
                }

            /*Console.WriteLine("All users: {0}", all.Count);
            foreach (var p in all)
                Console.WriteLine(p);*/


            Console.WriteLine("*** Task 1 ***");
            float max = 0;
            Person rich = new Person();
            foreach (var m in all)
            {
                
                float t = m.salary - m.Tax;
                if (max < t)
                { max = t;
                    rich = m;
                }
            }
            Console.WriteLine("Сотрудник с максимальной зарплатой после уплаты налога:\n{0}\n", rich);
            float min = max;
            Person poor = new Person();
            foreach (var n in all)
            {

                float t2 = n.salary - n.Tax;
                if (min > t2)
                {
                    min = t2;
                    poor = n;
                }
            }
            Console.WriteLine("Сотрудник с минимальной зарплатой после уплаты налога:\n{0}\n", poor);


            Console.WriteLine("*** Task 2 ***");
            float sal = (from p in all
                          where p.Skill != "None"
                          select p.salary).Average();
            Console.WriteLine("Средняя з/п сотрудников без указанного навыка: {0}\n", sal);


            Console.WriteLine("*** Task 3 ***");
            int mail = all.FindAll(p => p.email != "None").ToList().Count;
            Console.WriteLine("Количество сотрудников с e-mail: {0}\n", mail);


            Console.WriteLine("*** Task 4 ***");
            float salar = (from p in all
                           select p.salary).Average();
            int vse = all.Count();
            Console.WriteLine("Чтобы рассчитать ОФЗП нужно среднюю з/п (${0}) " +
            "умножить на кол-во сотрудников ({1}) и на 12 месяцев", salar, vse);
            Console.WriteLine("Объем фонда заработной платы = {0}", salar*vse*12);


#if !DEBUG
            Console.SetOut(save_out);
            new_out.Close();
#else
            Console.ReadKey();
#endif
        }
    }
}
