//Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5



int[] RandomArray()
{
    int size = 123; //new Random().Next(4, 10);
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


void CountOfElem(int[] countArray)
{
int count = 0;
for (int i = 0; i < countArray.Length; i++)
{
 if (countArray[i]>=10 && countArray[i]<=99)
 count++;   
}
Console.Write($"-> {count}");
}
int[] randomArray = RandomArray();
PrintArray(randomArray);
CountOfElem(randomArray);
Console.WriteLine();

