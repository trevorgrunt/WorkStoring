using System;

namespace BigInt
{
    public class Fibonachi
    {
        private static int size = 100;
        private char[] array = new char[size];
        private int Counter = size - 1;

        public Fibonachi()
        {
            for (int i = 0; i < size; i++)
            {   
                array[i] = (char)0;
            }
        }

        public Fibonachi(int Number)
        {
            for (int i = 0; i < size; i++)
            {
                array[i] = (char)0;
            }
            array[size - 1] = (char)Number;
        }

        public static Fibonachi operator +(Fibonachi FirstNumber, Fibonachi SecondNumber)
        {
            var ThirdNumber = new Fibonachi();
            int Digit = 0;

            for (int j = size - 1; j >= ThirdNumber.Counter; j--)
            {
                ThirdNumber.array[j] = (char)((SecondNumber.array[j] + FirstNumber.array[j] + Digit) % 10);
                if (SecondNumber.array[j] + FirstNumber.array[j] + Digit > 9)
                {
                    Digit = 1;
                    if (j == ThirdNumber.Counter)
                    {
                        ThirdNumber.Counter--;
                    }
                }
                else
                {
                    Digit = 0;
                }
            }
            return ThirdNumber;
        }

        public static void WriteLine(Fibonachi OutcomeValue)
        {
            for (int i = OutcomeValue.Counter; i < size; i++)
            {
                Console.WriteLine((int)OutcomeValue.array[i]);
            }
        }
    }
}

