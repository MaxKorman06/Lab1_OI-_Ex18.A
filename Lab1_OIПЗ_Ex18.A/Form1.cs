using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_OIПЗ_Ex18.A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, S, c, p;
            a = Convert.ToInt16(textBox2.Text); // Вводимо довжину бічної сторони та площу трикутника
            S = Convert.ToInt16(textBox1.Text);
            c = (a * a) / S;
            p = a + a + c;
            if (a+a>c && a+c>a && a>0 && c>0 && S>0) // Перевіряємо чи існує такий трикутник
            {
                MessageBox.Show("Периметр: " + p, "Периметр трикутника: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Трикутник не існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); // Якщо трикутник не існує вконуєтоься ця функція
            }
            button1.Enabled = false;
        }
    }
}
