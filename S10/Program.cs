﻿// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите трёхзначное число: ");
int a1 = int.Parse(Console.ReadLine()!);

if (a1 > 99 && a1 < 1000)
{
    int num = ((a1 / 10) % ((a1 / 100) * 10));
    Console.WriteLine($"{a1} - > {num}");
}
else
{
    Console.WriteLine("Введённое число не трехзначное, введите правильное значение");
}