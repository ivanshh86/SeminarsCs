//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int[] NumberArray(int number)
{
    string num = number.ToString();
    int[] numbers = new int[num.Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToInt32(num.Substring(i, 1));
    }
    return numbers;
}

int SumNumbers(int[] numPrint)
{
    int sumNum = 0;
    for (int i = 0; i < numPrint.Length; i++)
    {
        sumNum += numPrint[i];
    }
    return sumNum;    
}

Console.WriteLine("Введите число ");
int userN = Convert.ToInt32(Console.ReadLine());
if (userN < 0) userN *= -1;
int[] userArray = NumberArray(userN);
int summ = SumNumbers(userArray);
Console.WriteLine($"Сумма цифр {userN} равна {summ}.");

