//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int[] NumberArray(int number)
{
    string num = number.ToString();
    int[] numbers = new int[number.ToString().Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToInt32(number.ToString().Substring(i, 1));
    }
    return numbers;
}

void PrintArray (int[] numPrint)
{
Console.WriteLine("array ");
for (int i = 0; i < numPrint.Length; i++)
Console.Write(numPrint[i] + ", ");

}


Console.WriteLine("Введите число ");
int userN = Convert.ToInt32(Console.ReadLine());
int[] userArray = NumberArray(userN);
PrintArray(userArray);




