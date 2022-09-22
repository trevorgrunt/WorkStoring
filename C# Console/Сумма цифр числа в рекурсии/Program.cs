using System;

namespace Сумма_цифр_числа_в_рекурсии
{
    class Program
    {
        static int SumOfDigits(int number)
        {
            if(number < 10)
            {
                return number;
            }

            int digit = number % 10;

            int next = number / 10;

            return digit + SumOfDigits(next);
        }

        static void Main(string[] args)
        {
            int number = 123;
            Console.WriteLine(SumOfDigits(number));
        }
    }
}
