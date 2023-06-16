//Напишите программу, которая принимает на вход число (N) и 
//выдаёт ряд квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4.

void SqurePrinter(int numberN)
{
    int current = 1;
    while (current <= numberN)
    {
        double res = Math.Pow(current, 2);
        Console.WriteLine($"{res:f0}, ");
        current++;
    }
    Console.WriteLine("\b\b.");
}

void SqurePrinterNeg(int numberN)
{
    int current = 1;
    while (current >= numberN)
    {
        double res = Math.Pow(current, 2); // (число; степень)
        Console.WriteLine($"{res:f0}, ");
        current--;
    }
    Console.WriteLine("\b\b.");
}

Console.WriteLine("Enter number");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber > 0)
SqurePrinter(userNumber);
else
SqurePrinterNeg(userNumber);




