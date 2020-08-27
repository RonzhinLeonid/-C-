using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    //*Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).

    public class MyMetods
    {
        /// <summary>
        /// Расчет расстояния между двух точек.
        /// </summary>
        /// <param name="X1"></param>
        /// <param name="Y1"></param>
        /// <param name="X2"></param>
        /// <param name="Y2"></param>
        /// <returns></returns>
        public static double distance(double X1, double Y1, double X2, double Y2)
        {
            return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
        }
        /// <summary>
        /// Считывание целых чисел из консоли.
        /// </summary>
        /// <returns></returns>
        public static int ReadInt()
        {
            int str;
            while (!int.TryParse(Console.ReadLine(), out str))
            {
                Print("Попробуйте еще раз.");
            }
            return str;
        }
        /// <summary>
        /// Считывание вещественных чисел из консоли.
        /// </summary>
        /// <returns></returns>
        public static double ReadDouble()
        {
            double str;
            while (!double.TryParse(Console.ReadLine(), out str))
            {
                Print("Попробуйте еще раз.");
            }
            return str;
        }

        /// <summary>
        /// Пауза.
        /// </summary>
        public static void Pause()
        {
            Console.ReadKey();
        }
        /// <summary>
        /// Пауза с сообщением.
        /// </summary>
        /// <param name="msg"></param>
        public static void Pause(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }
        /// <summary>
        /// Вывод текста.
        /// </summary>
        /// <param name="msg"></param>
        public static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
        /// <summary>
        /// Вывод текста по координатам.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
        /// <summary>
        /// Вывод цветного текста по координатам.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="foregroundColor"></param>
        public static void Print(string msg, int x, int y, ConsoleColor foregroundColor)
        {
            Console.ForegroundColor = foregroundColor;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

    }
}
