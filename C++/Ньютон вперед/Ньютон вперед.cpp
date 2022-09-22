#include <iostream>
using namespace std;

struct Data { double x, y; };

double t_cal(double t, int n) {
    double temp = t;
    for (int i = 1; i < n; i++) temp *= (t + i);
    return temp;
}

double fact(int n) {
    double f = 1.;
    for (int i = 2; i <= n; i++) f *= i;
    return f;
}

int main() {
    //Количество исходных точек:
    const int n = 4;
    //Исходные значения (x,y):
    Data f[n] = {
     { 4.45, -0.96577 },
     { 4.50, -0.97753 },
     { 4.55, -0.98684 },
     { 4.60, -0.99369 }
    };
    //Таблица конечных разностей (назад)
    double y[n][n];
    for (int i = 0; i < n; i++) y[i][0] = f[i].y;
    for (int i = 1; i < n; i++) {
        for (int j = n - 1; j >= i; j--) y[j][i] = y[j][i - 1] - y[j - 1][i - 1];
    }
    //Вывод таблицы значений от x1 до x2 с шагом dx:
    double x1 = 4.48;

    cout.width(20); cout << "X"; cout.width(20); cout << "Y" << endl;
    double sum = y[n - 1][0];
    double t = (x1 - f[n - 1].x) / (f[1].x - f[0].x);
    for (int i = 1; i < n; i++) 
    {
            sum += (t_cal(t, i) * y[n - 1][i]) / fact(i);
    }
    cout.width(20); cout.precision(14); cout << sum << endl;

    cin.get();
    return 0;
}