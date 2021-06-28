using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using MyClassLibrary;

namespace Les2Exercise1
{
    class Program
    {
        //1. Написать метод, возвращающий минимальное из трёх чисел.
        static void Main(string[] args)
        {
            MyMetods.Print("Введите первое число.");
            double a = MyMetods.ReadDouble();
            MyMetods.Print("Введите второе число.");
            double b = MyMetods.ReadDouble();
            MyMetods.Print("Введите третье число.");
            double c = MyMetods.ReadDouble();
            Console.WriteLine($"Максимальное число из {a}, {b} и {c} - {MyMetods.MaxNumber(a, b, c)}.");
            Console.WriteLine($"Минимальное число из {a}, {b} и {c} - {MyMetods.MinNumber(a, b, c)}.");
            MyMetods.Pause();
        }


    }
}
