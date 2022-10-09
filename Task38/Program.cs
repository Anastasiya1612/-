// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double [] CreateArrayRndInt(int size, double min, double max)
{
    double[] array = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
    }
    
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]:0.0}, ");
        else Console.Write($"{array[i]:0.0}");
    }
    Console.WriteLine("]");
}

double FindMax (double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array [i];
        }
    }
    return max;
}

double FindMin (double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array [i];
        }
    }
    return min;
}


double[] arr = CreateArrayRndInt(10, 1, 80);
PrintArray(arr);
double maxEl = FindMax(arr);
double minEl = FindMin(arr);
double difference = maxEl - minEl;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {difference:0.0}");