// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Cube(int num)
{
    int num1 = 1;
    while (num1 <= num)
    {
        int cube = num1 * num1 * num1;
        Console.Write($"{num1} ");
        Console.WriteLine(cube);
        num1++;
    }
    return num;
}
int result = Cube(number);