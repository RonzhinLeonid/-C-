using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Les2Exercise7
{
   /*7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
        б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.*/
    class Program
    {
        static void Main(string[] args)
        {
            MyMetods.Print("Введите первое число.");
            int a = MyMetods.ReadInt();
            MyMetods.Print("Введите второе число.");
            int b = MyMetods.ReadInt();

            Console.WriteLine($"От a до b:              {MyMetods.RecPrint(a, b)}");
            Console.WriteLine($"От a до b(вар 2):       {MyMetods.RecPrintV2(a, b)}");
            Console.WriteLine($"Сумма от a до b:        {MyMetods.RecSum(a, b)}");
            Console.WriteLine($"Сумма от a до b(вар 2): {MyMetods.RecSumV2(a, b)}");
            MyMetods.Pause();
        }

       
    }
}
