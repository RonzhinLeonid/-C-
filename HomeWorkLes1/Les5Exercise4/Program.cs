using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;


namespace Les5Exercise4
{
    class Program
    {
        //Ронжин Л.
        //4. *Задача ЕГЭ.
        //На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы.
        //В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100,
        //каждая из следующих N строк имеет следующий формат:
        //<Фамилия> <Имя> <оценки>,
        //где<Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более чем из 15 символов,
        //<оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе. <Фамилия> и<Имя>,
        //а также <Имя> и<оценки> разделены одним пробелом. Пример входной строки:
        //Иванов Петр 4 5 3
        //Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена
        //трёх худших по среднему баллу учеников.Если среди остальных есть ученики, набравшие тот же средний балл,
        //что и один из трёх худших, следует вывести и их фамилии и имена.

        static void Main()
        {
            string[,] arr = Students.ReadFile("GradesList.txt");

            Students[] Student = new Students[arr.GetLength(0)];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Student[i] = new Students()
                {
                    name = arr[i, 0],
                    suname = arr[i, 1],
                    rating1 = arr[i, 2],
                    rating2 = arr[i, 3],
                    rating3 = arr[i, 4]
                };
            }
            Console.WriteLine("Список студентов и средний бал:");
            for (int i = 0; i < arr.GetLength(0); i++) Console.WriteLine($"{Student[i].SunameAndName} - {Student[i].Score}");
            Console.WriteLine();
            Console.WriteLine("Список трёх худших студентов и их средний бал\n" +
                "Так же будут выведены студенты у которых средний бал такой же как у трёх худших:");
            Students.MinScore(Student);

            MyMetods.Pause();
        }

        
    }
}
