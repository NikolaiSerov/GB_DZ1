// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void CheckElements3(string[] arraystart, string[] arrayend)
{
    int count = 0;
    for (int i = 0; i < arraystart.Length; i++)
    {
        if (arraystart[i].Length <= 3)
        {
            arrayend[count] = arraystart[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}

Console.Clear();
string[] Array = { "Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science" };
string[] Result = new string[Array.Length];
CheckElements3(Array, Result);
PrintArray(Result);
