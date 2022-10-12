// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Summ(int N)
{
    int sum = 0;
    while (N > 0)
    {
        int num = N % 10;
        sum = sum + num;
        N = N / 10;
    }
    return sum;
}


Console.Clear();
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
int result = Summ(n);
Console.WriteLine(result);