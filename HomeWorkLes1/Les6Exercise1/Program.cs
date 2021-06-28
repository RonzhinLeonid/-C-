using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Les6Exercise1
{
    //Ронжин Л.
    //1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
    //Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).
    public delegate double Fun(double x, double a);
    class Program
    {
        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        public static void Table(Fun F, double a, double start, double end)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (start <= end)
            {
                Console.WriteLine($"| {start,8:0.000} | {F(start, a),8:0.000} |");
                start += 0.5;
            }
            Console.WriteLine("---------------------");
        }
        // Методы для передачи его в качестве параметра в Table
        public static double MyFuncPow(double x, double a)
        {
            return a * Math.Pow(x,2);
        }
        public static double MyFuncSin(double x, double a)
        {
            return a * Math.Sin(x);
        }

        static void Plot(List<Fun> t, double a, double start, double end)
        {
            for (int i = 0; i < t.Count; i++)
            {
                for (double x = start; x <= end; x += 0.5)
                {
                    //Console.WriteLine($"y = {x*x} + {x}");
                    Console.WriteLine($"f({x,3},{a,3} ) = {t[i](x, a),5:0.000}");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }


        static void Main()
        {
            // Создаем новый делегат и передаем ссылку на него в метод Table
            Console.WriteLine("Таблица функции MyFunc:");
            // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
            Table(new Fun(MyFuncPow), 5, -2, 2);
            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
            // Упрощение(c C# 2.0).Делегат создается автоматически.            
            Table(MyFuncPow, 5, -2, 2);
            Console.WriteLine("Таблица функции a*Sin:");
            Table(MyFuncSin, 5, -2, 2);      // Можно передавать уже созданные методы
            Console.WriteLine("Таблица функции a*x^2:");
            //Упрощение(с C# 2.0). Использование анонимного метода
            Table(delegate (double x, double a) { return a * x * x; }, 5, 0, 3);
            //Список методов в делегате
            Console.WriteLine("Работа делегата со списком методов:");
            List<Fun> methods = new List<Fun>() { MyFuncPow };
            methods.Add(MyFuncSin);
            Plot(methods, 5, 0, 3);

            MyMetods.Pause();
        }

    }
}
