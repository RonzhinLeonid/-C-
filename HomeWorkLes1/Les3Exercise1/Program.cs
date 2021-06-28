using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Les3Exercise1
{
    class Program
    {
        //Ронжин Л.
        //1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
        //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
        //в) Добавить диалог с использованием switch демонстрирующий работу класса.
        static void Main(string[] args)
        {
            string mes1 = "Введите вещественную часть 1го числа";
            string mes2 = "Введите мнимую часть 1го числа";
            Complex complex1 = new Complex(MyMetods.ReadInt(mes1), MyMetods.ReadInt(mes2));
 
            //Console.WriteLine(complex1);
            mes1 = "Введите вещественную часть 2го числа";
            mes2 = "Введите мнимую часть 2го числа";
            Complex complex2 = new Complex(MyMetods.ReadInt(mes1), MyMetods.ReadInt(mes2));

            //Console.WriteLine(complex2);
            Complex rez;

            MyMetods.Print($"У Вас есть 2 комплексных числа {complex1} и {complex1}.\n" +
                $"Вы можете их сложить, найти их разницу или умножить.\n" +
                $"Введите соответствующий символ.\n" +
                $"\"+\" - для сложения,\n\"-\" - для нахождения разницы,\n\"*\" - для умножения.");

            string sym = Console.ReadLine();
            switch (sym)
            {
                case "+":
                rez = Complex.Sum(complex1, complex2);
                Console.WriteLine($"({complex1}) {sym} ({complex2}) = {rez}");
                    break;
                case "-":
                rez = Complex.Subtraction(complex1, complex2);
                Console.WriteLine($"({complex1}) {sym} ({complex2}) = {rez}");
                    break;
                case "*":
                rez = Complex.Multi(complex1, complex2);
                Console.WriteLine($"({complex1}) {sym} ({complex2}) = {rez}");
                    break;
                default:
                    MyMetods.Print("Вы выбрали несуществующее действие, программа ничего не выполнила.");
                    break;
            }

            
            MyMetods.Pause();
        }
    }
}
