using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. Написать программу обмена значениями двух переменных:
                а) с использованием третьей переменной; */
            #region
            MyMetods.Print("Вариант а.\nУкажите 1ю переменную.");
            int a = MyMetods.ReadInt();
            MyMetods.Print("Укажите 2ю переменную.");
            int b = MyMetods.ReadInt();
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"Первая переменная: {a}.\nВторая переменная: {b}.");

            /* б) *без использования третьей переменной. */
            MyMetods.Print("\nВариант б. Те же значения обратно.");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Первая переменная: {a}.\nВторая переменная: {b}.");
            MyMetods.Pause();
            #endregion
        }
    }
}
