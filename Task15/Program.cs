// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7 || number < 1)
{
    Console.Write("Такого дня недели нет");
}
else if (number == 6 || number == 7)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}