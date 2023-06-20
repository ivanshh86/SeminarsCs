//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int Numbers (int num_user)
{
    int count = 1;
    while (num_user < 10)
    {
        num_user /= 10;
        count++;
    }
    return count;
}

Console.WriteLine ("Enter number");
int user_num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Numbers(user_num));

int count;
count = Numbers(user_num);

)
//
//if (user_num >= 0) count = Numbers(user_num);
//else 
//{
//int user_num1 = (-1) * user_num;
//count = Numbers(user_num1);
//}
Console.WriteLine (count);