// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());
if (a == b * b)
{
    Console.Write("Число " + a + " является квадратом числа " + b);
}
else if (b == a * a)
{
    Console.Write("Число " + b + " является квадратом числа " + a);
}
else
{
    Console.Write("Числа " + a + " и " + b + " не являются квадратами друг друга");
}

