using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            double d, x1, x2;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            if (Преобразование(out a, out b, out c) == false) return;
            Квадратное(a, b, c, out x1, out x2);
            Линейное(b, c, out x1);
        }
        private bool Преобразование(out double a, out double b, out double c)
        {
            a = 0; b = 0; c = 0;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToDouble(textBox3.Text); return true;
            }
            catch
            {
                MessageBox.Show("проверьте исходные данные"); return true;
            }
        }

        private void Линейное(double b, double c, out double x1)
        {
            x1 = 0;
            if (b == 0)
            { label5.Text = "решения нет"; label8.Text = "";}
            else
            {
                x1 = (-c) / b; label8.Text = string.Format("{0,10:##.##}", x1);
                label5.Text = "один корень";
            }
            label9.Visible = false; label6.Visible = false;
            label11.Visible = false;
            label7.Visible = false; label12.Visible = false;
        }
        private void Квадратное(double a, double b, double c, out double x1, out double x2)
        {       
            double d;
            x1 = 0; x2 = 0;
            d = b * b - 4 * a * c;
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
