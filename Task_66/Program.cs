
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Задайте первое натуральное число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте второе натуральное число:");
int n = Convert.ToInt32(Console.ReadLine());

int NaturalNumbersSum(int num1, int num2)
{
    if (num1 > num2)
    {
        return num1 + NaturalNumbersSum(num1 - 1, num2);
    }
    else if (num1 < num2)
    {
        return num1 + NaturalNumbersSum(num1 + 1, num2);
    }
    else
    {
        return num1;
    }
}

Console.Write(NaturalNumbersSum(m, n));