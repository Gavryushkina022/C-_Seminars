// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double GetMaxElement(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length - 1; i++)
        if (array[i + 1] > max) max = array[i + 1];
    return max;
}

double GetMinElement(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length - 1; i++)
        if (array[i + 1] < min) min = array[i + 1];
    return min;
}

double Deduction(double max, double min)
{
    double ded = max - min;
    return Math.Round(ded, 1);
}

double[] arr = CreateArrayRndDouble(5, 1, 100);
PrintArray(arr);
double ded = Deduction(GetMaxElement(arr), GetMinElement(arr));
Console.WriteLine($"Разность между максимальным и минимальным элементами массива = {ded}");
