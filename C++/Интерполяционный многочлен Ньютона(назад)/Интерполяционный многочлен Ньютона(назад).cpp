#include <iostream>
#include <iomanip>

using namespace std;

// вычисляем t упомянутую в формуле
float t_cal(float t, int n)
{
    float temp = t;
    for (int i = 1; i < n; i++)
    {
        temp = temp * (t - i);
    }
    return temp;
}


// вычисляем факториал с заданным числом n
int fact(int n)
{
    int f = 1;
    for (int i = 2; i <= n; i++)
    {
        f *= i;
    }
    return f;
}



int main()
{
    setlocale(LC_ALL, "Russian");
    // Количество заданных значений
    int const n = 4;
    float x[] = { 4.45, 4.50, 4.55, 4.60 };
    // y [] [] используется для таблицы разностей
    // с y [] [0] используемым для ввода
    float y[n][n];

    y[0][0] = -0.96577;
    y[1][0] = -0.97753;
    y[2][0] = -0.98684;
    y[3][0] = -0.99369;



    // Вычисление прямой разницы
    for (int i = 1; i < n; i++)
    {
        for (int j = 0; j < n - i; j++)
        {
            y[j][i] = y[j + 1][i - 1] - y[j][i - 1];
        }
    }

    // Отображение таблицы прямых разниц
    for (int i = 0; i < n; i++)
    {
        cout << setw(10) << x[i] << "\t";
        for (int j = 0; j < n - i; j++)
        {
            cout << setw(10) << std::setprecision(10) << y[i][j] << "\t";
        }

        cout << endl;
    }

    // Значение для интерполяции в
    float value = 4.57f;

    // инициализация и сумма
    float sum = y[3][0];
    float t = (value - x[3]) / (x[1] - x[0]);

    // Интерполяция назад
    for (int i = 1; i < n; i++)
    {
        sum = sum + (t_cal(t, i) * y[0][i]) / fact(i);
    }

    cout << "\n Значение в точке " << value << " при интерполяции назад равно: " << std::setprecision(10) << sum << endl;

    return 0;

}