#include <iostream>

class BigInt
{
private:
    static int const size = 100;
    char array[size];   
    int Counter = size - 1;

public: BigInt()
        {
            for (int i = 0; i < size; i++)
            {
                array[i] = 0;
            }           
        }

public: BigInt(int number)
        {
            for (int i = 0; i < size; i++) 
            {
                array[i] = 0;
            }
            array[size - 1] = number;
        }

public: BigInt operator+(BigInt FirstNumber)
    {
        Counter = size - 1;
        int Digit = 0;
        BigInt ThirdNumber;
        ThirdNumber.Counter = FirstNumber.Counter;
        for (int j = size - 1; j >= ThirdNumber.Counter; j--)
        {
            ThirdNumber.array[j] = (array[j] + FirstNumber.array[j] + Digit) % 10;
            if (array[j] + FirstNumber.array[j] + Digit > 9)
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

friend std::ostream& operator<< (std::ostream& out, const BigInt& BigInt);
};

std::ostream& operator<< (std::ostream& out, const BigInt& BigInt)
{
    for (int ix = BigInt.Counter; ix < BigInt.size; ix++)
    {
        out << (int)BigInt.array[ix] << " ";       
    }
    return out;
}

int main()
{
    BigInt a(1), b(1), c;
    int n = 3;
    for (int i = 0; i < n; i++)
    {
        c = a + b;
        a = b;
        b = c;
    }
    std::cout << c;
}