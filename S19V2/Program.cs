// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Palendrome(int num)
{
    int n = num;
    
       if (num / 10000 == num % 10 && (num % 10000) / 1000 == (num % 100) / 10)
    {
        Console.WriteLine($"Число {num} палиндром");
    }
    else
    {
        Console.WriteLine($"Число {num} не палиндром");
    }
    return (num);
}

Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Palendrome(N);