using System;

namespace Рекурсия_Сумма_элементов_массива
{
    class Program
    {
        static void SummArray(int[] array, int i = 0, int sum = 0)
        {
            if(i < array.Length)
            {
                sum += array[i];
                SummArray(array, i + 1, sum);
            }
            else
            {
                Console.WriteLine(sum);
            }    
        }

        static void Main(string[] args)
        {
            int[] Array = { 1, 2, 3, 4, 5 };
            SummArray(Array);
        }
    }
}
