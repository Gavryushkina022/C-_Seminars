// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

double[,] matrix = new double[4, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };

double[] calcSumByRows(double[,] matrix)
{
    double[] sumByRows = new double[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            sum = +matrix[i, j];
        }
        sumByRows[i] = sum;
    }

    return sumByRows;
}

int getIndexWithMinValue(double[] array)
{
    int index = 1;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i + 1] < array[i])
        {
            index = i + 1;
        }
    }

    return index;
}

void printResult(int value)
{
    Console.Write($"{value}" + " строка");
}

double[] sumByRows = calcSumByRows(matrix);
int result = getIndexWithMinValue(sumByRows);
printResult(result);