// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] creatreRandomMatrix(int rows, int colums, int depth, int min, int max)
{
    Random rnd = new Random();
    int[,,] matrix = new int[rows, colums, depth];
    List<int> exludedNumbers = new List<int>();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int generatedElement = generateUniqElement(rnd, exludedNumbers, min, max);
                matrix[i, j, k] = generatedElement;
                exludedNumbers.Add(generatedElement);
            }
        }
    }


    return matrix;
}

int generateUniqElement(Random rnd, List<int> exludedElements, int min, int max)
{
    int randomElement = rnd.Next(min, max);
    while (exludedElements.Contains(randomElement))
    {
        randomElement = rnd.Next(min, max);
    }
    return randomElement;
}

void printMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k})" + " ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] result = creatreRandomMatrix(2, 2, 2, 10, 99);
printMatrix(result);
