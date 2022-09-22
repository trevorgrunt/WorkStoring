#include<iostream>
#include <iomanip>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");
    float matrixA[100][100],
        matrixB[100],
        initial_x[100],
        results[100];


    int size = 0,
        number_of_iters = 0,
        i = 0,
        j = 0;
    cout << "Размер матрицы: ";
    cin >> size;


    for (i = 0; i < size; i++)
    {
        for (j = 0; j < size; j++)
        {
            cout << "[" << i << ", " << j << "]: ";
            cin >> matrixA[i][j];
        }
    }


    cout << "\nВектор b\n";
    for (i = 0; i < size; i++)
    {
        cout << "[" << i << ", " << j << "]: ";
        cin >> matrixB[i];
    }


    // x, которые будут использоваться в формуле следующих итераций
    cout << "\nВведите начальные значения x\n";
    for (i = 0; i < size; i++)
    {
        cout << "x[" << i << "]: ";
        cin >> initial_x[i];
    }


    cout << "\nКоличество итераций : ";
    cin >> number_of_iters;
    while (number_of_iters > 0)
    {
        for (i = 0; i < size; i++)
        {

            results[i] = (matrixB[i] / matrixA[i][i]);
            for (j = 0; j < size; j++)
            {
                if (j == i) // не для диагоналей
                    continue;
                // Сам алгоритм
                results[i] = results[i] - ((matrixA[i][j] / matrixA[i][i]) * initial_x[j]);
                initial_x[i] = results[i];
            }

            // вывод результата i-й итерации
            cout << "x" << i + 1 << " = " << setprecision(5) << results[i] << setw(5);
        }

        // для удобства печати с новой строки
        cout << "\n";

        // Итератор вычитается, чтобы цикл рано или поздно кончился
        number_of_iters--;
    }
    return 0;
}