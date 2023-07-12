// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Ackerman(m - 1, 1);
    return Ackerman(m - 1, Ackerman(m, n - 1));
}
Console.WriteLine("Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m >= 0 && n >= 0)
{
    int numAckerman = Ackerman(m, n);
    Console.WriteLine($"A({m}, {n}) = {numAckerman}");
}
else Console.WriteLine("Entered one or more numbers - negative!");