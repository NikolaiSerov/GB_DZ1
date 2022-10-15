// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetSumm(int[] numArray)
{
    int summ = 0;
    for (int i = 0; i < numArray.Length; i++)
    {
        if (i % 2 == 1)
        {
            summ = summ + numArray[i];
        }
    }
    return summ;
}

Console.Clear();
Console.WriteLine("Введите необходимое количество чисел в массиве: ");
int S = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное число в массиве: ");
int minNum = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное число в массиве: ");
int maxNum = int.Parse(Console.ReadLine()!);
int[] array = GetArray(S, minNum, maxNum);
Console.WriteLine(string.Join(", ", array));
int result = GetSumm(array);


Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {result}");
