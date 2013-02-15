using System;

class fillsAndPrintsMatrixC
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[n, n];
        int k = 0;
        int[] br = new int[n*n];

        for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < n; j++)
			{
                br[k] = i * n + j;
                k++;
			}
		}
        k = 0;

        for (int i = 1 - n; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if ((i + j) >= 0 && (i + j) < n) {
                    arr[j, i + j] = br[k];
                    k++;
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

