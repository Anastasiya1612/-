// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

void SquareNumber(int num)
{
    int i = 1;
    if (num > 0)
    {
        while (i <= num)
        {
            Console.WriteLine($"{i,3}| {Math.Pow((i), 2),3}|");
            i++;
        }
    }
    else
    {
        Console.WriteLine("Некорректный ввод");
    }
}

SquareNumber(N);