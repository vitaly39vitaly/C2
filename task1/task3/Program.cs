// программа принимает на вход 2 числа и проверяет, ывляется ди одно квадратом другого
// Console.Clear();
// Console.WriteLine("Введите 1 число:");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите 2 число:");
// int b = int.Parse(Console.ReadLine()!);
// int x = 0;//квадрат меньшего числа
// if (a>b)
// {
//     x=b*b;
//     if (x ==a)
//         Console.WriteLine($"{a}, {b} -> да");
// }
// else if (a<b)
// {
//     x=a*a;
//     if(x==b)
//         Console.WriteLine($"{a}, {b} -> да");
//     else
//     {
//         Console.WriteLine($"{a}, {b} -> нет");
//     }    
// }

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine()!);

string res = "";
if(number2*number2 != number1 $$ number1*number1 != number2)
{
    res = ("Нет");
}
else
{
    res = ("Да");
}
Console.WriteLine(res);
