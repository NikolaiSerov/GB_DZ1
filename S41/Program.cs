// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


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


int GetCountZero(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}
Console.Clear();
Console.WriteLine("Введите числовой массив через запятую: ");
string Numbers = Console.ReadLine()!;

int[] array = GetArrayFromString(Numbers);
int result = GetCountZero(array);
Console.WriteLine($"Количество чисел больше 0 равно:{result}");