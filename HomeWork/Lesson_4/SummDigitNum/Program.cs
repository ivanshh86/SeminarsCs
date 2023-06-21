// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Number(int num)
{    
    int summ = 0;
    while (num != 0)
    {
        summ += num % 10;
        num /= 10;
    }
return summ;
}

Console.WriteLine("Введите число ");
int userN = Convert.ToInt32(Console.ReadLine());
if (userN < 0) userN *= -1;
Number(userN);
Console.WriteLine($"Сумма цифр {userN} равна " + Number(userN));
