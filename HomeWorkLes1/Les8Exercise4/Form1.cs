using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les8Exercise4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TrueFalse database;
        private void tsmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("Введите новый товар", 0, 0);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            };
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
                if (database != null) database.Save();
                else MessageBox.Show("База данных не создана");
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    database = new TrueFalse(ofd.FileName);
                    database.Load();
                    nudNumber.Minimum = 1;
                    nudNumber.Maximum = database.Count;
                    nudNumber.Value = 1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный формат файла или Файл слишком большой!");
            }
        }

        private void tsmiSavaAs_Click(object sender, EventArgs e)
        {
            if (database != null) //database.Save();
            {
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    database.Save(sfd.FileName);
                };
            }
            else MessageBox.Show("База данных не создана");
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                tbCostItem.Text = database[(int)nudNumber.Value - 1].СostItem;
                tbSum.Text = database[(int)nudNumber.Value - 1].Sum.ToString();
                tbQuantity.Text = database[(int)nudNumber.Value - 1].Quantity.ToString();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Не выбрана база данных!");
            }
        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                database[(int)nudNumber.Value - 1].СostItem = tbCostItem.Text;
                database[(int)nudNumber.Value - 1].Sum = Convert.ToDecimal(tbSum.Text);
                database[(int)nudNumber.Value - 1].Quantity = Convert.ToInt32(tbQuantity.Text);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Не выбрана база данных!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат данных!");
            }

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null) return;
            database.Remove((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add("Введите новый товар", 0, 0);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }
    }
}
