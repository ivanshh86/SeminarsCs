// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.



int[,] ExchRowsCols (int[,] arrToChange)
{
    int[,] tempArr = new int[arrToChange.GetLength(0), arrToChange.GetLength(1)];
    if (arrToChange.GetLength(0) == arrToChange.GetLength(1))
    {
        for (int i = 0; i < arrToChange.GetLength(0); i++)
        {
            for (int j = 0; j < arrToChange.GetLength(1); j++)
            {
                tempArr[j, i] = arrToChange[i, j];
            }
        }
        return tempArr;
    }
    else
    {
        Console.WriteLine("Impossible to exchange rows with columns. Array is not square.");
        return arrToChange;
    }
}







