﻿// 8 Напишите программу, которая на вход принимает число N, а на выходе показывает 
// все четные числа от 1 до N.

Console.WriteLine("Введите натуральное число");
int x = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (count <= x)
{
   Console.Write(count + " ");
   count = count + 2;
}
Console.WriteLine();


