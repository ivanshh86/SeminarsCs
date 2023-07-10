// Напишите программу, которая заполнит спирально массив 4 на 4.


int[,] FillSpiral2DArray()
{
    int size = 4;
    Console.Write($"Введите стартовое значение массива: ");
    int startVal = Convert.ToInt32(Console.ReadLine());
    int startRow = 0;
    int startCol = 0;
    int endRow = size - 1;
    int endCol = size - 1;
    int[,] fill2dArray = new int[size, size];

    while (startRow <= endRow && startCol <= endCol)
    {
        for (int i = startCol; i <= endCol; i++)
        {
            fill2dArray[startRow, i] = startVal;
            startVal++;
        }
        startRow++;

        for (int i = startRow; i <= endRow; i++)
        {
            fill2dArray[i, endRow] = startVal;
            startVal++;
        }
        endCol--;

        for (int i = endCol; i >= startCol; i--)
        {
            fill2dArray[endRow, i] = startVal;
            startVal++;
        }
        endRow--;

        for (int i = endRow; i >= startRow; i--)
        {
            fill2dArray[i, startCol] = startVal;
            startVal++;
        }
        startCol++;
    }
    return fill2dArray;
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

int[,] spiralArray = FillSpiral2DArray();
ShowArray(spiralArray);
