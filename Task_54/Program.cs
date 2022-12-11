// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

double[,] matrix = new double[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

double[,] sortMatrixByDesc(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0);i++)
    {
        bool needSort = true;
        while (needSort)
        {
            needSort = false;
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                double currentElement = matrix[i, j];
                if (matrix[i, j + 1] > matrix[i, j])
                {
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = currentElement;
                    needSort = true;
                }
            }
        }
    }

    return matrix;
}

void printMatrix(double[,] matrix){
     for (int i = 0; i < matrix.GetLength(0);i++)
    {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j]+ " ");
            }
            Console.WriteLine();
    }
    }

double[,] sotredMatrix=sortMatrixByDesc(matrix);
printMatrix(sotredMatrix);
