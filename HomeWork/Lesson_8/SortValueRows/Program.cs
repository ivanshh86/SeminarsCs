﻿// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] Created2DArray()
{
    Console.Write($"Введите количество строк массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите количество столбцов массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите минимальное значение массива: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите максимальное значение массива: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] create2dArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            create2dArray[i, j] = new Random().Next(minVal, maxVal+1);
    return create2dArray;
}

void ShowArray(int[,] printedArray)
{
    for (int i = 0; i < printedArray.GetLength(0); i++)
    {
        for (int j = 0; j < printedArray.GetLength(1); j++)
        {
            Console.Write(printedArray[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Sorting2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] > array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
    return array;
}

int[,] newArray = Created2DArray();
ShowArray(newArray);
int[,] sortArr = Sorting2DArray(newArray);
ShowArray(sortArr);
