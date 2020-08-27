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
            int age = MyMetods.ReadInt();
            //Вариант а
            Console.WriteLine("Вариант а.\nИмя: " + name + " Фамилия: " + surName + " Возраст: " + age);
            //Вариант б
            Console.WriteLine("Вариант б.\nИмя: {0} Фамилия: {1} Возраст: {2}", name, surName, age);
            //Вариант в
            Console.WriteLine($"Вариант в.\nИмя: {name} Фамилия: {surName} Возраст: {age}");
            MyMetods.Pause();

            #endregion
        }
    }
}
