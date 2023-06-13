// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

void crat()
{
    Console.Write("Enter first number ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    if (num1 % 7 == 0 && num1 % 23 == 0)
    {
        Console.WriteLine("Число кратно 7 и 23");
    }
    else
    {
        Console.WriteLine("Число не кратно 7 и 23");
    }
}
crat();
