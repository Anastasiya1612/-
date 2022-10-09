// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

// точка пересечения
// x = (b2 - b1)/(k1 - k2)
// y = k1(b2 - b1)/(k1 - k2) + b1

void FindPoints (double a, double b, double c, double d)
{
    if (a == c && b == d) Console.WriteLine("Прямые совпадают");
    else if (b == d) Console.WriteLine("Прямые параллельны");
    else
    {
        double pointX = (c - a)/(b - d);
    double pointY = b*(c - a)/(b - d) + a;
    Console.WriteLine($"Точка пересечения: ({pointX:0.0}, {pointY:0.0})");
    }
}

FindPoints(b1, k1, b2, k2);