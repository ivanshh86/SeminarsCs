// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

int ShowNumbers(int m, int n)
{
    if (m < 0 && n < 0) return 0;
    if (m < 0) return (n + 1) / 2 * n;
    if (n < 0) return (m + 1) / 2 * m;
    if (m == n) return n;
    if (n > m) return n + ShowNumbers(m, n - 1);
    return n + ShowNumbers(m, n + 1);
}

Console.WriteLine("Enter first number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int n = Convert.ToInt32(Console.ReadLine());
int sumNum = ShowNumbers(m, n);
Console.WriteLine($"Sum natural numbers from {m} to {n} : {sumNum}");
