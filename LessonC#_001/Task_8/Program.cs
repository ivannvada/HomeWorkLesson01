/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Введите число:");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

int a = 2;

if(number > 1)
{
    while(a <= number)
    {
        Console.WriteLine(a + " ");
        a = a + 2;
    }
}