#include <iostream>

int main()
{
    int const N = 100000;
    int n = 50, p = 0, k = N - 1, count = 0, d = 2;
    char a[N] = { 0 };
    char b[N] = { 0 };
    char c[N] = { 0 };
    a[N - 1] = b[N - 1] = 1;

    for (int i = 0; i < n; i++)
    {
        for (int j = N - 1; j >= k; j--)
        {
                c[j] = (a[j] + b[j] + p) % 10;
                if (a[j] + b[j] + p > 9)
                {
                    p = 1;
                    if (j == k)
                    {
                        k--;
                    }
                }
                else
                {
                    p = 0;
                }
        }

        for (int i = 0; i < N; i++)
        {
            a[i] = b[i];
            b[i] = c[i];
        }

        for (int i = k; i < N; i++)
        {
            if (c[i] == 0)
            {
                count++;
            }
            else if (count == d)
            {
                break;
            }          
            else
            {
                count = 0;
            }
        }
    }

    if (count == d)
    {
        for (int i = k; i < N; i++)
        {
            std::cout << (int)c[i] << " ";
        }
    }
}
