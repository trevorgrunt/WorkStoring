#include <iostream>

using namespace std;

float func(float x) {
	float ans = 1 / (pow(x,2) + log(1 + pow(x,2)));
	return ans;
}

int main()
{
	setlocale(LC_ALL, "Ru");
	float point, a, b, t, h, ans, l;
	int n, tmp;
	cout << "Функция: 1 / x^2 + ln(1 + x^2)" << endl;
	cout << "Введите n" << endl;
	cin >> n;
	cout << "Введите отрезок [a;b]" << endl;
	cin >> a >> b;
	cout << "Введите точку x" << endl;
	cin >> point;
	h = (b - a) / n;
	float** T = new float* [n + 1];
	for (int i = 0; i < n + 1; i++) 
	{
		T[i] = new float[n + 2];
	}
	for (int i = 0; i < n + 1; i++) 
	{
		for (int j = 0; j < n + 2; j++)
		{
			T[i][j] = 0;
		}
	}
	T[0][0] = a;
	for (int i = 1; i < n + 1; i++) 
	{
		T[i][0] = T[i - 1][0] + h;
	}
	cout << endl;
	for (int i = 0; i < n + 1; i++) 
	{
		T[i][1] = func(T[i][0]);
	}
	tmp = n;
	for (int j = 2; j < n + 2; j++) 
	{
		for (int i = 0; i < tmp; i++) 
		{
			T[i][j] = T[i + 1][j - 1] - T[i][j - 1];
		}
		tmp--;
	}

	cout << endl;
	cout << "Укажите расположение точки. 1 - в начале; 2 - в конце" << endl;
	cin >> tmp;
	switch (tmp)
	{
	case 1:
		//первая производная
		t = (point - T[0][0]) / h;
		ans = (1 / h) * (T[0][2] + ((2 * t - 1) / 2) * T[0][3] + ((3 * pow(t, 2)
			- 6 * t + 2) / 6) * T[0][4] + ((4 * pow(t, 3) - 18 * pow(t, 2) + 22 * t - 6) / 24) * T[0][5]
			+ ((5 * pow(t, 4) - 40 * pow(t, 3) + 105 * pow(t, 2) - 100 * t + 24) / 120) * T[0][6]);
		cout << endl;
		cout << "Производная первого порядка от (" << point << ") =" << ans
			<< endl;
		//вторая производная
		ans = (1 / pow(h, 2)) * (T[0][3] + ((6 * t - 6) / 6) * T[0][4] + ((12 *
			pow(t, 2) - 36 * t + 22) / 24) * T[0][5] + ((20 * pow(t, 3) - 120 * pow(t, 2) + 210 * t -
				100) / 120) * T[0][6]);
		cout << "Производная второго порядка от (" << point << ") =" << ans
			<< endl;
		break;
	case 2:
		//первая производная
		t = (point - T[n][0]) / h;
		ans = (1 / h) * (T[n - 1][2] + ((2 * t + 1) / 2) * T[n - 2][3] + ((3 *
			pow(t, 2) + 6 * t + 2) / 6) * T[n - 3][4] + ((4 * pow(t, 3) + 18 * pow(t, 2) + 22 * t + 6)
				/ 24) * T[n - 4][5]);
		cout << endl;
		cout << "Производная первого порядка от (" << point << ") =" << ans
			<< endl;
		//вторая производная
		ans = (1 / pow(h, 2)) * (T[n - 2][3] + (t + 1) * T[n - 3][4] + ((pow(t,
			2) / 2) + ((3 * t) / 2) + 11 / 12) * T[n - 4][4]);
		cout << "Производная второго порядка от (" << point << ") =" << ans
			<< endl;		
		break;
		cout << endl;
	}
}

