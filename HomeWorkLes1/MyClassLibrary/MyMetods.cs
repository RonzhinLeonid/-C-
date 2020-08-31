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
<<<<<<< HEAD
        /// Считывание целых чисел из консоли.
        /// </summary>
        /// <returns></returns>
        public static long ReadLong()
        {
            long str;
            while (!long.TryParse(Console.ReadLine(), out str))
            {
                Print("Попробуйте еще раз.");
            }
            return str;
        }
        /// <summary>
         /// Считывание целых положительных чисел из консоли.
         /// </summary>
         /// <returns></returns>
        public static uint ReadUint()
        {
            uint str;
            while (!uint.TryParse(Console.ReadLine(), out str))
            {
                Print("Попробуйте еще раз.");
            }
            return str;
        }
        /// <summary>
=======
>>>>>>> Lesson1
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
<<<<<<< HEAD
        /// <summary>
        /// Максимальное число из 3х
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public static double MaxNumber(double a, double b, double c)
        {
            double max;
            if (a > b && a > c) max = a;
            else if (b > c) max = b;
            else max = c;
            return max;
        }
        /// <summary>
        /// Минимальное число из 3х
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public static double MinNumber(double a, double b, double c)
        {
            double min;
            if (a < b && a < c) min = a;
            else if (b < c) min = b;
            else min = c;
            return min;
        }
        /// <summary>
        /// Количество цифр в числе
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int CountNumber(long n)
        {
            int count = 0;
            while (n > 0)
            {
                count++;
                n /= 10;
            }
            return count;
        }
        /// <summary>
        /// Сумма чисел числа
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int SumNumber(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
        /// <summary>
        /// Сумма от a до b рекурсией
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static int RecSum(int a, int b)
        {
            if (a == b)
                return a;
            else
                return b + RecSum(a, b - 1);
        }
        /// <summary>
        /// Сумма от a до b рекурсией, вариант 2
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int RecSumV2(int a, int b)
        {
            if (a == b)
                return b;
            else
                return a + RecSumV2(a + 1, b);
        }
        
        /// <summary>
        /// вывод на экран от а до б рекурсией
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string RecPrint(int a, int b)
        {
            if (a == b)
                return b.ToString();
            else
                return a + ", " + RecPrint(a + 1, b);
        }
        /// <summary>
        /// вывод на экран от а до б рекурсией, вариант 2
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string RecPrintV2(int a, int b)
        {
            if (a == b)
                return a.ToString();
            else
                return RecPrintV2(a, b - 1) + ", " + b;
        }
    }

=======

    }
>>>>>>> Lesson1
}
