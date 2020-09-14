using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;
using System.IO;

namespace Les6Exercise2
{
    //Сергей, можете прояснить по данной строке fs.Length / sizeof(double), я так понимаю Length берет размер файла в битах,
    //и далее мы приводим его к размеру хранящихся данных (double) и получаем кол-во данных, верно?
    //и момент по заданию, массив значений получен, но выводить в консоль закоментировал.

    //Ронжин Л.
    //2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. ++
    //а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
    //Использовать массив(или список) делегатов, в котором хранятся различные функции.
    //б) * Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум через параметр
    //(с использованием модификатора out). 

    class Program
    {
        public delegate double Fun(double x);
        public static double FunQuadratic(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double FunPow3(double x)
        {
            return Math.Pow(x,3);
        }

        public static void SaveFunc(Fun F, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double[] Load(string fileName, out double min)
        {
           
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double[] temp = new double[fs.Length / sizeof(double)];
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                temp[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return temp;
        }

        static void Main(string[] args)
        {
            List<Fun> methods = new List<Fun>() { FunQuadratic, FunPow3, Math.Sin, Math.Cos };
            
            Console.WriteLine("В программе заложены четыре функции:\n1. x^2 - 50x + 10\n2. x^3\n3. Sin(x)\n4. Cos(x)\n");
            int num = MyMetods.ReadInt("Укажите номер функции которую хотите использовать")- 1;
            try
            {
                SaveFunc(methods[num], "data.bin", -100, 100, 0.5);
                double[] arr = Load("data.bin", out double min); //Массив считанных значений.
                Console.WriteLine(min);
                //Вывод массива в консоль
                //for (int i = 0; i < arr.Length; i++)
                //{
                //    Console.WriteLine(arr[i]);
                //}
            }
            catch (Exception)
            {
                Console.WriteLine("Вы указали несуществующий номер функции.");
            }

            MyMetods.Pause();
        }
    }
}
