//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

int[] CreateArray(int size, int minVal, int maxVal)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++) newArray[i] = new Random().Next(minVal, maxVal + 1);
    return newArray;
}

void ShowArray(int[] arrayToShow)
{
    for (int i = 0; i < arrayToShow.Length; i++) Console.Write(arrayToShow[i] + " ");
    Console.WriteLine();
}

void FindSumNegElem(int[] array)
{
    int sumNegElem = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0) sumNegElem += array[i];
    Console.WriteLine($"Summ negative elements {sumNegElem}");
}

void FindSumPosElem(int[] array)
{
 int sumPosElem = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) sumPosElem += array[i];
    Console.WriteLine($"Summ negative elements {sumPosElem}");
}

int sizeArray = 12;
int minArrayVal = -9;
int maxArrayVal = 9;
int[] createdArray = CreateArray(sizeArray, minArrayVal, maxArrayVal);
ShowArray(createdArray);
FindSumNegElem(createdArray);
FindSumPosElem(createdArray);
// Console.WriteLine($"Sum positive elements {positiveSum}");
//Console.WriteLine($"Sum positive elements {FindSumPosElem(createdArray)}");
