using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Les5Exercise2
{
    class Program
    {
        //Сергей при частотном анализе через класс Dictionary как вывести коллекцию? я использовал KeyValuePair<string, int> правильно ли это?

        //Ронжин Л.
        //2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
        //а) Вывести только те слова сообщения,  которые содержат не более n букв.
        //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        //в) Найти самое длинное слово сообщения.
        //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        //д) ***Создать метод, который производит частотный анализ текста.В качестве параметра в него передается массив слов и текст, 
        //в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
        //Здесь требуется использовать класс Dictionary.

        static void Main(string[] args)
        {
            string str = "Съешь ещё этих мягких французских булок, да выпей чаю.";
            Console.WriteLine("Исходная строка: " + str);
            Console.Write("Искомые слова: ");
            Message.StringSize(str, 5);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Исходная строка: " + str);
            Console.Write("Искомые слова: ");
            Message.DeleteWords(str, 'х');
            Console.WriteLine();
            str = "Съешь ещё этих мягких французских булок, французскда выпей чаю.";
            Console.WriteLine("Исходная строка: " + str);
            Console.WriteLine($"Самые длинные слова сообщения: {Message.MaxWords(str)}");
            Console.WriteLine($"Строка из самых длинных слов сообщения: {Message.StringBuilder(Message.MaxWords(str))}");
            str = "Съешь ещё этих мягких французских булок, французскда выпей чаю. Съешь ещё этих мягких французских булок, да выпей чаю. Съешь ещё этих мягких французских булок, да выпей чаю.";
            Console.WriteLine();
            Console.WriteLine("Частотный анализ текста.");
            Console.WriteLine("Исходная строка: " + str);
            Console.WriteLine("Результат:");
            Message.CountDictionary(str);

            MyMetods.Pause();
        }
    }
}
