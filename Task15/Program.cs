//  Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
int num = new Random().Next(1, 8);
System.Console.WriteLine(num);

if (num < 6)
{
    System.Console.WriteLine($" {num} день недели не является выходным");
}

else
{
    System.Console.WriteLine($" {num} день недели  ВЫХОДНОЙ!!");
}
