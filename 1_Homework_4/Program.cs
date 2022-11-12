// Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.

Console.WriteLine("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int index = 1;
while (index <= numberN)
{
    if (index % 2 == 0)
    {
        Console.WriteLine(index);
    }
    index++;
}

