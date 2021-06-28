using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Les5Exercise3
{
    class Program
    {

        //Ронжин Л.
        //3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
        //Например:
        //badc являются перестановкой abcd.
        static void Main(string[] args)
        {
            Console.WriteLine("Для выхода из цикла введите \"stop\"");
            while (true)
            {
                Console.Write("Введите первую строку: ");
                string str1 = Console.ReadLine();
                Console.Write("Введите вторую строку: ");
                string str2 = Console.ReadLine();
                if (str1.ToLower() == "stop" || str2.ToLower() == "stop") break;

                Console.Write("Способ 1: ");
                Console.WriteLine(StringComp(str1, str2) ? "Строки зеркальны" : "Строки не зеркальны");
                Console.Write("Способ 2: ");
                Console.WriteLine(str1 == ReverseStringBuilder(str2) ? "Строки зеркальны" : "Строки не зеркальны");

            }
            MyMetods.Pause();
        }

        public static string ReverseStringBuilder(string str)
        {
            StringBuilder newStr = new StringBuilder(str.Length);
            for (int i = str.Length -1; i >= 0; i--)
                newStr.Append(str[i]);
            return newStr.ToString();
        }

        public static bool StringComp(string str1, string str2)
        {
            if (str1.Length != str2.Length) return false;
            else 
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[str2.Length -1 - i]) return false;
                }
            }
            return true;
        }
    }
}
