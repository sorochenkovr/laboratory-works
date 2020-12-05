using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr8
{
    class Program
    {
        static void Main(string[] args)
        {
            Мебель[] mas = new Мебель[5];
            mas[0] = new Мебель (50, 78, Материалы.Осина);
            mas[1] = new Стол(70, 150, Материалы.Бук, Тип_Стола.Компьюерный);
            mas[2] = new Шкаф(200, 80, Материалы.Фанера, Тип_двери.Отрытые_шкафы);
            mas[3] = new МягкаяМебель(100, 200, Материалы.Плиты_древесно_стружечные, Тип_мебели.Диван, Мягкий_элемент.Пружинные_блоки);
            mas[4] = new МягкаяМебель(80, 100, Материалы.Другое, Тип_мебели.Кресла, Мягкий_элемент.Поролон);

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(">>>>>> " + mas[i].GetType().Name + " <<<<<<");
                Console.WriteLine(mas[i].Инфо);
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
