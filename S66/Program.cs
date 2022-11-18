// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int PrintNumbers(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    // Console.WriteLine($"{start}");
    return start + PrintNumbers(start + 1, end);
}

Console.Clear();
Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);
int result = PrintNumbers(M, N);
Console.WriteLine(result);