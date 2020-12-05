using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr8
{
    class Мебель
    {
        public int Высота, Ширина;
        public Материалы Материал;

        public Мебель(int Выс, int Шир, Материалы Мтр)
        {
            Высота = Выс; 
            Ширина = Шир;
            Материал = Мтр;
        }

        public Мебель()
        {
            Высота = Convert.ToInt32("нет данных"); Ширина = Convert.ToInt32("нет данных");
        }

        public virtual string Инфо
        {
            get { return "Высота: " + Высота + "см, Ширина: " + Ширина + "см, Материал: " + Материал; }
        }
    }
    public enum Материалы
    {
        Дуб,
        Осина,
        Бук,
        Фанера,
        Плиты_древесно_стружечные,
        Другое
    }

    class Стол: Мебель
    {
       

        public Тип_Стола ТипС;

        public Стол()
           : base()
        {
            ТипС = Тип_Стола.Другое;
        }
        public Стол(int Выс, int Шир, Материалы Мтр, Тип_Стола Т)
        :base(Выс, Шир, Мтр)
        {
            ТипС = Т;
        }

        public override string Инфо
        {
            get
            {
                return base.Инфо + ", Тип: " + ТипС.ToString();
            }
        }

    }
    public enum Тип_Стола
    {
        Журнальный,
        Кухонный,
        Письменный,
        Компьюерный,
        Бюро,
        Другое
    }

    class Шкаф: Мебель
    {
        public Тип_двери ТипД;

        public Шкаф(int Выс, int Шир, Материалы Мтр, Тип_двери Тд)
        :base(Выс, Шир, Мтр)
        {
            ТипД = Тд;
        }

        public override string Инфо
        {
            get
            {
                return base.Инфо + ", Тип: " + ТипД.ToString();
            }
        }
    }
    public enum Тип_двери
    {
        Купе,
        Распашные_двери,
        Подъёмные_двери,
        Отрытые_шкафы,
        Другое
    }

    class МягкаяМебель : Мебель
    {


        public Тип_мебели ТипМ;
        public Мягкий_элемент МягкЭлем;

        public МягкаяМебель(int Выс, int Шир, Материалы Мтр, Тип_мебели Тм, Мягкий_элемент МЭл)
        : base(Выс, Шир, Мтр)
        {
            ТипМ = Тм;
            МягкЭлем = МЭл;
        }

        public override string Инфо
        {
            get
            {
                return base.Инфо + ", Тип: " + ТипМ.ToString() + ", Материал мягкого элемента: " + МягкЭлем.ToString();
            }
        }
    }
    public enum Тип_мебели
    {
        Диван_кровать,
        Диван,
        Кресла,
        Кушетки,
        Другое
    }
    public enum Мягкий_элемент
    {
        Синтепон,
        Пружинные_блоки,
        Поролон,
        Настилочный_материал,
        Другое
    }

}
