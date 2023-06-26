//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

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


int[] startArray = RandomArray();
int size = startArray.Length;

int[] MultyArray(int[] startArray)
{
    int[] temp;
    if (startArray.Length % 2 == 0) temp = new int[size / 2];
    else
    {
        temp = new int[size / 2 + 1];
        temp[size / 2] = startArray[size / 2];
    }
    for (int i = 0; i < size/ 2; i++) temp[i] = startArray[i] * startArray[startArray.Length - i - 1];
    return temp;
}

PrintArray(startArray);
int[] multy = MultyArray(startArray);
PrintArray(multy);







