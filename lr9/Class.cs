using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr9
{
    public class Kittens : ICalculate, IVisual
    {
        private string KBreed;
        private int KNumber;

        public Kittens(string pKBreed, int pKN)
        {
            KBreed = pKBreed;
            KNumber = pKN;
        }

        public string Species
        {
            get
            {
                return "Все " + KBreed + " стоят " + KNumber + "$";
            }
        }

        public void DrawAnimal()
        {
            Console.WriteLine(
"^     ^\n" +
"= °w° =\n");
            Console.WriteLine(Species);
        }

        public void Mult_1(int Mult1)
        {
            KNumber *= Mult1;
        }

        public void Mult_2(int Mult2)
        {
            KNumber *= Mult2;
        }
    }
    public class Puppies : ICalculate, IVisual
    {
        private string PBreed;
        private int PNumber;

        public Puppies(string pPBreed, int pPN)
        {
            PBreed = pPBreed;
            PNumber = pPN;
        }

        public string Species
        {
            get
            {
                return "Все " + PBreed + " стоят " + PNumber + "$";
            }
        }

        public void DrawAnimal()
        {
            Console.WriteLine(
" U °A° U\n" +
"   ---\n");
            Console.WriteLine(Species);
        }

        public void Mult_1(int Mult1)
        {
            PNumber *= Mult1;
        }

        public void Mult_2(int Mult2)
        {
            PNumber *= Mult2;
        }

    }

}