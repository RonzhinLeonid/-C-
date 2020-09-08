using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Les4Exercise1
{
    class Program
    {
        //Ронжин Л.
        //1. Дан целочисленный массив из 20 элементов.
        //Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
        //Заполнить случайными числами.
        //Написать программу, позволяющую найти и вывести количество пар элементов массива,
        //в которых только одно число делится на 3. В данной задаче под парой подразумевается
        //два подряд идущих элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 

        //Несовсем понял, что требуется в данной задаче, написано сначало "кол-во пар, в которых только одно число делится на 3",
        //а далее описание пары где это "2 подряд элемента делящихся на 3". Сдела как по втрому варианту.
        static void Main(string[] args)
        {
            int n = 20; 
            int[] arr = new int[n];
            int x = 10000;
            int count = 0;
            Random rand = new Random();
            MyMetods.Print($"Массив из {n} чисел от {-x} до {x}"); 
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(x * (rand.NextDouble() * 2 - 1));
                Console.WriteLine($"{i} - {arr[i]}");
            }
            Console.WriteLine();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"{i} - {arr[i]%3}");
            //}
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] % 3 == 0 && arr[i] % 3 == 0)
                    count++;
                //Console.WriteLine($"{i} - {arr[i]}");
            }
            Console.WriteLine($"Количество пар, в которых 2 элемента подряд делятся на 3, равно - {count}");
            MyMetods.Pause();
        }
    }
}
