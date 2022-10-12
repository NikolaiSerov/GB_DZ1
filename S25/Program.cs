// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetStepen(int a, int b)
{
    int S = 1;
    if (b == 0)
    {
        S = 1;
    }
    else 
    {
        for (int i = 1; i <= b; i++)
        {
            S = S * a;
        }
    }

       return S;
}





Console.Clear();
Console.WriteLine("Введите основание степени: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите показатель степени: ");
int B = int.Parse(Console.ReadLine()!);
int result = GetStepen(A, B);
Console.WriteLine(result);
