// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

// if (num > 99 && num <1000) 
// {
// int result = (num / 10) % 10;
// Console.WriteLine($"Вторая цифра: {result}");
// }
// else 
// Console.WriteLine("Некорректный ввод");

if (num > 99 && num <1000)
{
    int FindSecondDigit (int num)
    {
        int second = (num/ 10) % 10;
        return second;
    }
    int result = FindSecondDigit(num);
    Console.WriteLine($"Вторая цифра: {result}");
}
else 
Console.WriteLine("Некорректный ввод");