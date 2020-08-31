using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3.а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,
                y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат,
                используя спецификатор формата .2f (с двумя знаками после запятой);
                б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде
                метода.*/
            #region
            MyMetods.Print("Укажите координату X1.");
            double x1 = MyMetods.ReadDouble();
            MyMetods.Print("Укажите координату Y1.");
            double y1 = MyMetods.ReadDouble();
            MyMetods.Print("Укажите координату X2.");
            double x2 = MyMetods.ReadDouble();
            MyMetods.Print("Укажите координату Y2.");
            double y2 = MyMetods.ReadDouble();
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Вариант а.\nРасстояние между точками составляет : {r:f}.");
            Console.WriteLine($"Вариант б.\nРасстояние между точками составляет : {MyMetods.distance(x1, y1, x2, y2):f}.");
            MyMetods.Pause();
            #endregion
        }
    }
}
