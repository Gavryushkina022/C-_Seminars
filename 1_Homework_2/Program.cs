// Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
Console.WriteLine("Введите второе число: ");
Console.WriteLine("Введите третье число: ");
int a, b, c;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write("Максимально число из трех: ");
Console.WriteLine(max);
