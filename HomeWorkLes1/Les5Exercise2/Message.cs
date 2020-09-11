using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les5Exercise2
{
    static class Message
    {
        //Вывести только те слова сообщения, которые содержат не более n букв.
        static public void StringSize(string str, int size)
        {
            StringBuilder temp = new StringBuilder(str);

            string[] s = ArrayFromString(temp);

            for (int i = 0; i < s.Length; i++)
                if (s[i].Length <= size) Console.Write($"{s[i]} ");//проверка слов на длинну
        }

        //Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        static public void DeleteWords(string str, char sym)
        {
            StringBuilder temp = new StringBuilder(str);

            string[] s = ArrayFromString(temp);

            temp = new StringBuilder(str);//восстановление исходной строки
            for (int i = 0; i < s.Length; i++)
                if (s[i][s[i].Length-1] == sym) temp.Replace(" "+s[i], "");//удаление слов оканчивающихся на sym
            Console.WriteLine(temp.ToString());
        }

        //Найти самое длинное слово сообщения.
        static public string MaxWords(string str)
        {
            StringBuilder temp = new StringBuilder(str);
            string[] s = ArrayFromString(temp);

            int Length = s[0].Length;
            string rez = s[0];
            for (int i = 1; i < s.Length; i++)//Поиск длинного слова
                if (s[i].Length > Length)
                {
                    Length = s[i].Length;
                    rez = s[i];
                }
                else if (s[i].Length == Length)
                    rez = rez + " " + s[i];
            return rez;
        }
        //Частотный анализ строки через класс Dictionary.
        static public void CountDictionary(string str)
        {
            StringBuilder temp = new StringBuilder(str);
            Dictionary<string, int> counts = new Dictionary<string, int>();
            string[] arr = ArrayFromString(temp);
            foreach (string item in arr)
            {
                int count;
                if (counts.TryGetValue(item, out count)) counts[item] = ++count;
                else counts.Add(item, 1);
                //if (counts.ContainsKey(item)) counts.Add(item, 0);
                //counts[item]++;
            }
            foreach (KeyValuePair<string, int> item in counts)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            
        }

        static public string[] ArrayFromString(StringBuilder temp) //данный код дублировался в нескольких местах, вынес его в отдельный метод
        {
            for (int i = 0; i < temp.Length;)
                if (char.IsPunctuation(temp[i])) temp.Remove(i, 1);//удаляем знаки препинания
                else ++i; //i вынесено в else т.к. при удалении знака препинания i увеличивать не надо
            string tempStr = temp.ToString();
            string[] s = tempStr.Split(' '); //массив слов
            return s;
        }

        //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        static public string StringBuilder(string str)
        {
            string[] s = str.Split(' '); //массив слов
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                temp.Append(s[i] + " ");
            }
            return temp.ToString();
        }
    }
}
