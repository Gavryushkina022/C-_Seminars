// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

int[,] matrix = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
Console.WriteLine("Задайте индекс элемента:");
string[] elementIndex = Console.ReadLine()!.Split(",");

void GetElementFromMatrixByIndex(string[] elementIndex)
{
    if (Convert.ToInt32(elementIndex[0]) > (matrix.GetLength(0) - 1) || Convert.ToInt32(elementIndex[1]) > (matrix.GetLength(1) - 1))
    {
        Console.WriteLine($"Элемента с индесом [{elementIndex[0]},{elementIndex[1]}] в массиве нет!");
    }
    else
    {
        Console.WriteLine(matrix[Convert.ToInt64(elementIndex[0]), Convert.ToInt64(elementIndex[1])]);
    }
}

GetElementFromMatrixByIndex(elementIndex);