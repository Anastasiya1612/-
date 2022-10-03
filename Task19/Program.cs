// Задача 19

// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int NumberTurn(int n)
{
    int fifth = n % 10;
    int fourth = (n / 10) % 10;
    int third = (n / 100) % 10;
    int second = (n / 1000) % 10;
    int first = (n / 10000) % 10;
    return fifth*10000 + fourth*1000 + third*100 + second*10 + first;
}
if (num > 9999 && num < 100000)
{ 
int numberTurn = NumberTurn(num);
if (num == numberTurn) Console.Write("Да");
else Console.Write("Нет");
}
else Console.Write("Некорректный ввод");



// Console.Write(num % 10);
// while ((num = num / 10)!=0)
// {
// int turn = num % 10;
// Console.Write(turn);
// }

// if (num == turn) Console.Write("Да");
// else Console.Write("Нет");