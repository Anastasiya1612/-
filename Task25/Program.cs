// Задача 25: Напишите цикл, который 
// принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int RaiseNumberToPower(int a, int b)
{
    int numberPower = 1;
    for (int i = 1; i <= b; i++)
    {
        numberPower = numberPower * a;
    }
    return numberPower;
}

Console.WriteLine("Введите число, которое нужно возвести в степень: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int numB = Convert.ToInt32(Console.ReadLine());

int res = RaiseNumberToPower(numA, numB);
Console.WriteLine($"Число {numA} в степени {numB} --> {res}");


