// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

void Crat(int num1, int num2)
{
    if (num1 == num2 * num2 || num2 == num1 * num1)
    {
        Console.WriteLine("Ok");
    }
    else
    {
        Console.WriteLine("No");
    }
}

Console.WriteLine("Enter first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number ");
int num2 = Convert.ToInt32(Console.ReadLine());

Crat(num1, num2);
