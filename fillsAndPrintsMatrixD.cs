using System;


class fillsAndPrintsMatrixD
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int number = 0;
        int[,] arr = new int[n, n];
        int x = 0, y = 0;
        int size = n;

        while (size > 0)
        {
            for (int i = y; i <= y + size - 1; i++)
            {
                arr[i, x] = number++;
            }

            for (int j = x + 1; j <= x + size - 1; j++)
            {
                arr[y + size - 1,j] = number++;
            }

            for (int i = y + size - 2; i >= y; i--)
            {
                arr[i, x + size - 1] = number++;
            }

            for (int i = x + size - 2; i >= x + 1; i--)
            {
                arr[y, i] = number++;
            }

            x++;
            y++;
            size -= 2;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(arr[i, j] + "  ");
            }
            Console.WriteLine();
        }
    }
}

