using System;

namespace Лагранж
{
    class Program
    {
        static void Main()
        {
            const int n = 10;
            double[] X = new double[n];
            double[] Y = new double[X.Length];
            double x = Math.PI / 4;

            for (int i = 0; i < n; i++)
            {
                Y[i] = F(X[i]);
            }
            Lagrange lagrange = new Lagrange();
            double y = lagrange.GetValue(X, Math.PI / 2, Y, x);
            Console.WriteLine($"Y={y},X={x}");
            Console.WriteLine($"Y={F(x)}");
            Console.WriteLine($"dY={Math.Abs(F(x) - y)}");
            Console.ReadKey();
        }

        static double F(double x)
        {
            return Math.Sin(x);
        }
    }
}
