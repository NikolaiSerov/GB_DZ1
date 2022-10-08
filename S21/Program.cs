// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double Dist(int xa, int ya, int za, int xb, int yb, int zb)
{
    double l;
    l = Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb) * (za - zb));
    return l;
}

Console.Clear();
Console.Write("Введите значение координаты X отрезка А: ");
int xa = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение координаты Y отрезка А: ");
int ya = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение координаты Z отрезка А:");
int za = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение координаты X отрезка B: ");
int xb = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение координаты Y отрезка B: ");
int yb = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение координаты Z отрезка B:");
int zb = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Длина отрезка в 3D пространтсве равна : {Dist(xa, ya, za, xb, yb, zb):f2}");