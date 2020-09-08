using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Les4Exercise2
{
    class Program
    {
        //Ронжин Л.
        //2.Реализуйте задачу 1 в виде статического класса StaticClass;
        //  а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
        //  б) *Добавьте статический метод для считывания массива из текстового файла.
        //Метод должен возвращать массив целых чисел;
        //  в)**Добавьте обработку ситуации отсутствия файла на диске.
        static void Main(string[] args)
        {
            int n = 20;
            int x = 10000;
            int count;
            int[] arr = StaticClass.Add(n, x);
            MyMetods.Print($"Массив из {n} чисел от {-x} до {x}");
            StaticClass.PrintArray(arr);
            count = StaticClass.CountPairs(arr);
            Console.WriteLine($"Количество пар, в которых 2 элемента подряд делятся на 3, равно - {count}");
            Console.WriteLine("Запись в файл и получение маччива из него");
            // пункт б и в.
            StaticClass.SaveToFile("temp.txt", n, arr);
            StaticClass.PrintArray(StaticClass.AddFromFile("temp.txt"));
            Console.WriteLine("Чтение из несуществующего файла");
            try
            {
                StaticClass.PrintArray(StaticClass.AddFromFile("temp1.txt"));
            }
            catch  
            {
                Console.WriteLine("Файл не найден.");
            }
            MyMetods.Pause();
        }
    }
}
