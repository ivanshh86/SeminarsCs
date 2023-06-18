// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubeNumN(int numN)
{
    int current = 1;
    while (current <= numN)
    {
        double cub = Math.Pow(current, 3);
        Console.Write($"{cub:f0}, ");           // флаг fx количество (x) символов после запятой        
        current++;
    }

}

void CubeNumNNeg(int numN)
{
    int current = 1;
    while (current >= numN)
    {
        double cub = Math.Pow(current, 3);
        Console.Write(cub + ", ");
        current--;
    }
    Console.WriteLine("\b\b.");                 // удаление 2-х символов справа
}

Console.WriteLine("Enter number cubed ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0) CubeNumN(number);
else CubeNumNNeg(number);
