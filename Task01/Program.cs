﻿// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.

// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Введите целое число a: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int square = numberB * numberB;

if (square == numberA) 
{
    Console.WriteLine("Да");
}
else 
{
     Console.WriteLine("Нет");
}