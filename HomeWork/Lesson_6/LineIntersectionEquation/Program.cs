// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
double[] CoordinatArray1(double b1, double k1, double b2, double k2)
{
    double x = Math.Round((b2 - b1) / (k1 - k2), 2);
    double y = Math.Round(k1 * x + b1, 2);
    double[] coordArray = { x, y };
    return coordArray;
}
double[] CoordinatArray2(double b1, double k1, double b2, double k2)
{
    double x = Math.Round((b2 - b1) / (k1 - k2), 2);
    double y = Math.Round(k2 * x + b2, 2);
    double[] coordArray = { x, y };
    return coordArray;
}

void PrintArray(double[] array)
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

Console.Write($"Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введены значения: b1={b1}, k1={k1}, b2={b2}, k2={k2}");

double[] coordArr1 = CoordinatArray1(b1, k1, b2, k2);
double[] coordArr2 = CoordinatArray2(b1, k1, b2, k2);
Console.WriteLine($"Точка пересечения прямых:");
PrintArray(coordArr1);
Console.WriteLine($"Проверка расчетов:");
PrintArray(coordArr2);
