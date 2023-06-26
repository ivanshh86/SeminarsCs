// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0

int[] RandomArray()
{
    int size = new Random().Next(1, 2147);
    int[] randomArray = new int[size];
    for (int i = 0; i < size; i++) randomArray[i] = new Random().Next(-2147483640, 2147483640);
    return randomArray;
}

void PrintArray(int[] printArray)
{
    for (int i = 0; i < printArray.Length; i++) Console.Write(printArray[i] + "  ");
    Console.WriteLine();
}

void SumElemOddPosition(int[] sumArray)
{
    int sumElemOddPos = 0;
    for (int i = 0; i < sumArray.Length; i++) if (i % 2 != 0) sumElemOddPos += sumArray[i];
    Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях = {sumElemOddPos}");
}

int[] array = RandomArray();
PrintArray(array);
SumElemOddPosition(array);
