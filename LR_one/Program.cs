using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа #1");
            Console.WriteLine("");
            Console.WriteLine("Выполнена: Сороченко В.Р.");
            Console.WriteLine("Группы: ИНС-б-о-191(2)");
            Console.WriteLine("Дата рождения: 16.08.2001");
            Console.WriteLine("Наименование ЛР: Структура консольного приложения");
            Console.WriteLine("");
            Console.WriteLine("Город: Ставрополь");
            Console.WriteLine("Любимый предмет: литература");
            Console.WriteLine("Хобби: видеоигры");
            Console.WriteLine("");
            Console.WriteLine("");

            float rx = 13, z = 46, Y = 21;
            float U;

            string str = "Вариант #25";

            Console.WriteLine(str);
            Console.WriteLine("Значение переменной rx равно {0},", rx);
            Console.WriteLine("значение переменной z равно {0},", z);
            Console.WriteLine("а значение переменной Y равно {0}", Y);
            Console.WriteLine("значение U равно {0}*{1}+{1}*{2}-({2}+{1})/{0}={3}", rx, z, Y, rx*z+z*Y-(Y+z)/rx);

            Console.WriteLine("для завершения работы программы нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
