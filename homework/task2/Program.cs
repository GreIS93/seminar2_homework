// Показать четные числа от 1 до N
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    collection[0] = 1;
    while (index < length && n > 1)
    {
        collection[index] = ;
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
        Console.Write(col[position] + " ");
        position++;
    }
}

int[] array = new int[n];
FillArray(array);
PrintArray(array);
