// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите номер дня недели: ");
int a1 = int.Parse(Console.ReadLine()!);
if (a1 > 7)
{
    Console.WriteLine("А вы точно с планеты Земля?");
}

if (a1 > 1 && a1 < 6) 
{
    Console.WriteLine("НЕТ");
}
else
{
    Console.WriteLine("Да");
}