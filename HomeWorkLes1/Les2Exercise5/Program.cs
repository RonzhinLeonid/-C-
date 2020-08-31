using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Les2Exercise5
{
    /*5.а) Написать программу, которая запрашивает массу и рост человека,
     вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.*/
    class Program
    {
        static void Main(string[] args)
        {
            #region
            double defIMB = 18.5; //верхний придел ИМТ при дефиците
            double normIMB = 25; //верхний придел ИМТ при норме
            double excIMB = 30; // верхний придел ИМТ при избыт. массе тела
            double obesity1IMB = 35; //верхний придел ИМТ при ожирении 1ст
            double obesity2IMB = 40; //верхний придел ИМТ при ожирении 2ст, все что выше ожирение 3ст

            MyMetods.Print("Укажите Ваш вес в килограммах.");
            double weight = MyMetods.ReadDouble();
            MyMetods.Print("Укажите Ваш рост в метрах.");
            double growth = MyMetods.ReadDouble();
            double indexBodyMass = weight / (Math.Pow(growth, 2));

            if (indexBodyMass < defIMB)
            {
                MyMetods.Print("У Вас дефицит массы тела.");
                ChangeMass(normIMB, defIMB, weight, growth);
            }
            else if (indexBodyMass >= defIMB && indexBodyMass < normIMB)
                MyMetods.Print("У Вас нормальная масса тела.");
            else if (indexBodyMass >= normIMB && indexBodyMass < excIMB)
            {
                MyMetods.Print("У Вас избыточная масса тела.");
                ChangeMass(normIMB, defIMB, weight, growth);
            }
            else if (indexBodyMass >= excIMB && indexBodyMass < obesity1IMB)
            {
                MyMetods.Print("У Вас ожирение | степени.");
                ChangeMass(normIMB, defIMB, weight, growth);
            }
            else if (indexBodyMass >= obesity1IMB && indexBodyMass < obesity2IMB)
             {
                MyMetods.Print("У Вас ожирение || степени.");
                ChangeMass(normIMB, defIMB, weight, growth);
            }
            else
            {
                MyMetods.Print("У Вас ожирение ||| степени.");
                ChangeMass(normIMB, defIMB, weight, growth);
            }

            #endregion
            MyMetods.Pause();
        }

        private static void ChangeMass(double normIMB, double defIMB, double weight, double growth)
        {
            double weightMin = defIMB * Math.Pow(growth, 2);
            double weightMax = normIMB * Math.Pow(growth, 2);
            if (weight < weightMin)
                Console.WriteLine($"Для нонрмализации веса Вам рекомендуется набрать от {Math.Min(weightMax, weightMin) - weight:N1} до {Math.Max(weightMax, weightMin) - weight:N1}кг.");
            else
                Console.WriteLine($"Для нонрмализации веса Вам рекомендуется сбросить от {weight - Math.Max(weightMax, weightMin):N1} до {weight - Math.Min(weightMax, weightMin):N1}кг.");
        }
    }
}
