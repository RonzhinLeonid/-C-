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
    public partial class EnterNumber : Form
    {
        public EnterNumber()
        {
            InitializeComponent();
            tbNumber.Text = "0";
            this.Text = "Введите число";
        }

        public string Data
        {
            get
            {
                return tbNumber.Text;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
