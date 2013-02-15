using System;

class Matrix 
{
    public int x,y;
    public int[,] arr;
    public Matrix()
    {
        x = 0;
        y = 0;
    }
    public Matrix(int x,int y)
    {
        x = this.x;
        y = this.y;
        for (int i = 0; i < x; i++)
		{
		    for (int j = 0; j < y; j++)
			{
                arr[x, y] = i * x + j;
			}	 
		}
    }
    public int[,] addMatrix(int xTwo,int yTwo,int[,] matrixToAdd)
    {
        xTwo = x;
        yTwo = y;
        int[,] totalMat = new int[xTwo, yTwo];
        for (int i = 0; i < xTwo; i++)
        {
            for (int j = 0; j < yTwo; j++)
            {
                totalMat[i, j] = arr[i, j] + matrixToAdd[i, j];
            }
        }

        return totalMat;
    }
    public int[,] subtrMatrix(int xTwo, int yTwo, int[,] matrixToSubtr) 
    {
        xTwo = x;
        yTwo = y;
        int[,] totalMat = new int[xTwo, yTwo];
        for (int i = 0; i < xTwo; i++)
        {
            for (int j = 0; j < yTwo; j++)
            {
                totalMat[i, j] = arr[i, j] - matrixToSubtr[i, j];
            }
        }

        return totalMat;
    }
    public int[,] multiMatrix(int xTwo, int yTwo, int[,] matrixToMult)
    {
        xTwo = x;
        yTwo = y;
        int[,] totalMat = new int[xTwo, yTwo];
        for (int i = 0; i < xTwo; i++)
        {
            for (int j = 0; j < yTwo; j++)
            {
                totalMat[i, j] = arr[i, j] * matrixToMult[i, j];
            }
        }

        return totalMat;
    }
    int getNumberWithPosition(int x, int y) 
    {
        return arr[x, y];
    }

    string toString() 
    {
        int[] matrixToString = new int[this.x * this.y];
        int k = 0;
        for (int i = 0; i < this.x; i++)
        {
            for (int j = 0; j < this.y; j++)
            {
                matrixToString[k] = arr[i, j];
                k++;
            }
        }
        string arrToString = string.Join("", matrixToString);

        return arrToString;
    }
}
class classMatrix
{
    static void Main()
    {

    }
}

