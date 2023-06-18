// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrom()
{
    Console.WriteLine("Enter five-digit number ");
    int number = Convert.ToInt32(Console.ReadLine());

    int CheckDigit()
    {
        int digit = 0;
        int num = number;
        while (num != 0)
        {
            num /= 10;
            digit++;
        }
        return digit;
    }    
    if (CheckDigit() == 5) 
    {
        int num1 = number % 10;
        int num2 = number / 10000;
        int num3 = number / 10 % 10;
        int num4 = number / 1000 % 10;

        if (num1 == num2 && num3 == num4) Console.WriteLine($"Number {number} is palindrom");
        else Console.WriteLine($"Number {number} is not palindrom");
    }
    else Console.WriteLine("Entering number not five-digit!");
}
Palindrom();
