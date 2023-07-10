//Задайте двумерный массив. Напишите программу, которая поменяет местами две любые строки массива.

int[,] Created2dArray(int rows, int columns, int minV, int maxV)
{
    int[,] createdArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            createdArray[i, j] = new Random().Next(minV, maxV + 1);
    return createdArray;
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

int[,] ChangeRows(int[,] arrayToChange, int row1, int row2)
{
    if (row1 >= 0 &&
        row1 < arrayToChange.GetLength(0) &&
        row1 != row2 &&
        row2 >= 0 &&
        row2 < arrayToChange.GetLength(0))
    {
        for (int j = 0; j < arrayToChange.GetLength(1); j++)
        {
            int temp = arrayToChange[row1, j];
            arrayToChange[row1, j] = arrayToChange[row2, j];
            arrayToChange[row2, j] = temp;
        }
    }
    else Console.WriteLine("Error!");
return arrayToChange;
}

Console.Write("Enter count of rows: ");
int user_rows=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter count of collumns: ");
int user_collumns=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min val: ");
int user_min=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max val: ");
int user_max=Convert.ToInt32(Console.ReadLine());

int[,] newArr=Created2dArray(user_rows, user_collumns, user_min, user_max);
ShowArray(newArr);

Console.WriteLine($"Enter nember first row to remove from 0 to {user_rows-1}: ");
int user_first_row= Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Enter nember second row to remove from 0 to {user_rows-1}: ");
int user_second_row= Convert.ToInt32(Console.ReadLine());

ShowArray(ChangeRows(newArr, user_first_row, user_second_row));
