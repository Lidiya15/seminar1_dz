// 2 Напишите программу, которая на вход принимает 2 числа и выдает, 
// какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int y = Convert.ToInt32(Console.ReadLine());
if (x>y) Console.WriteLine("Первое число большее");
else 
if (y>x) Console.WriteLine("Второе число большее");
