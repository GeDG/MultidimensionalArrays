using System;

class fillsAndPrintsMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[n, n];
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[j, i] = i * n + j;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(arr[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}

