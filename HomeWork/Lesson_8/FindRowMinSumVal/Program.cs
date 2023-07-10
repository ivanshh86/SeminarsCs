// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
            create2dArray[i, j] = new Random().Next(minVal, maxVal + 1);
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

void MinSumRow2DArray(int[,] array)
{
    int numRow = 0;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Сумма элементов {i + 1} строки равна: {sum}");
        if (i == 0) minSum = sum;
        else if (sum < minSum)
        {
            minSum = sum;
            numRow = i;
        }
    }
    Console.WriteLine($"Наименьшую сумму элементов: {minSum}, содержит строка: {numRow + 1}");
}

int[,] newArray = Created2DArray();
ShowArray(newArray);
MinSumRow2DArray(newArray);
