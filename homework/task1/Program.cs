// Показать числа от -N до N
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(-n, n);
        index++;
    }
}
void PrintArray(int[] arr)
{
    int count = arr.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(position);
        position++;
    }
}
