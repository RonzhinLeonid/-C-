using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les7Exercise1
{
    //Сергей в коде встречаются одинаковые наборы строк, напримир:
    //   lblCount.Text = "0"; 
    //   count = 0;
    //   lblNumber.Text = "1";
    //   numbers.Clear();
    //   numbers.Push(1);
    // Стоит ли их обединять в какой либо метод?

    //Ронжин Л.
    // а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
    // б) Добавить меню и команду «Играть». При нажатии появляется сообщение,
    //какое число должен получить игрок.Игрок должен получить это число за минимальное
    //количество ходов.
    // в) * Добавить кнопку «Отменить», которая отменяет последние ходы.
    //Используйте обобщенный класс Stack.
    // Вся логика игры должна быть реализована в классе с удвоителем.
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
            Application.Run(new FWF_Udvoitel());
        }
    }
}
