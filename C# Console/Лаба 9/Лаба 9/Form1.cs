using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба_9
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int i;
            for (i = 0; i < 6; i++) comboBox2.Items.Add((Color)i);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nom = comboBox1.SelectedIndex;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int КоличЭлем = 0;
            Авто[] МД = new Авто[1000];
            int i;
            for (i = 0; i < 1000; i++) // создание объектов
            { 
                МД[i] = new Авто(); 
            }
            МД[КоличЭлем].Обновить(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            КоличЭлем++;
            comboBox1.Items.Add(new Авто());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = comboBox2.Text;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }
    }
    public enum Color
    {
        неопределенный, белый, красный, фиолетовый,
        серый, зелёный
    }

    public class Авто
    {
        string Госномер; string Модель; string Цвет; string ФИО;
        public string Мод { get { return Модель; } }
        public string Цв { get { return Цвет; } }
        public string Фио { get { return ФИО; } }
        public Авто()
        { 
            Госномер = ""; Модель = ""; Цвет = ""; ФИО = "";
        }
        public void Обновить(string g, string m, string c, string fio)
        { 
            Госномер = g; Модель = m; Цвет = c; ФИО = fio;
        }
    }
}
