// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
int Promt(string msg)
{
    System.Console.WriteLine($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

int num = Promt(" Введите число >");