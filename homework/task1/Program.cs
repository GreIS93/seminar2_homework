// Показать числа от -N до N
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = -n; //возникает проблема с отрицательным числом, необходимо доработать
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
        Console.Write(col[position]+" ");
        position++;
    }
}

int i = Math.Abs(n) * 2 + 1;
int[] array = new int[i];
FillArray(array);
PrintArray(array);
