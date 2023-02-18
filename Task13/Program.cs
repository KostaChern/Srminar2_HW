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
bool Validate(int numb)
{
    if (numb > 99)
    {
        return true;
    }

    Console.WriteLine("третьей цифры в числе нет");
    return false;
}


if (Validate(num))
{

    while (num > 1000)
    {
        num = num / 10;
    }

    num = num % 10;
    System.Console.WriteLine($"третья цифра числа равна {num}");
}



