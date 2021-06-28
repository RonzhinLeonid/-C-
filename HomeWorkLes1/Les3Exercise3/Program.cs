using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Les3Exercise3
{
    class Program
    {
        //Ронжин Л.
        //3.*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
        //Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
        //Написать программу, демонстрирующую все разработанные элементы класса.
        //* Добавить свойства типа int для доступа к числителю и знаменателю; 
        //* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа; 
        //** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
        //*** Добавить упрощение дробей.
        static void Main(string[] args)
        {
            string mes1 = "Введите числитель 1й дроби";
            string mes2 = "Введите знаменатель 1й дроби";
            Ratio ratio1 = new Ratio(MyMetods.ReadInt(mes1), MyMetods.ReadInt(mes2));

            mes1 = "Введите числитель 2й дроби";
            mes2 = "Введите знаменатель 2й дроби";
            Ratio ratio2 = new Ratio();
            ratio2.M = MyMetods.ReadInt(mes1);
            ratio2.N = MyMetods.ReadInt(mes2);

            MyMetods.Print($"У Вас есть 2 дроби:{ratio1} и {ratio2}.");

            MyMetods.Print($"В десятичной форме данные дроби имеют вид: {ratio1.Des} и {ratio2.Des}.");

            Ratio rez;
            rez = Ratio.Simplification(Ratio.Sum(ratio1, ratio2));
            Console.WriteLine($"{ratio1} + {ratio2} = {rez}");

            rez = Ratio.Simplification(Ratio.Minus(ratio1, ratio2));
            Console.WriteLine($"{ratio1} - {ratio2} = {rez}");

            rez = Ratio.Simplification(Ratio.Multi(ratio1, ratio2));
            Console.WriteLine($"{ratio1} * {ratio2} = {rez}");

            rez = Ratio.Simplification(Ratio.Div(ratio1, ratio2));
            Console.WriteLine($"{ratio1} / {ratio2} = {rez}");

            MyMetods.Pause();
            }
    }
}
