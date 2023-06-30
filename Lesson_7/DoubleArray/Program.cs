//Задайте двумерный вещественный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.

double[,] Create2DArray()
{
    Console.WriteLine("Enter count of rows:");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of collums:");
    int userColls = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter min possitive value:");
    int userMin = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter max possitive value:");
    int userMax = Convert.ToInt32(Console.ReadLine());

    double[,] created2dArray = new double[userRows, userColls];

    for (int i = 0; i < userRows; i++)
    {
        for (int j = 0; j < userColls; j++)
        {
            created2dArray[i, j] = Math.Round(new Random().Next(userMin, userMax + 1) + new Random().NextDouble(), 2);
        }
    }
    return created2dArray;
}
double[,] ModiArrai(double[,] arrayStart)
{
    for (int i = 0; i < arrayStart.GetLength(0); i++)
        for (int j = 0; j < arrayStart.GetLength(1); j++)
            if (i % 2 == 0 && j % 2 == 0)
                arrayStart[i, j] = Math.Round((arrayStart[i, j] * arrayStart[i, j]), 2);
    return arrayStart;
}

void Print2DArray(double[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] thirdTaskArray = Create2DArray();
Print2DArray(thirdTaskArray);
double[,] modiArray = ModiArrai(thirdTaskArray);
Print2DArray(modiArray);
