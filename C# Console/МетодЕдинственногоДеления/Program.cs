using System;

namespace МетодЕдинственногоДеления
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            int n = 3; // Размерность системы
            double[,] A = new double[n,n]; // Матрица А
            int count = 0;  
            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Введите элемент матрицы "+i+" "+j);
                    A[i, j] = double.Parse(Console.ReadLine());
                }
            }

            double[] b = new double[n]; // Вектор b
            double[] x = new double[n]; // Переменная в которой хранится ответ

            for (int i = 0; i < n; i++)
            {
                x[i] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите элемент вектора " + i);
                b[i] = double.Parse(Console.ReadLine());
            }

            for (int k = 0; k < n - 1; k++) // Работа с матрицей
            {
                for (int i = k + 1; i < n; i++)
                {
                    for (int j = k + 1; j < n; j++)
                    {
                        A[i, j] = A[i, j] - A[k, j] * (A[i, k] / A[k, k]);
                    }
                    b[i] = b[i] - b[k] * A[i, k] / A[k, k];
                }
            }

            for (int k = n - 1; k >= 0; k--) // Вычисление ответа
            {
                s = 0;
                for (int j = k + 1; j < n; j++)
                {
                    s = s + A[k, j] * x[j];                    
                }             
                x[k] = (b[k] - s) / A[k, k];
            }

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("Решение:");
                Console.WriteLine("{0:0.##}", Math.Round(x[i],15));                
            }

        }
    }
}
