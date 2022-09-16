// 0. Демонстрация решения

// Напишите программу, которая 
// 1. на вход принимает число и 
// 2. выдаёт его квадрат (число
// умноженное на само себя).
// 3. Вывод результата

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} - {square}");

// double number1 - Convert.ToDouble(Console.ReadLine());
// string str1 - Console.ReadLine();
// -2 147 483 648 до 2 147 483 647