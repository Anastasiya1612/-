// 11. Напишите программу, которая выводит случайное
// трёхзначное число и 
// удаляет вторую цифру этого
// числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка: {num}");
// int first = number / 100;
// int third = number % 10;
// int result = first*10 + third;
// Console.WriteLine($"Результирующее число: {result}");

int Double (int num)
{
    int first = num / 100;
    int third = num % 10;
    return first*10 + third;
}
int result = Double(num);
Console.WriteLine ($"Искомое число: {result}");



