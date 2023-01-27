/*
Напишите программу, которая выводит случайное число из отрезка [10, 99]
и показывает наибольшую цифру числа.

Например:
78 -> 8
12-> 2
85 -> 8

1 - Ввыводим случайное число из отрезка 10 - 99.
2 - показываем наибольшую цифру.*/

int GetRandomNumber(int leftBound, int rightBound)
{
    int result = 0;
    Random rnd = new Random();
    result = rnd.Next(leftBound, rightBound + 1);
    return result;
}

int GetMaxDigitOfNumber(int number)
{
    int firstDigit = number / 10;
    int secontDigit = number % 10;
    if(firstDigit > secontDigit)
        return firstDigit;
    else
        return secontDigit;
}
int number = GetRandomNumber(10, 99);
int MaxDigit = GetMaxDigitOfNumber(number);
Console.WriteLine($"Максимальная цифра числа {number} = {MaxDigit}");