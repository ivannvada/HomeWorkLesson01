/*Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98

1.Создаем рандомное трехзначное число
2.Удаляем вторую цифру этого числа*/

int getRandomValue()
{
return new Random().Next(100, 1000);
}

int DeleteSecondNumber(int number)
{
return (number / 100) * 10 + (number % 10);
}

int number = getRandomValue();
int result = DeleteSecondNumber(number);
Console.WriteLine($"Было {number}, стало {result}.");
