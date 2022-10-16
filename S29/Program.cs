// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length && i < 8; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + ", ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Введите числовой массив: ");
string Numbers = Console.ReadLine()!;

int[] array = GetArrayFromString(Numbers);
PrintArray(array);
