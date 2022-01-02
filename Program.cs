// Создаем массив из 10 элементов
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

// печатаем массив
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0; 
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];

int[] EvenNumbers(int[] array)
{
    int[] array2 = new int[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            array2[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref array2, count);
    return array2;
}


Console.WriteLine("Mассив, из которого необходимо вычленить четные числа");
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Новый массив из четных чисел");
PrintArray(EvenNumbers(array));