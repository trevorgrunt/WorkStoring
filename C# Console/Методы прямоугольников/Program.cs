using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//////////
class Program
{
    static double LeftRectangle(Func<double, double> f, double a, double b, int n)
    {
        var h = (b - a) / n;
        var sum = 0d;
        for (var i = 0; i <= n - 1; i++)
        {
            var x = a + i * h;
            sum += f(x);
        }

        var result = h * sum;
        return result;
    }

    static double RightRectangle(Func<double, double> f, double a, double b, int n)
    {
        var h = (b - a) / n;
        var sum = 0d;
        for (var i = 1; i <= n; i++)
        {
            var x = a + i * h;
            sum += f(x);
        }

        var result = h * sum;
        return result;
    }

    static double CentralRectangle(Func<double, double> f, double a, double b, int n)
    {
        var h = (b - a) / n;
        var sum = (f(a) + f(b)) / 2;
        for (var i = 1; i < n; i++)
        {
            var x = a + h * i;
            sum += f(x);
        }

        var result = h * sum;
        return result;
    }
    static double Fun(double x)
    {
        double rez = 1 / (Math.Pow(x,2) + Math.Log(1+Math.Pow(x,2)));
        return rez;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите а и b: ");
        double a, b;
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        int n;
        Console.WriteLine("Введите число разбиений: ");
        n = int.Parse(Console.ReadLine());
        double f(double x) => Fun(x);

        var result = LeftRectangle(f, a, b, n);
        Console.WriteLine("Формула левых прямоугольников: {0}", Math.Round(result, 15));
        result = RightRectangle(f, a, b, n);
        Console.WriteLine("Формула правых прямоугольников: {0}", Math.Round(result, 15));
        result = CentralRectangle(f, a, b, n);
        Console.WriteLine("Формула средних прямоугольников: {0}", Math.Round(result,15));

        Console.ReadKey();
    }
}
