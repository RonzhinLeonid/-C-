using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les7Exercise1
{
    public partial class FWF_Udvoitel : Form
    {
        public FWF_Udvoitel()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            lblCount.Text = "0";
            this.Text = "Удвоитель";
            rnd = new Random();
            numbers = new Stack<int>();
            BtnEnable(false);
            numbers.Push(rez);
        }
        
        int count = 0;
        int rez = 1;
        int setValue;

        Random rnd;
        Stack<int> numbers;
        /// <summary>
        /// Включение/Отключение кнопок
        /// </summary>
        /// <param name="enable"></param>
        void BtnEnable(bool enable)
        {
            btnCommand1.Enabled = enable;
            btnCommand2.Enabled = enable;
            btnReset.Enabled = enable;
            btnCansel.Enabled = enable;
        }
        /// <summary>
        /// Минимальное кол-во ходов 
        /// </summary>
        /// <param name="setValue"></param>
        /// <returns></returns>
        int MinCount(int setValue)
        {
            int temp = 0;
            while (setValue !=1)
            {
                if (setValue % 2 == 0) setValue /= 2;
                else setValue--;
                temp++;
            }
            return temp;
        }
        /// <summary>
        /// Сверка текущего значения и заданного числа
        /// </summary>
        /// <param name="rez"></param>
        /// <param name="setValue"></param>
        /// <param name="count"></param>
        void EndGAme(int rez, int setValue, int count)
        {
            if (rez == setValue)
            {
                MessageBox.Show($"Вы получили заданное число.\nКоличество ваших ходов - {count}.\nИдеальный вариант - {MinCount(setValue)}");
                BtnEnable(false);
            }
            else if (rez > setValue)
            {
                MessageBox.Show("Вы проиграли, Ваше число больше загаданного.");
                BtnEnable(false);
            }
        }
        private void btnCommand1_Click(object sender, EventArgs e)
        {
            rez = int.Parse(lblNumber.Text) + 1;
            numbers.Push(rez);
            lblNumber.Text = rez.ToString();
            lblCount.Text = Convert.ToString(++count);
            EndGAme(rez, setValue, count);
            
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            rez = int.Parse(lblNumber.Text) * 2;
            numbers.Push(rez);
            lblNumber.Text = rez.ToString();
            lblCount.Text = Convert.ToString(++count);
            EndGAme(rez, setValue, count);
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblCount.Text = "0";  //Ресет это тоже команда, но пусть сбрасывает счетчик.
            count = 0;
            lblNumber.Text = "1";
            numbers.Clear();
            numbers.Push(1);
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра \"Удвоитель\".\nНеобходимо получить заданное число за минимальное количество ходов.");
        }

        private void tsmiGame_Click(object sender, EventArgs e)
        {
            BtnEnable(true);
            lblCount.Text = "0";  //Сброс всех параметров.
            count = 0;
            lblNumber.Text = "1";
            numbers.Clear();
            numbers.Push(1);
            setValue = rnd.Next(100);
            MessageBox.Show($"Вым необходимо получить {setValue}.");
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            lblCount.Text = Convert.ToString(++count);
            if(numbers.Count != 1)  numbers.Pop(); 
            lblNumber.Text = Convert.ToString(numbers.Peek());
        }
    }
}
