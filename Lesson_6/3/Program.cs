//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b (пользователь).

void Fibonachi(int n, int a, int b)
{
    int[] arrFib = new int[n];

    for (int i = 2; i < n; i++)
    {
        arrFib[i] = arrFib[i - 1] + arrFib[i - 2];
    }
    PrintArray(arrFib);
}

void PrintArray(int[] printArray)
{
    for (int i = 0; i < printArray.Length; i++)
    {
        Console.Write(printArray[i]);
        if (i != printArray.Length - 1) Console.Write(", ");
        else Console.WriteLine(".");
    }
    Console.WriteLine();
}


Console.WriteLine("Enter count");
int userCount = Convert.ToInt32(Console.ReadLine());

if (userCount >2)
{
Console.WriteLine("Enter 1");
int userFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2");
int userSecond = Convert.ToInt32(Console.ReadLine());

Fibonachi(userCount, userFirst, userSecond);
}
else Console.WriteLine("Impossible");





