// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите номер дня недели");
int n = int.Parse(Console.ReadLine());

if (n == 6 || n == 7)
{
    Console.WriteLine("Сегодня выходной");
}
else 
{
    Console.WriteLine("Сегодня будний день");
}