using System;

namespace Линейная_интерполяция
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите конечные точки");
            double xi = double.Parse(Console.ReadLine());
            double yi = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите начальные точки");
            double xim = double.Parse(Console.ReadLine());
            double yim = double.Parse(Console.ReadLine());
            double a = (yi - yim) / (xi - xim);
            double b = a * xim - yim;
            Console.WriteLine("Введите искомую точку");
            double x = double.Parse(Console.ReadLine());
            double y = a * x - b;
            Console.WriteLine("y = " + y);
        }
    }
}
