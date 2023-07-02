// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] Create2Darray()
{
    Console.WriteLine("Введите минимальное значение массива: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальное значение массива: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    int row = new Random().Next(5, 9);
    int column = new Random().Next(5, 9);
    int[,] array2d = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array2d[i, j] = new Random().Next(minVal, maxVal);
        }
    }
    return array2d;
}

void PrintArray(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j]);
            if (i == array2d.GetLength(0) - 1 && j == array2d.GetLength(1) - 1) Console.WriteLine(".");
            else if (j == array2d.GetLength(1) - 1) Console.WriteLine(";");
            else Console.Write(", ");
        }
    }
}

void AverageColumn(int[,] array2d)
{
    double[] arrayAvg = new double[array2d.GetLength(1)];
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array2d.GetLength(0); i++)
        {
            sum = sum + array2d[i, j];
        }
        for (int k = 0; k < arrayAvg.Length; k++)
        {
            arrayAvg[k] = Math.Round((sum / array2d.GetLength(0)), 2);
        }
        Console.Write(arrayAvg[j] + " ");
    }
    Console.WriteLine("");
}
int[,] array2d = Create2Darray();
PrintArray(array2d);
Console.WriteLine("---------------------------");
AverageColumn(array2d);



