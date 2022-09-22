#include <iostream>
#include <list>
#include <cmath>

int main()
{
	clock_t time = clock();
	std::list<int> Sp;
	std::list<int> C;
	int const N = 10;
	int n = 4	;
	int n1 = n;
	std::list<int>::iterator i;
	std::list<int>::iterator t;
	std::cout << "First array: ";
	for (int i = 0; i < N; i++) //Ввод 1
	{
		Sp.push_back(rand() % int(pow(10, n)));
	}

	for (i = Sp.begin(); i != Sp.end(); i++) //Вывод 1
	{

		std::cout << (*i) << std::endl;
	}
	n = 0;
	for (int i1 = 0; i1 < n1; i1++)
	{
		int j = -1;
		n++;
		for (i = Sp.begin(); i != Sp.end(); i++) //Цифра справа
		{
			j++;
			for (t = Sp.begin(); t != Sp.end(); t++)
			{
				if ((*t % (int(pow(10, n)))) / (int(pow(10, n - 1))) == j)
				{
					C.push_back(*t);
				}
			}
		}
		Sp.erase(Sp.begin(), Sp.end()); //Очистка
		for (t = C.begin(); t != C.end(); t++)
		{
			Sp.push_back(*t);
		}
		C.erase(C.begin(), C.end());
	}
	std::cout << "Second array: "; //Вывод 2
	for (i = Sp.begin(); i != Sp.end(); i++)
	{
		std::cout << (*i) << std::endl;
	}
    std::cout << "Time = " << (static_cast<double>(clock() - time) / CLOCKS_PER_SEC);
}