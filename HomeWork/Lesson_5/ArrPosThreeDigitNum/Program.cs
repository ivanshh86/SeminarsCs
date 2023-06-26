// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

int[] RandomArray()
{
    int size = new Random().Next(0, 1000);
    int[] randomArray = new int[size];
    for (int i = 0; i < size; i++) randomArray[i] = new Random().Next(100, 1000);
    return randomArray;
}

void PrintArray(int[] printArray)
{
    for (int i = 0; i < printArray.Length; i++) Console.Write(printArray[i] + "  ");
    Console.WriteLine();
}

void CountEvenNum(int[] quantNumArr)
{
    int count = 0;
    int i = 0;
    for ( ; i < quantNumArr.Length; i++) if (quantNumArr[i] % 2 == 0) count++;
    Console.WriteLine($"Всего чисел в массиве = {i}");
    Console.WriteLine($"Количество четных чисел в массиве = {count}");
}

int[] array = RandomArray();
PrintArray(array);
CountEvenNum(array);
