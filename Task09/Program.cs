// 9. Напишите программу, которая выводит
// 1. случайное число из отрезка [10, 99] и 
// 2. показывает наибольшую цифру числа.
// 3. вывод результата

// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
System.Console.WriteLine ($"Случайное число из отрезка 10 - 99 => {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;


if (firstDigit == secondDigit) System.Console.WriteLine ("Цифры одинаковые");
else if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} => {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа {number} => {secondDigit}");
