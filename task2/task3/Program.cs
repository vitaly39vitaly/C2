﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console.WriteLine("Введите трехзначное число:");
int number = int.Parse(Console.ReadLine()!);
int firstValue = number/10;
int secondValue = firstValue%10;
Console.WriteLine(number + " " + secondValue );