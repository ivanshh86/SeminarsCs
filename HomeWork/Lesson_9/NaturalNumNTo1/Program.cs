// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

string NumRange(int n, ref string s)
{
    if (n >= 1)
    {
        NumRange(n - 1, ref s);
        s = (n + " ") + s.ToString();
    }
    if (n == 0) return s;
    return s;
}

Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
string s = "";
Console.WriteLine(NumRange(n, ref s));
