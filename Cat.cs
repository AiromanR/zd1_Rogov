using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd1_Rogov
{
    internal class Cat
    {
        private string name;
        public string Name
        {
            get{ return name; }
            set
            {
                bool OnlyLetters = true; //проверка на наличие букв
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }
                if (OnlyLetters)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }
            }
        }
        private double weight;
        public double Weight // Установка свойства вес с проверками
        {
            get { return weight; }
            set
            {
                if (value == 0) 
                {
                    Console.WriteLine("Вес не должен быть нулевым");
                }
                else if (value < 0)
                {
                    Console.WriteLine("Вес не должен быть отрицательным");
                }
                else
                {
                    weight = value;
                }
            }
        }
        public Cat(string CatName)
        {
            Name = CatName;
        }
        public void Meow() //добавил отображение веса
        {
            Console.WriteLine($"{name}: МЯЯЯЯУ!!!! Вес: {weight}");
        }

        //public void SetCatName(string CatName)
        //{

        //    bool OnlyLetters = true;

        //    foreach (var ch in CatName)
        //    {
        //        if (!char.IsLetter(ch))
        //        {
        //            OnlyLetters = false;
        //        }
        //    }

        //    if (OnlyLetters)
        //        name = CatName;
        //    else
        //        Console.WriteLine($"{CatName} - неправильное имя!!!");
        //}
    }
}
