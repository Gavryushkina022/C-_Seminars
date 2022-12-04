// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через запятую: ");

string[] numbers = Console.ReadLine().Split(',');

void CountPositive(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((Convert.ToInt32(array[i]) > 0)) { count++; }
    }
    Console.WriteLine(count);
}

CountPositive(numbers);
