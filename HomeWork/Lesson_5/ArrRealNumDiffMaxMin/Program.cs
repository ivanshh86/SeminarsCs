// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] RandomArray()
{
    int size = new Random().Next(1, 2147);
    double[] randomArray = new double[size];
    for (int i = 0; i < size; i++) randomArray[i] = Math.Round(new Random().Next(-2147483640, 2147483640) + new Random().NextDouble(), 2);
    return randomArray;
}

void PrintArray(double[] printArray)
{
    for (int i = 0; i < printArray.Length; i++) Console.Write($"{printArray[i]}   ");
    Console.WriteLine("");
}

void DiffMaxMinElement(double[] difMaxMinArray)
{
    double max = difMaxMinArray[0];
    double min = difMaxMinArray[0];
    for (int i = 0; i < difMaxMinArray.Length; i++)
    {
        if (difMaxMinArray[i] > max) max = difMaxMinArray[i];
        if (difMaxMinArray[i] < min) min = difMaxMinArray[i];
    }
    Console.WriteLine($"Максимальный элемент массива = {max}");
    Console.WriteLine($"Минимальный элемент массива = {min}");
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {Math.Round(max - min, 2)}");
}

double[] aray = RandomArray();
PrintArray(aray);
DiffMaxMinElement(aray);
