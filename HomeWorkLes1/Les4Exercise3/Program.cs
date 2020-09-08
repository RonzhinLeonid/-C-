using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Les4Exercise3
{
    //Ронжин Л.
    //  а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, 
    //создающий массив определенного размера и заполняющий массив числами от начального 
    //значения с заданным шагом.Создать свойство Sum, которое возвращает сумму элементов массива,
    //метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива
    //(старый массив, остается без изменений),  метод Multi, умножающий каждый элемент массива
    //на определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
    //  б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
    //  е) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)

    //В свойство насколько блоьшой код целесообразно помещать?
    //Не совсем правильно понял пункт е, мы его вроде решили на уроке, сделал его по аналогии с небольшими правками, 
    //но думаю данный метод будет не универсален. Как миниму что я вижу от подсчитается массив от 0 до Мах.
    //Отрицательные выдадут ошибку индекса 
    class Program
    {
        static void Main(string[] args)
        {
            MyList my = new MyList(1, 3, 5);
            for (int i = 0; i < my.Count; i++)
            {
                Console.WriteLine($"{i} - {my[i]}");
            }
            Console.WriteLine($"Сумма элементов массива - {my.Sum}");

            Console.WriteLine("Инверсия.");
            int[] arr = my.Inverse(my.Count);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i} - {arr[i]}");
            }
            Console.WriteLine("Умноение массива на число.");
            my.Multi(-2);
            for (int i = 0; i < my.Count; i++)
            {
                Console.WriteLine($"{i} - {my[i]}");
            }
            MyList my2 = new MyList();
            my2.Add(2, -3, 5, 7, 11, 23, 17, 19, 23);
            Console.WriteLine($"Кол-во максимальных элементов массива - {my2.MaxCount}");
            Console.WriteLine();
            Console.WriteLine("Подсчет количества вхождений.");
            int[] counter = new int[my2.Max+1];
            for (int i = 0; i < my2.Count; i++)
            {
                int index = my2[i];
                counter[index]++;
            }
            for (int i = 0; i < counter.Length; i++)
            {
                Console.WriteLine($"{i} - {counter[i]}");
            }
            MyMetods.Pause();
        }
    }
}
