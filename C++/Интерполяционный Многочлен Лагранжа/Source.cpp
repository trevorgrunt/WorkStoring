#include <iostream>
#include <conio.h>
#include <locale.h>
#include <iomanip>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");

    float x[] = { 7, -1, 8, 2 };
    float y[] = { 0, 1, 4, 6 };

    int n = sizeof(x) / sizeof(x[0]);
    float z;
    cout << "¬ведите искомую точку: ";
    cin >> z;

    float S = 0.0;

    for (int i = 0; i < n; ++i)
    {
        float  P = 1.0;
        for (int j = 0; j < n; ++j)
        {
            if (i != j)
            {
                P *= (z - x[j]) / (x[i] - x[j]);
            }
        }
        S = S + y[i] * P;
    }
    cout << setprecision(5) << S << endl;
    system("pause");
    return 0;
}