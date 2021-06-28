using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Les2Exercise4
{
    class Program
    {
        /*4. Реализовать метод проверки логина и пароля.
         На вход метода подается логин и пароль.
         На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
         Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
         программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.*/
        static void Main(string[] args)
        {
           bool Autorization(string userLogin, string userPassword)
            {
                string login = "root";
                string password = "GeekBrains";
                if (userLogin.ToLower() == login && userPassword == password)
                {
                    return true;
                }
                else
                    return false;
            }
            //string login = "root";
            //string password = "GeekBrains";
            int count = 1; // 1 т.к. использован цикл do while
            int tryCount = 3;
            do
            {
                MyMetods.Print("Введите логин.");
                string userLogin = Console.ReadLine();
                MyMetods.Print("Введите пароль.");
                string userPassword = Console.ReadLine();

                if (Autorization(userLogin, userPassword))
                {
                    MyMetods.Print("Вы вошли в систему.");
                    //count = trycount;
                    break;
                }
                else
                {
                    if (count == tryCount)
                        MyMetods.Print("Вы ввели неверный логин или пароль.\nВсе попытки использованы.\n");
                    else
                    {
                        string str;
                        if (tryCount - count == 2)
                            str = "ки";
                        else
                            str = "ка";
                        MyMetods.Print($"Вы ввели неверный логин или пароль.\nПопробуйте еще раз. У вас осталось {tryCount - count} попыт{str}.\n");
                    }
                }
            } while (count++ < tryCount) ;
        MyMetods.Pause();
        }
    }
}
