using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5.а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
                б) *Сделать задание, только вывод организовать в центре экрана.
                в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int
                x,int y).*/
            #region
            MyMetods.Print("Леонид Ронжин, город Санкт-Петербург.");

            int row = Console.CursorTop;

            Console.SetCursorPosition(40, ++row);
            MyMetods.Print("Леонид Ронжин, город Санкт-Петербург.");
            MyMetods.Print("Леонид Ронжин, город Санкт-Петербург.", 40, row += 2);
            MyMetods.Print("Леонид Ронжин, город Санкт-Петербург.", 40, row += 2, ConsoleColor.Red);
            MyMetods.Pause();
            #endregion
        }
    }
}
