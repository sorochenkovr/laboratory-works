using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Продажа котят и щенков";

            Kittens k = new Kittens("сиамские котята", 3);
            k.Mult_1(1000); //цена в рублях
            k.Mult_2(75); //цена в долларах
            k.DrawAnimal();
            Console.WriteLine("\n \n \n");

            Puppies p = new Puppies("щенки корги", 5);
            p.Mult_1(850);
            p.Mult_2(75);
            p.DrawAnimal();
            Console.ReadKey();
        }
    }
}
