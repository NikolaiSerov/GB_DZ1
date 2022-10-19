// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double TochkaX(double B1, double K1, double B2, double K2)
{
    double X = (B2 - B1) / (K1 - K2);
    return X;
}

double TochkaY(double B1, double K1, double B2, double K2)
{
    double Y = K2 * ((B2 - B1) / (K1 - K2)) + B2;
    return Y;
}



Console.Clear();
Console.WriteLine("Введите b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k1: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2: ");
int b2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2: ");
int k2 = int.Parse(Console.ReadLine()!);
double rezultX = TochkaX(b1, k1, b2, k2);
double rezultY = TochkaY(b1, k1, b2, k2);
Console.WriteLine($"Координаты точки пересечения отрезков:({rezultX}; {rezultY})");