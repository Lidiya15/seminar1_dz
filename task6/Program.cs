// 6 Напишите программу , которая на вход принимает число и выдает, является ли число четным ( делится ли оно
// на 2 без остатка)

Console.WriteLine("Введите натуральное число");
int numberA = Convert.ToInt32(Console.ReadLine());
int x = numberA % 2;
if(x == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}

