﻿/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

Console.WriteLine("Введите число:");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

int a = number % 2;

if (a == 0)
{
    Console.WriteLine("да");
}
else 
{
    Console.WriteLine("нет");
}