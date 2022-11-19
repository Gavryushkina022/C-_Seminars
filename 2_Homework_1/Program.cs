// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка от 100 до 1000 --> {number}");

int MinusMiddle(int num)
{
    int firstDigit = num % 100;
    int secondDigit = firstDigit / 10; 
    return secondDigit;
}
MinusMiddle(number);
Console.WriteLine(MinusMiddle(number));