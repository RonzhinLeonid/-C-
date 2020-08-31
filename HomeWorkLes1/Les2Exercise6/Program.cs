using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Les2Exercise6
{
    /*6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
     «Хорошим» называется число, которое делится на сумму своих цифр.
     Реализовать подсчёт времени выполнения программы, используя структуру DateTime.*/
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            int count = 0;
            for (int i = 1; i <= 1000000000; i++)
            {
                if (i % MyMetods.SumNumber(i) == 0)
                    count++;
            }
            Console.WriteLine($"Количество хороших чисел в диапазоне от 1 до 1000 000 000 составляет {count}.");
            Console.WriteLine($"Время на выполнение программы: {DateTime.Now - start}.");
            MyMetods.Pause();
        }
    }
}
