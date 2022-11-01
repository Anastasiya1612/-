// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int sum = SumDiapazNaturalNumbers(numberM, numberN);
Console.Write($"{sum}");

int SumDiapazNaturalNumbers(int num1, int num2)
{
    if (num1 < num2)
    {
        return num1 + SumDiapazNaturalNumbers(num1 + 1, num2);
    }
    if (num2 < num1)
    {
        return num1 + SumDiapazNaturalNumbers(num1 - 1, num2);
    }
    return num1 + num2;
}