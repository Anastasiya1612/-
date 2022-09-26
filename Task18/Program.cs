// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
string quarterNum = Convert.ReadLine();

string FindRange(int num)
{
    string phrase = "Диапазон возможных координат точек находится в пределах ";
     if(num == "1") return $"{phrase} X > 0 и Y > 0";
     if(num == "2") return $"{phrase} X < 0 и Y > 0";
     if(num == "3") return $"{phrase} X < 0 и Y < 0";
     if(num == "4") return $"{phrase} X > 0 и Y < 0";
     return "Некорректный ввод";
}

string range = FindRange(quarterNum);
Console.WriteLine(range);