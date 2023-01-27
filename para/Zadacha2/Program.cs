/*Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98

1.Создаем рандомное трехзначное число
2.Удаляем вторую цифру этого числа*/

int GetRandomValue()
{
    return new Random().Next(100, 999);
}

int DeliteTwoNumber(int Number)
{
    return (Number / 100) * 10 + (Number % 10);
}

int Number = GetRandomValue();
int result = DeliteTwoNumber(Number);

Console.WriteLine($"Загаданное число {Number}, стало {result}");

