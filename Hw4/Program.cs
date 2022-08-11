// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Пример:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число: ");
int d = Convert.ToInt32(Console.ReadLine());

if (a > b && a > d)
{
    Console.WriteLine($"Число {a} больше числа {b} и больше числа {d}, ответ:  ({a}) ");
}
else if (b > a && b > d)
{
    Console.WriteLine($"Число {b} больше числа {a} и больше числа {d}, ответ:  {b}");
}
else if (d > a && d > b)
{
    Console.WriteLine($"Число {d} больше числа {a} и больше числа {b}, ответ:  {d}");
}

