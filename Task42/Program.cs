// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


void ConvertNumInBinarySistem (int a)
{
    string bin = default;
    if (a > 0)
    {
      bin += a % 2;  
      ConvertNumInBinarySistem(a / 2);
    }
    Console.Write(bin);

}

void ConvertNumInBinarySistem2 (int a)
{
    if (a == 0) return;
    ConvertNumInBinarySistem(a / 2);
    Console.Write(a % 2);
}

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
ConvertNumInBinarySistem(n);