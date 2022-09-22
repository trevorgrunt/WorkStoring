#include<iostream>

int main()
{
    clock_t time = clock();
    int const n = 100000;
    int arr[n];
    std::cout << "Unsorted: " << std::endl;
    for (int i = 0; i < n; i++)
    {
        arr[i] = rand() % 100;
        std::cout << arr[i] << " ";;
    }

    // Шаг 1: Нахождение максимального элемента
    int maximum = arr[0];
    for (int i = 1; i < n; i++) 
    {
        maximum = std::max(maximum, arr[i]);
    }

    // Шаг 2: Подсчет количества цифр максимального числа
    int digits = 0;
    while (maximum > 0) 
    {
        digits++;
        maximum /= 10;
    }

    // Шаг 3, 4, 5: Расположение числа на основе цифр
    for (int i = 0; i < digits; i++) 
    {
        // Единицы/Десятки/сотни - используется для определения того, какая цифра
        int power = pow(10, i);

        // Содержит обновленный массив 
        int new_array[n];

        // Подсчет массива сортировки - требуется для упорядочивания цифр [0-9]
        int count[10];

        // Инициализация Массива Подсчетов
        memset(count, 0, sizeof(count));

        // Вычисление повторяемости цифр
        for (int j = 0; j < n; j++) 
        {
            // Цифра, рассматриваемая в этой итерации
            int num = (arr[j] / power) % 10;
            count[num]++;
        }

        // Общая повторяемость массива подсчетов
        for (int j = 1; j < 10; j++) 
        {
            count[j] += count[j - 1];
        }

        // Назначение новых позиций в обновленном массиве
        for (int j = n - 1; j >= 0; j--) 
        {
            // Цифра, рассматриваемая в этой итерации
            int num = (arr[j] / power) % 10;
            new_array[count[num] - 1] = arr[j];
            count[num]--;
        }

        // Обновление исходного массива с помощью нового массива
        for (int j = 0; j < n; j++)
        {
            arr[j] = new_array[j];
        }           
    }
    
    std::cout << std::endl << "Sorted: " << std::endl;
    for (int j = 0; j < n; j++)
    {
        std::cout << arr[j] << " ";
    }       
    std::cout << std::endl << "Time = " << (static_cast<double>(clock() - time) / CLOCKS_PER_SEC);
}