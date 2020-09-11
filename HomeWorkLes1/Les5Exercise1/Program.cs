using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;
using System.Text.RegularExpressions;

namespace Les5Exercise1
{
    class Program
    {
        //Сергей, вопрос, как сделать, чтобы регулярное выражение сравнивало целиком строку,
        //а не искало соответствие в ней? Добавил якоря ^ и $, но тогда не отслеживается длинна строки. 
        //Как быть в данном случае? разбивать сравнение на этапы и добавлять условие проверки длинны отдельно?

        //Ронжин Л.
        //1. Создать программу, которая будет проверять корректность ввода логина.Корректным логином будет строка от 2 до 10 символов,
        //содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
        //  а) без использования регулярных выражений;
        //  б) **с использованием регулярных выражений.
        static void Main(string[] args)
        {
            Regex myReg = new Regex(@"^[A-Za-z]+[A-Za-z0-9]{1,9}$");
            Console.WriteLine("Для выхода из цикла введите \"stop\"");
            while (true)
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();
                if (login.ToLower() == "stop") break;
                Console.Write("Способ а:           ");
                Console.WriteLine(LoginVerification(login) ? "Логин верный":"Логин не верный");
                Console.Write("Способ б вариант 1: ");
                Console.WriteLine(LoginVerificationReg(login) ? "Логин верный" : "Логин не верный");
                Console.Write("Способ б вариант 2: ");
                Console.WriteLine(LoginVerificationRegV2(login) ? "Логин верный" : "Логин не верный");
                Console.Write("Способ б вариант 3: ");
                Console.WriteLine(myReg.IsMatch(login) ? "Логин верный" : "Логин не верный");
            }
            MyMetods.Pause();
        }
        /// <summary>
        /// Проверяет является ли символ буквой латинского алфавита. 
        /// </summary>
        /// <param name="sym"></param>
        /// <returns></returns>
        public static bool IsDigitLat(char sym)
        {
            if (Char.ToLower(sym) >= 'a' && Char.ToLower(sym) <= 'z') return true;
            else return false;
        }
        /// <summary>
        /// Проверяет является ли символ буквой латинского алфавита, при помощи регулярных выражений. 
        /// </summary>
        /// <param name="sym"></param>
        /// <returns></returns>
        public static bool IsDigitLatRegul(char sym)
        {

            Regex myReg = new Regex(@"[A-Za-z]");
            return myReg.IsMatch(Convert.ToString(sym));
        }
        /// <summary>
        /// Проверяет корректность логина. 
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        private static bool LoginVerification(string login)
        {
            if (login.Length < 2 || login.Length > 10 || Char.IsNumber(login[0]) || !IsDigitLat(login[0])) return false;
            else
            {
                for (int i = 1; i < login.Length; i++)
                {
                    if (!Char.IsNumber(login[i]) && !IsDigitLat(login[i])) return false;
                }
            return true;
            } 
        }
        /// <summary>
        /// Проверяет корректность логина, при помощи регулярных выражений. 
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        private static bool LoginVerificationReg(string login)
        {
            Regex myReg = new Regex(@"[A-Za-z1-9]");
            if (login.Length < 2 || login.Length > 10 || Char.IsNumber(login[0]) || !IsDigitLatRegul(login[0])) return false;
            else
            {
                for (int i = 1; i < login.Length; i++)
                {
                   if (!myReg.IsMatch(Convert.ToString(login[i]))) return false;
                }
                return true;
            }
        }
        /// <summary>
        /// Проверяет корректность логина, при помощи регулярных выражений с проверкой длины строки. 
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        private static bool LoginVerificationRegV2(string login)
        {
            Regex myReg = new Regex(@"^[A-Za-z]+[A-Za-z0-9]{1,9}$");
            if (login.Length >= 2 && login.Length <= 10 && myReg.IsMatch(Convert.ToString(login))) return true;
            else   return false;
        }
    }
}
