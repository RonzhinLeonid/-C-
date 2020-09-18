using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les7Exercise2
{
    public partial class GuessNumber : Form
    {
        public GuessNumber()
        {
            InitializeComponent();
            this.Text = "Игра \"Угадай число\"";
            BtnVisible(false);
            rnd = new Random();
            count = 0;
            maxCount = 7;
            fEnterNumber = new EnterNumber();
        }
        EnterNumber fEnterNumber;
        Random rnd;
        int setValue;
        int Number;
        int count;
        int maxCount;
        /// <summary>
        /// Тело игры
        /// </summary>
        /// <param name="setValue"></param>
        /// <param name="Number"></param>
        /// <param name="count"></param>
        /// <param name="maxCount"></param>
        public void Game(int setValue, int Number, int count, int maxCount)
        {
            if (setValue == Number)
            {
                MessageBox.Show("Поздравляю! Вы выиграли.");
                BtnVisible(false);
                //btnStart.Text = "Начать игру";
            }
            else if (count >= maxCount)
            {
                MessageBox.Show("Вы проиграли.");
                BtnVisible(false);
                //btnStart.Text = "Начать игру";
            }
            else if (setValue > Number) MessageBox.Show("Вы ввели слишком маленькое число.");
            else MessageBox.Show("Вы ввели слишком большое число.");
        }
        /// <summary>
        /// Включение/Отключение кнопок
        /// </summary>
        /// <param name="enable"></param>
        void BtnVisible(bool enable)
        {
            btnEnter.Visible = enable;
            lblEnterNumber.Visible = enable;
            tbNumber.Visible = enable;
            lblCount.Visible = enable;
            chbNewForm.Visible = enable;
            if (!enable) btnStart.Text = "Начать игру";
            else btnStart.Text = "Выход";
        }

        
        private void btnStart_Click(object sender, EventArgs e)
        {

            if (btnStart.Text == "Начать игру")
            { 
                BtnVisible(true);
                setValue = rnd.Next(100);
                tbNumber.Text = "0";
                count = 0;
                lblCount.Text = $"Количество попыток: {maxCount-count}";
            }
            else Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            if (chbNewForm.Checked)
            {
                fEnterNumber.ShowDialog();
                Number = int.Parse(fEnterNumber.Data);
            }
            else
                Number = int.Parse(tbNumber.Text);
         
            count++;
            lblCount.Text = $"Количество попыток: {maxCount - count}";
            Game(setValue, Number, count, maxCount);
        }

        private void chbNewForm_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNewForm.Checked) tbNumber.Visible = false;
            else
            {
                tbNumber.Visible = true;
                tbNumber.Text = "0";
            }
        }
    }
}
