// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.

double[,] CreateArray2DRealNum(int)
{
    double[,] array2dReal = new double[3, 4];
    for (int i = 0; i < 3; i++)
        for (int j = 0; j < 4; j++)
            array2dReal[i, j] = Math.Round(new Random().Next() + new Random().NextDouble(), 2);
    return array2dReal;
}

void PrintArray(double[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + " ");
        }
    Console.WriteLine();
    }
}

double[,] array2dRealNum = CreateArray2DRealNum();
PrintArray(array2dRealNum);
