// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateArray2D(int minVal, int maxVal)
{
    int row = new Random().Next(5, 25);
    int column = new Random().Next(5, 25);

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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            if (i == array.GetLength(0) - 1 && j == array.GetLength(1) - 1) Console.WriteLine(".");
            else if
            (j == array.GetLength(1) - 1) Console.WriteLine(";");
            else
                Console.Write(", ");
        }
    }
}

void FindElement(int[,] arrayFind, int findPosition)
{
    int i = findPosition / 10;
    int j = findPosition % 10;
    if (i >= arrayFind.GetLength(0) || j >= arrayFind.GetLength(1))
        Console.WriteLine($"Элемента с координатами ({i} {j}) несуществует");
    else
        Console.WriteLine($"Элемент с координатами ({i} {j}) равен: {arrayFind[i, j]}");
}

Console.Write("Ведите минимальное значение массива: ");
int minValueArr = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите максимальное значение массива: ");
int maxValueArr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите координаты искомого элемента в формате (xy): ");
int findPosition = Convert.ToInt32(Console.ReadLine());
if (findPosition < 0 || findPosition > 99)
{
    Console.WriteLine("Ошибка!");
    Console.WriteLine("Введите координаты искомого элемента в формате двузначного числа (xy)");
}
else
{
    int[,] array2D = CreateArray2D(minValueArr, maxValueArr);
    PrintArray(array2D);
    FindElement(array2D, findPosition);
}