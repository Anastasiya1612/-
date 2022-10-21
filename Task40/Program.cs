// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Введите длинну первой стороны: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длинну второй стороны: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длинну третьей стороны: ");
int numC = Convert.ToInt32(Console.ReadLine());

bool TringleReal (int a, int b, int c)
{
    bool result = false;
    if ((a+b > c) || (a+c> b) || (c + b > a)) result = true;
    return result;
}

if (TringleReal (numA, numB, numC)) Console.Write("Треугольник с такими сторонами не может существовать");
else Console.Write("Треугольник с такими сторонами может существовать");