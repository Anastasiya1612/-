// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.

// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7)
{
    Console.Write("Такого дня недели нет");
}

if (number < 1)
{
    Console.Write("Такого дня недели нет");
}

if (number == 1)
{
    Console.Write("Понедельник");
}

if (number == 2)
{
    Console.Write("Вторник");
}

if (number == 3)
{
    Console.Write("Среда");
}

if (number == 4)
{
    Console.Write("Четверг");
}

if (number == 5)
{
    Console.Write("Пятница");
}

if (number == 6)
{
    Console.Write("Суббота");
}

if (number == 7)
{
    Console.Write("Воскресенье");
}