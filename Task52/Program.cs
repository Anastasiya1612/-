// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2}  | ");
            else Console.Write($"{matrix[i, j],2}  ");
        }
        Console.WriteLine("|");
    }
}

// double[] AvgOfColumns(int[,] matrix)
// {
//     double[] average = new double[matrix.GetLength(1)];
//     double avg = default;
//     double sum = default;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {

//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             sum += matrix[i, j];
//         }
//         avg = sum / matrix.GetLength(0);
//         average[0] = avg;

//     }
//     return average;
// }

void PrintAvgColumns(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double average =0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average += matrix[i,j];
        }
        average = average / matrix.GetLength(0);
        Console.Write($"{average: 0.00} ");
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]:0.00}, ");
        else Console.Write($"{array[i]:0.00}");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);

PrintAvgColumns(array2D);
// double[] avg = AvgOfColumns(array2D);
// PrintArray(avg);