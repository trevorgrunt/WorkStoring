using System;

namespace Алгоритм_деления_отрезка_пополам
{
    class LinearEquation
    {
        private static double Func(double x)
        {
            double result = Math.Pow(x, 4) + 3 * x - 20;
            return result;
        }

        public static void Calculation()
        {
            Console.WriteLine("Введите а");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите e");
            double e = Convert.ToDouble(Console.ReadLine());
            double c = 0;
            int count = 0;

            while (Math.Abs(Func(c)) >= e)
            {
                c = (a + b) / 2;
                if (Func(a) * Func(c) > 0)
                {
                    a = c;
                }
                else
                {
                    b = c;
                }
                count++;
            }
            Console.WriteLine("Ответ: "+ Math.Round(c, 15));
            Console.WriteLine("Число итераций: "+count);
        }
    }
}
