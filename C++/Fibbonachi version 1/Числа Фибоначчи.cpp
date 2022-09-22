// Числа Фибоначчи.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>

int Fib(int n)
{
    if (n == 1 || n == 2) return (n - 1);
    return Fib(n - 1) + Fib(n - 2);
}

int main()
{
    int n;
    std::cout << "n = "; std::cin >> n;
    std::cout << Fib(n) << " ";
    std::cout << std::endl;
    system("pause");
    return 0;
}
