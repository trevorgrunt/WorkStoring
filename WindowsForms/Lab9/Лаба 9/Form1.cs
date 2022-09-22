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
    public class Авто
    { 
        string Госномер; string Модель; string Цвет; string ФИО;
        public Авто()
        { Госномер = ""; Модель = ""; Цвет = ""; ФИО = ""; }
    }
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
