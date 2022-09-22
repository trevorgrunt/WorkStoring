using System;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c0, e, fa, fc0, fb, sr1, sr2;
            int k = 0;
            Console.WriteLine("Функция: f(x)=x^2-2/x");
            Console.WriteLine("Введите предел а=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите предел b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите предел e(эпсилон)=");
            e = Convert.ToDouble(Console.ReadLine());
            c0 = (a + b) / 2;
            fa = Math.Pow(a, 2) - 2 / a;
            fc0 = Math.Pow(c0, 2) - 2 / c0;
            fb = Math.Pow(b, 2) - 2 / b;
            sr1 = fa * fc0;
            sr2 = fa * fc0;
            if ((sr1 < 0) || (sr2 < 0))
            {
                b = c0;
            }
            else
            {
                a = c0;
            }

            while (fc0 < e)
            {
                c0 = (a + b) / 2;
                fa = Math.Pow(a, 2) - 2 / a;
                fc0 = Math.Pow(c0, 2) - 2 / c0;
                fb = Math.Pow(b, 2) - 2 / b;
                sr1 = fa * fc0;
                sr2 = fa * fc0;
                if ((sr1 < 0) || (sr2 < 0))
                {
                    b = c0;
                }
                else
                {
                    a = c0;
                }
                k++;
            }
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.WriteLine("c0=" + c0);
            Console.WriteLine("fa=" + fa);
            Console.WriteLine("fc0=" + fc0);
            Console.WriteLine("fb=" + fb);
            Console.WriteLine("sr1=" + sr1);
            Console.WriteLine("sr2=" + sr2);
            Console.WriteLine("Кол-во итераций:" + k);
            Console.ReadKey();
        }
    }
}
