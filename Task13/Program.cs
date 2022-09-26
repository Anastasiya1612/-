// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int digit = number;
if (number < 100) Console.Write("Третьей цифры нет");
else
{
    while (digit> 999)
    { 
    digit = digit / 10;
    } 
int result = digit % 10;

Console.Write($"Третья цифра числа {number} - {result}");
}