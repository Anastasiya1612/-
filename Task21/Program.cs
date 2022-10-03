// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A");
Console.Write("X: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("X: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zB = Convert.ToInt32(Console.ReadLine());

double LenghtLine (int ax, int ay, int az, int bx, int by, int bz)
{
    int x = bx - ax;
    int y = by - ay;
    int z = bz - az;
    return Math.Sqrt(x * x + y * y + z * z);
}
double lenghtAB = LenghtLine(xA, yA, zA, xB, yB, zB);
double lenght = Math.Round(lenghtAB, 2, MidpointRounding.ToZero);
Console.WriteLine($"A ({xA}, {yA}, {zA}); B ({xB}, {yB}, {zB}) -> {lenght}");