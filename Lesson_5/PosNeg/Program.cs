//Напишите программу замены элементов массива: положительные элементы замените на соответствующие 
//отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] RandomArray()
{
    int size = new Random().Next(4, 10);
    int[] randomArray = new int[size];
for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(-10, 11);
    }
    return randomArray;
}

void PrintArray(int[] arrayPrint)
{
    for (int i = 0; i < arrayPrint.Length; i++)
    {
        Console.Write(arrayPrint[i] + " ");
    }
    Console.WriteLine();
}

int InvertArray(int[] invArray)
{
    for (int i = 0; i < invArray.Length; i++)
        invArray[i] = invArray[i] * (-1); // invArray[i] *= -1;
    return invArray;
}

int[] massiv = RandomArray();
PrintArray(massiv);
int[] invArray = InvertArray(massiv);
PrintArray(invArray);


