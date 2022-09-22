using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Калькулятор
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double First, Second;

        char Operational;

        public double Factorials(double numb)
        {
            double res = 1;
            for (double i = numb; i > 1; i--)
                res *= i;
            return res;
        }
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Result.Text += button.Content.ToString();
            Second = double.Parse(Result.Text);
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            First = double.Parse(Result.Text);
            Operational = '*';
            Result.Clear();
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            First = double.Parse(Result.Text);
            Operational = '/';
            Result.Clear();
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            First = double.Parse(Result.Text);
            Operational = '-';
            Result.Clear();
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            First = double.Parse(Result.Text);
            Operational = '+';
            Result.Clear();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = "0";
        }

        private void Power_Click(object sender, RoutedEventArgs e)
        {
            First = double.Parse(Result.Text);
            Operational = '^';
            Result.Clear();
        }

        private void Log_Click(object sender, RoutedEventArgs e)
        {
            First = double.Parse(Result.Text);
            Operational = 'l';
            Result.Clear();
        }

        private void Sqrt_Click(object sender, RoutedEventArgs e)
        {
            First = double.Parse(Result.Text);
            Operational = '√';
            Result.Clear();            
        }

        private void Percent_Click(object sender, RoutedEventArgs e)
        {
            First = double.Parse(Result.Text);
            Operational = '%';
            Result.Clear();
        }

        private void Ln_Click(object sender, RoutedEventArgs e)
        {
            First = double.Parse(Result.Text);
            Operational = 'L';
            Result.Clear();
        }

        private void Cos_Click(object sender, RoutedEventArgs e)
        {
            First = double.Parse(Result.Text);
            Operational = 'C';
            Result.Clear();
        }

        private void Sin_Click(object sender, RoutedEventArgs e)
        {
            First = double.Parse(Result.Text);
            Operational = 'S';
            Result.Clear();
        }

        private void Tan_Click(object sender, RoutedEventArgs e)
        {
            First = double.Parse(Result.Text);
            Operational = 'T';
            Result.Clear();
        }

        private void Factorial_Click(object sender, RoutedEventArgs e)
        {
            First = double.Parse(Result.Text);
            Operational = '!';
            Result.Clear();
        }

        private void Acos_Click(object sender, RoutedEventArgs e)
        {
            First = double.Parse(Result.Text);
            Operational = 'c';
            Result.Clear();
        }

        private void Asin_Click(object sender, RoutedEventArgs e)
        {
            First = double.Parse(Result.Text);
            Operational = 's';
            Result.Clear();
        }

        private void Atan_Click(object sender, RoutedEventArgs e)
        {
            First = double.Parse(Result.Text);
            Operational = 't';
            Result.Clear();
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            if (Operational != '√' && Operational != 'L' && Operational != 'C' && Operational != 'S' && Operational != 'T' && Operational != '!' && Operational != 'c' && Operational != 's' && Operational != 't')
            {
                Second = double.Parse(Result.Text);
            }

            double result = 0;

            switch (Operational)
            {
                case '+': result = First + Second; break;

                case '-': result = First - Second; break;

                case '*': result = First * Second; break;

                case '/': result = First / Second; break;

                case '^': result = Math.Pow(First,Second); break;

                case 'l': result = Math.Log(First,Second); break;

                case '√': result = Math.Sqrt(First); break;

                case '%': result = First % Second; break;

                case 'L': result = Math.Log10(First); break;

                case 'C': result = Math.Cos(First); break;

                case 'S': result = Math.Sin(First); break;

                case 'T': result = Math.Tan(First); break;

                case '!': result = Factorials(First); break;

                case 'c': result = Math.Acos(First); break;

                case 's': result = Math.Asin(First); break;

                case 't': result = Math.Atan(First); break;
            }

            if(Result.Text == "0")
            {
                Result.Clear();
            }

            Result.Text = result.ToString();
        }
    }
}

