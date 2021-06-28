using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Les3Exercise2
{
    class Program
    {
        //Ронжин Л.
        //2. а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
        //Требуется подсчитать сумму всех нечётных положительных чисел.
        //Сами числа и сумму вывести на экран, используя tryParse.
        //б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
        // При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;
        static void Main(string[] args)
        {
            // Пункт б как я понимаю был выполнен еще на 1м уроке, где я заранее использовал tryParse
            MyMetods.Print("Введите целое число.");
            int n = MyMetods.ReadInt();
            int sum = 0;
            string str = n.ToString();
            do
            {
                if (n > 0 && (n % 2 != 0))
                    sum += n;
                MyMetods.Print("Введите следующее число.");
                n = MyMetods.ReadInt();
                str = str + ", " + n.ToString();
            }
            while (n != 0);
            Console.WriteLine($"Сумма всех нечетных положительных чисел из ряда: {str} составляет {sum}.");
            MyMetods.Pause();
        }
    }
}
