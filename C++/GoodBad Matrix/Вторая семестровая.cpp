#include <iostream>

template<size_t N, size_t M>
void revert(int(&a)[N][M]) {
    for (auto it = std::begin(a); it < std::end(a); it += 1)
        for (int* first = *it, *last = *it + M - 1; first < last;
            std::iter_swap(first++, last--));
}

int main()
{
    clock_t t = clock();
    int const stolbec = 7;
    int const stroka = 5;
    int arr[stroka][stolbec], sum[7];
    int summa1 = 0, schet = 0;
    std::cout << "Array: " << std::endl;
    for (int i = 0; i < stroka; i++)
    {
        for (int j = 0; j < stolbec; j++)
        {
            arr[i][j] = rand() % 100;
            std::cout << arr[i][j] << "\t";
        }
        std::cout << std::endl;
    }
    std::cout << std::endl << "Matrix after swap :\n";
    revert(arr);

    for (int i = 0; i < stroka; i++)
    {
        for (int j = 0; j < stolbec; j++)
        {
            std::cout << arr[i][j] << "\t";
        }
        std::cout << std::endl;
    }


    std::cout << std::endl << "Summs stolbcov: ";
    for (int j = 0; j < stolbec; j++)
    {
        for (int i = 0; i < stroka; i++)
        {
            summa1 += arr[i][j];
        }
        sum[j] = summa1;
        summa1 = 0;
    }

    for (int i = 0; i < stroka; i++)
    {
        std::cout << sum[i] << "\t";
    }

    for (int i = 0; i < stroka - 1; i++)
    {
        if (sum[i] > sum[i + 1])
        {
            schet++;
        }
    }

    if (schet == stroka)
    {
        std::cout << "Matrix 'horoshaya'";
    }
    else
    {
        std::cout << "Matrix ne 'horoshaya' ";
    }
}
