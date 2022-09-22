using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ГауссЗейдель
{
    class Seidel
    {
        int n;
        public int N
        {
            get { return n; }
            set { n = value; }
        }
        double[,] a;
        public double[,] A
        {
            get { return a; }
            set { a = value; }
        }
        double[] x;
        public double[] X
        {
            get { return x; }
            set { x = value; }
        }
        double e = 0.00001;
        public double E
        {
            get { return e; }
            set { e = value; }
        }
        private double[] x2;
        public double[] X2
        {
            get { return x2; }
            set { x2 = value; }
        }
        public void Input()
        {
            Console.WriteLine("Пожалуйста, введите заказ:");
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n, n + 1];
            x = new double[n];
            x2 = new double[N + 1];
            for (int i = 0; i < N; i++)
            {
                x2[i] = x[i];
            }
            Console.WriteLine("Пожалуйста, введите коэффициент для каждой строки (через ',' или ''):");
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                string[] ss = s.Split(' ', ',');
                for (int j = 0; j < n + 1; j++)
                {
                    a[i, j] = Convert.ToDouble(ss[j]);
                }
            }
        }
        public void Calcu6()
        {
            int count1 = 0, count2 = 0;
            while (true)
            {
                for (int i = 0; i < n; i++)
                {
                    double sum1 = 0, sum2 = 0;
                    for (int j = i + 1; j < n; j++)
                    {
                        sum1 += a[i, j] * x[j];
                    }
                    for (int j = 0; j < i - 1; j++)
                    {
                        sum2 += a[i, j] * x2[j];
                    }
                    x[i] = (a[i, n] - sum2 - sum1) / a[i, i];
                    if (Math.Abs(x2[i] - x[i]) < e)
                        count2++;
                }
                count1++;
                if (count1 > 10000)
                { Console.WriteLine("Итерационное расхождение !!!"); break; }
                if (count2 == n)
                { Console.WriteLine("Количество итераций: {0}", count2); break; }
            }
        }
        public void Output()
        {
            Console.WriteLine("Коэффициент уравнения:");
            for (int i = 0; i < n; i++)
            {
                string s = null;
                for (int j = 0; j < n + 1; j++)
                {
                    s += string.Format("{0,8:f2}", a[i, j]);
                }
                Console.WriteLine(s);
            }
        }

        public void OutputX()
        {
            Console.WriteLine("\nРешение группы уравнений:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("x{0}={1}", i + 1, x[i]);
            }
        }
    }
}
