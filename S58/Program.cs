// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    return result;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void MultiplayMatrix(int[,] first, int[,] second, int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int summ = 0;
            for (int n = 0; n < first.GetLength(1); n++)
            {
                summ += first[i, n] * second[n, j];
            }
            result[i, j] = summ;
        }
    }
}

Console.Clear();
Console.Write("Введите количество строк в первой матрице: ");
int rows1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в первой матрице и строк во второй: ");
int columns1rows2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов во второй vfnhbwt: ");
int columns2 = int.Parse(Console.ReadLine()!);


int[,] firstTable = GetArray(rows1, columns1rows2, 0, 10);
Console.WriteLine("Первая матрица");
PrintArray(firstTable);
Console.WriteLine();

int[,] secondTable = GetArray(columns1rows2, columns2, 0, 10);
Console.WriteLine("Вторая матрица");
PrintArray(secondTable);

int[,] resultTable = new int[rows1, columns2];

MultiplayMatrix(firstTable, secondTable, resultTable);
Console.WriteLine("Произведение первой и второй матриц:");
PrintArray(resultTable);
