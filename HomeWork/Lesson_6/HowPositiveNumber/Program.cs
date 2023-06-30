// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] CreateArray(int size)
{
    int[] numArray = new int[size];
    for (int i = 0; i < size; i++)
        numArray[i] = new Random().Next(-2147483648, 2147483647);
    return numArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i == array.Length - 1) Console.Write(".");
        else Console.Write(", ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

void PrintCountPosNum(int[] array)
{
    int countNum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) countNum++;

    if (countNum >= 11 && countNum <= 19
        || countNum % 10 == 5 || countNum % 10 == 6
        || countNum % 10 == 7 || countNum % 10 == 8
        || countNum % 10 == 9 || countNum % 10 == 0)
        Console.WriteLine($"{countNum} чисел больше нуля.");

    else if (countNum % 10 == 2 || countNum % 10 == 3 || countNum % 10 == 4)
        Console.WriteLine($"{countNum} числа больше нуля.");

    else if (countNum % 10 == 1)
        Console.WriteLine($"{countNum} число больше нуля.");
}

Console.Write("Укажите размер массива: ");
string? sizeNum = Console.ReadLine();
if (sizeNum == "" || sizeNum == " ")
{
    Console.WriteLine($"Введено пустое значение или пробел!");
    Console.WriteLine();
}
else
{
    int sizeArray = Convert.ToInt32(sizeNum);
    if (sizeArray > 0)
    {
        int[] userArray = CreateArray(sizeArray);
        PrintArray(userArray);
        PrintCountPosNum(userArray);
    }
    else if (sizeArray == 0)
    {
        Console.WriteLine($"Введено значение {sizeArray}.");
        Console.WriteLine($"Размер массива не может быть нулевым!");
    }
    else
    {
        Console.WriteLine($"{sizeArray} отрицательное число.");
        Console.WriteLine($"Размер массива не может быть отрицательным!");
    }
}
