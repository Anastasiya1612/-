// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = 7;
// int num2 = 23;

// result =  

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 7;
int num2 = 23;

bool MuLOfTwoNumbs (int num, int num1, int num2)
{
    return num % num1 == 0 && num % num2 == 0 Console.WriteLine("Да");
    else Console.WriteLine("Нет");
    
}
bool result = MuLOfTwoNumbs(num);


