using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2.Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по формуле
                 I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.*/
            #region
            MyMetods.Print("Укажите Ваш вес в килограммах.");
            double weight = MyMetods.ReadDouble();
            MyMetods.Print("Укажите Ваш рост в метрах.");
            double growth = MyMetods.ReadDouble();
            double indexBodyMass = weight / (Math.Pow(growth, 2));
            Console.WriteLine($"Ваш индекс массы тела (ИМТ), при росте {growth} и весе {weight}, составляет: {indexBodyMass}.");
            MyMetods.Pause();
            #endregion
        }
    }
}
