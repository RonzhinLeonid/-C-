using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les7Exercise2
{
    //Сергей, как правильно передавать данные из одной формы в другую? Я использовал публичный метод.
    //Как я понимаю лучше всю логику игры вообще вынести в отдельный класс и уже в нем работать с разными формами? 

    //Ронжин Л.
    //Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100,
    //а человек пытается его угадать за минимальное число попыток.Компьютер говорит, больше или меньше
    //загаданное число введенного.
    //  a) Для ввода данных от человека используется элемент TextBox;
    //  б) ** Реализовать отдельную форму c TextBox для ввода числа.

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GuessNumber());
        }
    }
}
