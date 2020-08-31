using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Les2Exercise3
{
    class Program
    {
        //3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        static void Main(string[] args)
        {
            MyMetods.Print("Введите целое число.");
            int n = MyMetods.ReadInt();
            int sum = 0;
            do
            {
                if (n > 0 && (n % 2 != 0))
                    sum += n;
                MyMetods.Print("Введите следующее число.");
                n = MyMetods.ReadInt();
            }
            while (n != 0);
            Console.WriteLine($"Сумма всех нечетных положительных чисел введенных с клавиатуры - {sum}.");
            MyMetods.Pause();
        }
    }
}
