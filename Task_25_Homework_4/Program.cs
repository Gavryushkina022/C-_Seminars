// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243
// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
Console.WriteLine("Введите степень: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

int Degree(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = result * num1;
    }
    return result;
}

if (numberB > 0)
{
    int degree = Degree(numberA, numberB);
    Console.WriteLine($"Число {numberA} в натуральной степени {numberB} = {degree}");
}
else Console.WriteLine("Требуется ввести натуральное число");