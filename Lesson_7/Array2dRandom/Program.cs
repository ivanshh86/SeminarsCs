//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//m = 3, n = 4.

int[,] Create2DArray()
{
    Console.WriteLine("Enter count of rows:");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of collums:");
    int userColls = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter min possitive value:");
    int userMin = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter max possitive value:");
    int userMax = Convert.ToInt32(Console.ReadLine());

    int[,] created2dArray = new int[userRows, userColls];

    for (int i = 0; i < userRows; i++)
    {
        for (int j = 0; j < userColls; j++)
        {
            created2dArray[i, j] = new Random().Next(userMin, userMax + 1);
        }
    }
    return created2dArray;
}

void Print2DArray(int[,] array2d)
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

int[,] new2dArray = Create2DArray();
Print2DArray(new2dArray);



