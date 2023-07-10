// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] Created2DArray(int rows, int columns, int minVal, int maxVal)
{
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

int[,] ProductTwoMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] productMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < productMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < productMatrix.GetLength(1); j++)
        {
            productMatrix[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                productMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                
            }
        }
    }
    return productMatrix;
}

Console.Write($"Введите количество строк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите количество столбцов матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());
if (rows == columns)
{
Console.Write($"Введите минимальное значение матрицы: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите максимальное значение матрицы: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = Created2DArray(rows, columns, minVal, maxVal);
ShowArray(matrix1);
int[,] matrix2 = Created2DArray(rows, columns, minVal, maxVal);
ShowArray(matrix2);
int[,] prodMatrix = ProductTwoMatrix(matrix1, matrix2);
Console.WriteLine($"Произведение матриц равно:");
ShowArray(prodMatrix);
}
else
Console.WriteLine($"Количество строк и столбцов должно быть равным!");
