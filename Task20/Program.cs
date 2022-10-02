// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки A");
Console.Write("X: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("X: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yB = Convert.ToInt32(Console.ReadLine());

double LenghtLine (int ax, int ay, int bx, int by)
{
    int x = bx - ax;
    int y = by - ay;
    return Math.Sqrt(x * x + y * y);
}
double lenghtAB = LenghtLine(xA, yA, xB, yB);
double lenght = Math.Round(lenghtAB, 2, MidpointRounding.ToZero);
Console.WriteLine($"A ({xA}, {yA}); B ({xB}, {yB}) -> {lenght}");