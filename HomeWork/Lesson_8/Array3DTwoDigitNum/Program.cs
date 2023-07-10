// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] Created3DArray()
{
    Console.Write($"Введите количество строк массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите количество столбцов массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите глубину массива: ");
    int depth = Convert.ToInt32(Console.ReadLine());

    int numTwoDigit = 10;
    int[,,] create3dArray = new int[rows, columns, depth];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                create3dArray[i, j, k] = numTwoDigit++;
                if (numTwoDigit > 99)
                {
                    numTwoDigit = numTwoDigit / 10;
                }
            }
        }
    }
    return create3dArray;
}

void ShowArray(int[,,] printedArray)
{
    for (int i = 0; i < printedArray.GetLength(0); i++)
    {
        for (int j = 0; j < printedArray.GetLength(1); j++)
        {
            for (int k = 0; k < printedArray.GetLength(2); k++)
            {
                Console.Write($"{printedArray[j, k, i]} ({j},{k},{i})  ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] new3dArray = Created3DArray();
ShowArray(new3dArray);
