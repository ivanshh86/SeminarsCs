// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void DigitTwo()
{
    Console.WriteLine("Enter number ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num > 99 && num < 1000 || num < -99 && num > -1000)
    {
        num = num / 10;
        num = num % 10;
        if (num < 0)
        {
            num = num * -1;
        }
        Console.WriteLine("Second digit of number " + num);
    }
    else
    {
        Console.WriteLine("Number is not three digits!");
    }
}
DigitTwo();
