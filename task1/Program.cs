//Программа принимает на вход 2 числа и проверяет, кратно ли 2 число первому
Console.Clear();
Console.WriteLine("Введите 1 число:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 2 число:");
int b = int.Parse(Console.ReadLine()!);
int result = 0;
double result1 = 1;
if (b%a == 0)
{
    result b / a;
    Console.WriteLine($"{b}, {a} - кратно");
}
else
{
    result1 b % a;
    Console.WriteLine($"{b},{a} - не кратно, остаток{result2}");
}

