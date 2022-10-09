// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[m];

void InputNumbers (int a)
{
    for (int i = 0; i < a; i++)
    {
        Console.WriteLine($"Введите {i+1}-е число: ");
        arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int NumbersGreaterZero (int[] array)
{
    int count = default;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count += 1;
    }
    return count;
}

InputNumbers(m);
int numGrZero = NumbersGreaterZero(arrayNumbers);
Console.WriteLine($"Чисел больше нуля: {numGrZero}");