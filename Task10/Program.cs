// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num <1000) 
{
int first = num / 10;
int result = first % 10;
Console.WriteLine($"Вторая цифра: {result}");
}
else 
Console.WriteLine("Некорректный ввод");