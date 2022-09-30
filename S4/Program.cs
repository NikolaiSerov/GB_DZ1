// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье число: ");
int numberC = int.Parse(Console.ReadLine()!);

if (numberA > numberB && numberA > numberC)
{ 
    Console.WriteLine($"MAX = {numberA}");
}
else if (numberB > numberC && numberB > numberA)
{
    Console.WriteLine($"Max = {numberB}");
}
else if (numberC  > numberB && numberC > numberA)
{
    Console.WriteLine($"Max = {numberC}");
}