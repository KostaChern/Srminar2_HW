﻿// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console. Clear();
int num = new Random().Next(100, 1000);
System.Console.WriteLine(num);

int num1 = num/10;
int num2 = num1 % 10;

System.Console.WriteLine($"вторая цифра это {num2}");





