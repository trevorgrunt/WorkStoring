#include <iostream>
#include <iomanip>
#include <cmath>

using namespace std;


int main()
{
    setlocale(LC_ALL, "Russian");
    double eps = 0.01;
    static const int n = 3;

    double masA[n][n];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            cout << "[" << i << ", " << j << "]: ";
            cin >> masA[i][j];
        }
    }

    double masB[n];

    for (int i = 0; i < n; i++)
    {
        cout << "[" << i << "]: ";
        cin >> masB[i];
    }

    double x[n];
    double x0[n];
    double E[n];
    double max = 0;

    for (int i = 0; i < n; i++)
    {
        x0[i] = masB[i];
    }
        
    int counter = 0;
    do
    {
        for (int i = 0; i < n; i++)
        {
            x[i] = 0;
            for (int j = 0; j < n; j++)
            {
                x[i] += masA[i][j] * x0[j];
            }
            x[i] += masB[i];
            E[i] = fabs(x[i] - x0[i]);
        }
        max = 0;
        int i;
        for (i = 0; i < n; i++)
        {
            if (max < E[i]) max = E[i];
            x0[i] = x[i];
        }
        counter++;
    } while (max > eps);
    cout << endl << "Количество итераций: " << counter << endl << endl;
    for (int i = 0; i < n; i++)
        cout << "x" << i + 1 << "=" << x[i] << " " << endl;
}