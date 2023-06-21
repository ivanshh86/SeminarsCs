// Напишите программу, которая задаёт массив из произвольного количества элементов и выводит их на экран.

int[] FreeArray(int size)
{
    int[] freeArr = new int[size];
    for (int i = 0; i < size; i++) freeArr[i] = new Random().Next(-2147483645, 2147483645);
    return freeArr;
}

void InputArray(int[] size)
{
    Console.WriteLine("Formed array numbers ");
    for (int i = 0; i < size.Length; i++)
        Console.Write(size[i] + ", ");
    Console.WriteLine();
}

int[] array = FreeArray(new Random().Next(1, 1234));
InputArray(array);

