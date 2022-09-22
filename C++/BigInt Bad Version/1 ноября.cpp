#include <iostream>

void hoar(int arr[], int L, int R)
{
    int x, w, i, j;
    i = L;
    j = R;
    x = arr[(L + R) / 2];
    do
    {
        while (arr[i] < x)
        {
            i++;
        }
        while (x < arr[j])
        {
            j--;
        }
        if (i <= j)
        {
            if (i < j)
            {
                w = arr[i];
                arr[i] = arr[j];
                arr[j] = w;
            }
            i++;
            j--;
        }
    } 
    while (i <= j);
    if (L < j)
    {
        hoar(arr, L, j);
    }
    if (i < R)
    {
        hoar(arr, i, R);
    }
}

int main()
{  
    clock_t t = clock();
    int const size = 100000;
    int arr[size];
    std::cout << "Unsorted: " << std::endl;
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand() % 100;
        std::cout << arr[i] << std::endl;
    }       
    hoar(arr, 0, size-1);

    std::cout << "Sorted: " << std::endl;
    for (int i = 0; i < size; i++)
    {
        std::cout << arr[i] << std::endl;
    }
    std::cout << "Time = " << (static_cast<double>(clock() - t)/CLOCKS_PER_SEC);
    return 0;
}

