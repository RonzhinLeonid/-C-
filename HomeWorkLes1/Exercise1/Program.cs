using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Exercise1
{
    //Ронжин Леонид
    class Program
    {
        static void Main(string[] args)
        {
            /*  1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст,
               рост, вес). В результате вся информация выводится в одну строчку:
               а) используя склеивание;
               б) используя форматированный вывод;
               в) используя вывод со знаком $.          */
            #region
            //MyMetods cons = new MyMetods();
            MyMetods.Print("Укажите Ваше имя.");
            string name = Console.ReadLine();
            MyMetods.Print("Укажите Вашу фамилию.");
            string surName = Console.ReadLine();
            MyMetods.Print("Укажите Ваш возраст.");
            uint age = MyMetods.ReadUint();
            MyMetods.Print("Укажите Ваш вес в килограммах.");
            double weight = MyMetods.ReadDouble();
            MyMetods.Print("Укажите Ваш рост в метрах.");
            double growth = MyMetods.ReadDouble();
            //Вариант а
            Console.WriteLine("Вариант а.\nИмя: " + name + " Фамилия: " + surName + " Возраст: " + age + ", рост: " + growth + "м, вес: " + weight + "кг." );
            //Вариант б
            Console.WriteLine("Вариант б.\nИмя: {0} Фамилия: {1} Возраст: {2}, рост: {3}м, вес: {4}кг.", name, surName, age, growth, weight);
            //Вариант в
            Console.WriteLine($"Вариант в.\nИмя: {name} Фамилия: {surName} Возраст: {age}, рост: {growth}м, вес: {weight}кг.");
            MyMetods.Pause();

            #endregion
        }
    }
}
