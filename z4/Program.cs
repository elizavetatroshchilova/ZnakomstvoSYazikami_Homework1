﻿
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int max = a;
if (a>b & a>c) 
{
max = a;
Console.WriteLine(max);
}
else if (b>a & b>c)
{
    max =b;
    Console.WriteLine(max);
}
else 
{
if(c>a & c>b)
max = c;
Console.WriteLine(max);
}
