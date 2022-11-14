// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i,j] <10)
            {
                Console.Write("0" + Array[i,j]);
                Console.Write(" ");
            }
            else Console.Write(Array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ArraySpiral(int[,] Array, int n)
{
    int i = 0;
    int j = 0;
    int num = 1;
    while (num <= n * n)
    {
        Array[i, j] = num;
        if (i <= j + 1 && i + j < n - 1)
            ++j;
        else if (i < j && i + j >= n - 1)
            ++i;
        else if (i >= j && i + j > n - 1)
            --j;
        else
            --i;
        ++num;
    }
}

Console.Clear();
int n = 4;
int[,] array = new int[n, n];
ArraySpiral(array, n);
PrintArray(array);