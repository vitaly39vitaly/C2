//Программа выводит рандомно трехзгачное число и убирает 2 цифру из него
Console.Clear();
int number = new Random().Next(100,1000);
int firstValue = number/100;
int secondValue = number%10;
Console.WriteLine(number + " " + firstValue  + secondValue ;