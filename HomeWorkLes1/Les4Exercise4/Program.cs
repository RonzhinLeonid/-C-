using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Les4Exercise4
{
    class Program
    {
        //Ронжин Л.
        //4.Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
        //Создайте структуру Account, содержащую Login и Password.
        static void Main(string[] args)
        {
            string[,] arr = Account.ReadFile("LoginPass.txt");

            int count = 1; // 1 т.к. использован цикл do while
            int tryCount = 3;
            do
            {
                MyMetods.Print("Введите логин.");
                string userLogin = Console.ReadLine();
                MyMetods.Print("Введите пароль.");
                string userPassword = Console.ReadLine();

                if (Account.Autorization(userLogin, userPassword))
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
            } while (count++ < tryCount);
            MyMetods.Pause();
        }
    }
}
