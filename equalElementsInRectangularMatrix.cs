using System;

class equalElementsInRectangularMatrix
{
    static int count = 0;
    static int maxCount = 0;
    static void eQ(int[,] arr, int x, int y, int num) 
    {
        if (y < 0 || x < 0 || x >= arr.GetLength(0) || y >= arr.GetLength(1))
        {
            return;
        }
        if (arr[x, y] == num)
        {
            count++;
            arr[x, y] = 0;
            eQ(arr, x + 1, y, num);
            eQ(arr, x, y + 1, num);
            eQ(arr, x, y - 1, num);
            eQ(arr, x - 1, y, num);
        }
    }
    static void maxSize(int[,] arr) 
    {
        for (int x = 0; x < arr.GetLength(0); x++)
        {
            for (int y = 0; y < arr.GetLength(1); y++)
            {
                if (arr[x, y] != 0)
                {
                    count = 0;
                    eQ(arr, x, y, arr[x, y]);
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }
            }
        }   
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int[,] arr = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            string row = Console.ReadLine();
            string[] cell = row.Split(' ');

            for (int j = 0; j < m; j++)
            {
                arr[i, j] = int.Parse(cell[j]);
            }
        }
        maxSize(arr);
        Console.WriteLine(maxCount);
    }
}

