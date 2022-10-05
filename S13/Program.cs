// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число: ");
int a1 = int.Parse(Console.ReadLine()!);
int b1 = 1;

if (a1 > 999)
{
    while (a1 > 999)
    {
        a1 = a1 / 10;
        b1++;
    }
    Console.WriteLine(a1 % 10);
}
else if (a1 > 99 && a1 < 1000)
{
    Console.WriteLine(a1 % 10);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}