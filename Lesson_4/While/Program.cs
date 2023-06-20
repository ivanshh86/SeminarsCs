// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 
// void FindSumm(int num_A)
// {
//     int sumOfElem = 0;
// 
//     for (int current = 1; current <= num_A; current++)
//     {
//         sumOfElem += current;
//     }
//     Console.WriteLine($"Summ of elements from 1 to {num_A} is {sumOfElem}");
// }

void FindSumm(int user_num_a)
{
    int summElem = 0;
    int current = 1;

    while (current <= user_num_a)
    {
        summElem += current;
        current++;
    }
    Console.WriteLine($"Summ of elements from 1 to {user_num_a} is {summElem}");
}

Console.WriteLine("Enter number");
int user_num = Convert.ToInt32(Console.ReadLine());

if (user_num > 0)
{
    FindSumm(user_num);
}
else
    Console.WriteLine("Entering number error");
    