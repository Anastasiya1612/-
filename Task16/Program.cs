// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
SquareNumber(numberA, numberB)
{
    
}



// bool (numberA*numberA == numberB)

// int result = numberA % numberB;

// if(result == 0) Console.WriteLine($"Число {numberA} кратно числу {numberB}");
// else Console.WriteLine($"Не кратно, остаток {result}");

