using System;

namespace Метод_трапеций
{
    class Program
    {
        static double F(double x)
        {
            return 1 / (Math.Pow(x,2) + Math.Log(1 + Math.Pow(x,2)));
        }
        static void Main(string[] args)
        {
            double a, b, n, h, sum = 0, xi, xi1;
            Console.WriteLine("Введите а и b: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число разбиений: ");
            n = int.Parse(Console.ReadLine());
            double f(double x) => F(x);

            h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                xi = a + i * h;
                xi1 = a + (i + 1) * h;
                sum += F(xi) + F(xi1);
            }
            double res = sum * h / 2;
            Console.WriteLine("Ответ: " + Math.Round(res,15));
        }
    }
}
