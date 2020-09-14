using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;
using System.IO;

namespace Les6Exercise3
{
    //Сергей сделал метода для сортировки по 2м поялм в виде MyDelegatСourseAge, правильно ли так?
    //или возможно это как то красивее? как быть если по 3м и более полям надо отсортировать?


    //Ронжин Л.
    //3. Переделать программу Пример использования коллекций для решения следующих задач:
    //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
    //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
    //в) отсортировать список по возрасту студента; 
    //г) * отсортировать список по курсу и возрасту студента; 
    class Program
    {
        static int MyDelegatName(Student st1, Student st2)          // Создаем метод для сравнения для экземпляров
        {

            return String.Compare(st1.firstName, st2.firstName);          // Сравниваем две строки
        }
        static int MyDelegatAge(Student st1, Student st2)          // Создаем метод для сравнения для экземпляров
        {

            return String.Compare(st1.age.ToString(), st2.age.ToString());          // Сравниваем две строки
        }
        static int MyDelegatСourse(Student st1, Student st2)          // Создаем метод для сравнения для экземпляров
        {

            return String.Compare(st1.course.ToString(), st2.course.ToString());          // Сравниваем две строки
        }
        static int MyDelegatСourseAge(Student st1, Student st2)          // Создаем метод для сравнения для экземпляров
        {
            int ires = String.Compare(st1.course.ToString(), st2.course.ToString());
            if (ires == 0)
            {
                    ires = String.Compare(st1.age.ToString(), st2.age.ToString());
            }
            return ires;        // Сравниваем две строки
        }
        static void Main(string[] args)
        {
            int bakalavr = 0;
            int magistr = 0;
            List<Student> list = new List<Student>();                             // Создаем список студентов
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("students_6.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    // Одновременно подсчитываем количество бакалавров и магистров
                    if (int.Parse(s[6]) < 5) bakalavr++; else magistr++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();

            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("Магистров:{0}", magistr);
            Console.WriteLine("Бакалавров:{0}", bakalavr);
            Console.WriteLine();
            Console.WriteLine("Количество студентов в возрасте от 18 до 20 лет, на каждом курсе:");
            list.Sort(new Comparison<Student>(MyDelegatСourse));
            Dictionary<int, int> StodentOfCourse = new Dictionary<int, int>();
            foreach (var item in list)
            {
                int count;
                if (item.age >= 18 && item.age <= 20)
                {
                    if (StodentOfCourse.TryGetValue(item.course, out count)) StodentOfCourse[item.course] = ++count;
                    else StodentOfCourse.Add(item.course, 1);
                }
            }
            foreach (KeyValuePair<int, int> item in StodentOfCourse)
            {
                Console.WriteLine($"{item.Key} курс - {item.Value}");
            }

            Console.WriteLine();
            Console.WriteLine("Список студентов по возрасту:");
            list.Sort(new Comparison<Student>(MyDelegatAge));
            foreach (var v in list) Console.WriteLine(v.firstName + " - " + v.age);
            Console.WriteLine(DateTime.Now - dt);
            Console.WriteLine();
            Console.WriteLine("Список студентов по курсу и возрасту:");
            list.Sort(new Comparison<Student>(MyDelegatСourseAge));
            foreach (var v in list) Console.WriteLine(v.firstName + " - " + v.course + " - " + v.age);
            Console.WriteLine(DateTime.Now - dt);
            
            MyMetods.Pause();
        }
    }
}
