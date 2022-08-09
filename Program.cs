//  Написать программу,которая из имеющегося массива строк формирует массив из строк,
//  длина которых меньше либо равна 3 символа.
//  Первоначальный массив можно ввести с клавиатуры,либо задать на старте выполнения.

string[] Array = { "Geek", "Brains", "you", "do" };

void PrintArray()
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + " ");
    }
    Console.WriteLine();
}

void SortLengthElements()
{
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
            Console.Write(Array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Заданный массив:");
PrintArray();
Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символа:");
SortLengthElements();
