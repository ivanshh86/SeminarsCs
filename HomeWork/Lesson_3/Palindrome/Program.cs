// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.



void Polindrom()
{
    Console.WriteLine("Enter five-digit number ");
    int number = Convert.ToInt32(Console.ReadLine());

    int CheckDigit()
    {
        int digit = 0;
        int num = number;
        while (num !=0)
        {
            num /= 10;
            digit++;
        }
        return digit;
    }









}