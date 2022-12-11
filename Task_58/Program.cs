// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

double[,] matrix1 = new double[2, 2] { { 2, 4 }, { 3, 2 } };
double[,] matrix2 = new double[2, 2] { { 3, 4 }, { 3, 3 } };


void multiplyMatrixs(double[,] matrix1, double[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Операция умножения двух матриц выполнима только в том случае, если число столбцов в первом сомножителе равно числу строк во втором!");
    }
    else
    {
        double[,] resultMatrix = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int k = 0; k < matrix2.GetLength(1); k++)
        {
            for (int i = 0; i < matrix1.GetLength(1); i++)
            {
                double sum = 0;
                int m = -1;
                int n = -1;
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    sum += matrix1[i, n + 1] * matrix2[m + 1, k];
                    n++;
                    m++;
                }
                resultMatrix[i, k] = sum;
            }
        }
        printMatrix(resultMatrix);
    }
}

void printMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

multiplyMatrixs(matrix1, matrix2);
