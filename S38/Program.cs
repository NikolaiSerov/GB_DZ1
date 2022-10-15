// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] GetArray(int size)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
    return res;
}

double GetRaznost(double[] numArray)
{
    double minNumber = numArray[0];
    double maxNumber = 0;
    double raznost = maxNumber - minNumber;
    for (int i = 0; i < numArray.Length; i++)
    {

        if (numArray[i] < minNumber)
        {
            minNumber = numArray[i];
        }
        if (numArray[i] > maxNumber)
        {
            maxNumber = numArray[i];
        }
        raznost = maxNumber - minNumber;
    }
    return raznost;
}

void PrintArray(double[] numbers)
{
    
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();

}
Console.Clear();
Console.WriteLine("Введите необходимое количество чисел в массиве: ");
int S = int.Parse(Console.ReadLine()!);

double[] array = GetArray(S);
PrintArray(array);
double result = GetRaznost(array);


Console.WriteLine($"разница между максимальным и минимальным элементами массива равна: {result}");
