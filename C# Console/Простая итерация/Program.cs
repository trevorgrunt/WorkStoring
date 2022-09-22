using System;

namespace Простая_итерация
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> f = x => Math.Cos(x) - Math.Sqrt(x) + x;
            double a = 1, b = 0, e = 1e-6;
            while (Math.Abs(a - b) >= e) { a = b; b = f(a); }
            Console.WriteLine("x = {0:f5}", b);
            Console.WriteLine("cos(x) - sqrt(x) = {0:f5}", (f(b) - b));
            Console.ReadLine();
        }
    }
}
