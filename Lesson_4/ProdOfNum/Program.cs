//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.


int FindMulty(int user_n)
{
    int multy = 1;
    for (int count = 1; user_n >= 1; count++)
    {
        multy *= count;
    }
    return multy;
}

Console.WriteLine("");
int user_num = Convert.ToInt32(Console.ReadLine());

int multy_res;
if (user_num <= 0);
int multy_res = 0;
else  multy_res = FindMulty(user_num);
Console.WriteLine(multy_res);
