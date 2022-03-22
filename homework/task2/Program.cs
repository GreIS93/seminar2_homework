// Показать четные числа от 1 до N
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = -n;
        index++;
        n--;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        if (col[position] % 2 == 0)
        {
            Console.Write(col[position] + " ");
            position++;
        }
    }
}
int i = Math.Abs(n) + 1;
int[] array = new int[i];
FillArray(array);
PrintArray(array);
