using System;

namespace BigInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonachi a = new Fibonachi(1);
            Fibonachi b = new Fibonachi(1);
            Fibonachi c = new Fibonachi();

            int NumberOfFibonachi = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < NumberOfFibonachi; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            Fibonachi.WriteLine(c);
        }
    }
}
