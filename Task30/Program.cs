// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

Console.WriteLine("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] arrayGlobal = new int[num];
// array[0] = Random.Next (0, 1);
ArrayRandom(arrayGlobal);
PrintArray(arrayGlobal);

void ArrayRandom(int[] array)
{
    Random rnd = new Random(); // или var rnd = new Random();
    for (int i = 0; i <= array.Length - 1; i++) //VSC медленный, а кс быстрая
        array[i] = rnd.Next(0, 2);  //писать нужно так, потому что не в VSCode это будет работать иначе
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length - 1]}]");
}