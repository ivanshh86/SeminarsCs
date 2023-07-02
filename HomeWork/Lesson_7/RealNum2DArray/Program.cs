// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateArray2DRealNum()
{
    Console.Write("Введите минимальное значение массива: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение массива: ");
    int max = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество строк массива: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество стлбцов массива: ");
    int column = Convert.ToInt32(Console.ReadLine());
    double[,] array2dReal = new double[row, column];
    for (int i = 0; i < array2dReal.GetLength(0); i++)
        for (int j = 0; j < array2dReal.GetLength(1); j++)
            array2dReal[i, j] = Math.Round(new Random().Next(min, max) + new Random().NextDouble(), 2);
    return array2dReal;
}

void PrintArray(double[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j]);
            if (i == array2d.GetLength(0) - 1 && j == array2d.GetLength(1) - 1) Console.WriteLine(".");
            else if
            (j == array2d.GetLength(1) - 1) Console.WriteLine(";");
            else
                Console.Write(", ");
        }
    }
}

double[,] array2dRealNum = CreateArray2DRealNum();
PrintArray(array2dRealNum);
