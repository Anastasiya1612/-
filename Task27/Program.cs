// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbersOfDigits(int num)
{
    int count = default;
    int digit = default;
    int sum = default;
    while (num > 0)
    {
        digit = num % 10;
        sum = sum + digit;
        num = num / 10;
        count++;
    }
    return sum;
}

int numDigits = SumNumbersOfDigits(number);
Console.WriteLine($"Сумма цифр в числе {number} - {numDigits}");