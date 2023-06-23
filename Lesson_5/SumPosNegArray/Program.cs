//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

int[] CreateArray(int size, int minVal, int maxVal)
{
    int[] newArray = new int[size];
    for (int i = 0; i < sixe; i++)
    {
        newArray[i] = new Random().Next(minVal, maxVal + 1);
    }
    return newArray;
}

void ShowArray(int[] arrayToShow)
{
    for (int i = 0; i < arrayToShow.Length; i++)
        Console.WriteLine(arrayToShow[i] + "");
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

}




int sizeArray = 12;
int minArrayVal = -9;
int maxArrayVal = 9;
int[] createdArray = CreateArray(sizeArray, minArrayVal, maxArrayVal);
ShowArray(createdArray);
FindSumNegElem(createdArray);
int positiveSum = FindSumPosElem(createdArray);
// Console.WriteLine($"Sum positive elements {positiveSum}");

Console.WriteLine($"Sum positive elements {FindSumPosElem(createdArray)}");
