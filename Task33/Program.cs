// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

void FindElement (int [] array, int findInt)
{
    int result = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == findInt) result = 1;
    }
    if (result == 1) Console.Write("В массиве есть данный элемент");
    else Console.Write("В массиве нет данного элемента");
}

int[] arr = CreateArrayRndInt(5, -9, 9);
PrintArray(arr);

Console.WriteLine("Введите элемент для поиска: ");
int number = Convert.ToInt32(Console.ReadLine());


FindElement(arr, number);