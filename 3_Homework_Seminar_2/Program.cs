//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());

while (number <= 0 || number > 7) 
{
    Console.WriteLine("Введите число от 1 до 7");
    number = Convert.ToInt32(Console.ReadLine());
}
    if (number >= 6)
    {
        Console.WriteLine("День является выходным");
    }
    else
    {
        Console.WriteLine("День Не является выходным");
    }