// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Задайте первое положительное целое число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте второе положительное целое число:");
int n = Convert.ToInt32(Console.ReadLine());

int AkermanNumber(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AkermanNumber(m - 1, 1);
    }
    else
    {
        return AkermanNumber(m - 1, AkermanNumber(m, n - 1));
    }
}

Console.Write(AkermanNumber(m, n));
