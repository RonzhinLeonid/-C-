using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Les2Exercise2
{
    class Program
    {
        //2. Написать метод подсчета количества цифр числа.
        static void Main(string[] args)
        {
            MyMetods.Print("Введите целое положительное число.");
            long n = MyMetods.ReadLong();
            Console.WriteLine($"Количкество чисел в числе {n} - {MyMetods.CountNumber(n)}.");
            MyMetods.Pause();
        }

        
    }
}
