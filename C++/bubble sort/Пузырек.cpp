#include <iostream>

int main()
{
	clock_t t = clock();
	int const size = 10;
	int arr[size];
	std::cout << "Unsorted: " << std::endl;
	for (int i = 0; i < size; i++)
	{
		arr[i] = rand() % 100;
		std::cout << arr[i] << std::endl;
	}
	for (int i = 1; i < size; ++i)
	{
		for (int r = 0; r < size - i; r++)
		{
			if (arr[r] < arr[r + 1])
			{
				int temp = arr[r];
				arr[r] = arr[r + 1];
				arr[r + 1] = temp;
			}
		}
	}
	std::cout << "Sorted: " << std::endl;
	for (int i = 0; i < size; i++)
	{
		std::cout << arr[i] << std::endl;
	}
	std::cout << "Time = " << (static_cast<double>(clock() - t) / CLOCKS_PER_SEC);
	return 0;
}
