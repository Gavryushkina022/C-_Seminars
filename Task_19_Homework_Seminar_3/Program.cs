﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

int first = number / 10000;
int fivth = number % 10;
int second = (number / 1000) % 10;
int throuth = (number % 100) / 10;

if (first == fivth && second == throuth)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является полиндромом");
}


