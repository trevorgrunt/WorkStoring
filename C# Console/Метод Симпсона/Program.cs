using System;

namespace Метод_Симпсона
{
    class Program
    {
        static double F(double x)
        {
            return 1 / (Math.Pow(x, 2) + Math.Log(1 + Math.Pow(x, 2)));
        }
        static void Main(string[] args)
        {
            double x, a, b, h, sum = 0, n;
            Console.WriteLine("Введите а и b: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число разбиений: ");
            n = int.Parse(Console.ReadLine());
            double f(double x) => F(x);

            h = (b - a) / n;
            x = a + h;
            while (x < b)
            {
                sum = sum + 4 * F(x);
                x = x + h;
                sum = sum + 2 * F(x);
                x = x + h;
            }
            double result = h / 3 * (sum + F(a) - F(b));
            Console.WriteLine("Ответ: " + Math.Round(result,15));
        }
    }
}
