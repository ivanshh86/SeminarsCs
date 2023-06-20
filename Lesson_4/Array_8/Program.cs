//Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.


int[] CreateNewArray(int size_array)
{
    int[] random1array = new int[size_array];
    for (int i = 0; i < size_array; i++)
    {
        random1array[i] = new Random().Next(0, 2);
    }
    return random1array;
}

void PrintArray(int[] array_to_print)
{
    Console.WriteLine("You array ");
    for (int i = 0; i<array_to_print.Length; i++)
        Console.Write(array_to_print[i] + " ");
        Console.WriteLine();
}



int size = 8;
int[] firstArray = CreateNewArray(size);
PrintArray(firstArray);


