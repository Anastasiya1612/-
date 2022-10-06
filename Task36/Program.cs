// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void SumOddNumbers (int[] array)
{
    int sumOddElem = default;

    for (int i = 1; i < array.Length; i+= 2)
        if(i % 2 != 0) sumOddElem = sumOddElem + array[i];
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sumOddElem}");
}

int[] arr = CreateArrayRndInt(10, -99, 99);
PrintArray(arr);
SumOddNumbers(arr);