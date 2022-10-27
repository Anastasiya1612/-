// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);

Console.WriteLine();
Console.WriteLine("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());


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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]} | ");
            else Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine("|");
    }
}

int FindElement (int[,] matrix, int r, int col)
{
    int findElement = default;
    if (r < matrix.GetLength(0) && col < matrix.GetLength(1)) findElement = matrix[r-1, col-1];
    return findElement;
}

void PrintElement(int element)
{
    if (element != 0) Console.WriteLine($"{element}");
    else Console.WriteLine("Такого элемента в массиве нет");
}


int elementOfArray2D = FindElement(array2D, row, column);
PrintElement(elementOfArray2D);