﻿//Программа приниает число и проверяет кратно ли оно 7 и 23.
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"{number} -> да");
}
else
{
    Console.WriteLine($"{number} -> нет");
}