// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.

Console.WriteLine("Введите первое число: ");
Console.WriteLine("Введите второе число: ");
int a,b;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
if (a>b) {
    Console.WriteLine ("Максимальное число number: " +a);
}
else if (b>a) {
    Console.WriteLine ("Максимальное число number: " +b);
}
else if (a==b) {
    Console.WriteLine ("Числа равны");
}
