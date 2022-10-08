// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число");
int N = int.Parse(Console.ReadLine()!);

int a = N / 10000;
int b = N % 10;
int c = (N % 10000) / 1000;
int d = (N % 100) / 10;

if (a == b && c==d)
{
    Console.WriteLine($"Число {N} палиндром");
}
else
{
    Console.WriteLine($"Число {N} не палиндром");
} 