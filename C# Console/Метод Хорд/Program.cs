using System;

namespace Метод_Хорд
{
    class Program
    {
		public static double Func(double x)
		{
			double result = Math.Pow(x, 4) + 3 * x - 20;
			return result;
		}
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Введите а");
			double a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите b");
			double b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите e");
			double e = Convert.ToDouble(Console.ReadLine());
			int count = 0;


			while (Math.Abs(b - a) > e)
			{
				a = b - (b - a) * Func(b) / (Func(b) - Func(a));
				b = a - (a - b) * Func(a) / (Func(a) - Func(b));
				count++;
			}

			Console.WriteLine("Ответ: " + Math.Round(b,15));
			Console.WriteLine("Число итераций: " + count);
		}
	}
}
