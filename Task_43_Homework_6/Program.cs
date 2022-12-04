// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите координаты: ");
Console.WriteLine("Введите значение b1: ");
Console.WriteLine("Введите значение k1: ");
Console.WriteLine("Введите значение b2: ");
Console.WriteLine("Введите значение k2: ");

double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());

double PointX(double b1, double k1, double b2, double k2)
{
    double x=0;
    if (k1 == k2) Console.WriteLine("Прямые не пересекаются");
    else
    { x = (b2 - b1) /(k1 - k2); }
    return x;
}

double PointY(double b1, double k1, double b2, double k2)
{
    double y=0;
    if (k1 == k2) Console.WriteLine("Прямые не пересекаются");
    else
    { y = k1 * ((b2 - b1)/ (k1 - k2)) + b1; }
    return y;
}

double crossingX = PointX(b1,k1,b2,k2);
double crossingY = PointY(b1,k1,b2,k2);
Console.WriteLine($"Точка пересечения прямых ({crossingX};{crossingY})");
