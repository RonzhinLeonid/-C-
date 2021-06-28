using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les8Exercise4
{
    public class Spending
    {
        string сostItem;     // Предммет
        decimal sum;         // сумма
        int quantity;        // количество

        public string СostItem
        {
            get { return сostItem; }
            set { сostItem = value; }
        }
        public decimal Sum       
        {
            get { return sum; }
            set { sum = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Spending()
        {
        }
        public Spending(string сostItem, decimal sum, int quantity)
        {
            this.сostItem = сostItem;
            this.sum = sum;
            this.quantity = quantity;
        }

    }
}
