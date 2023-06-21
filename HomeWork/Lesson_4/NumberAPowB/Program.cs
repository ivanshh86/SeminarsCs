// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void NumPowPos(long numA, long numB)
{
    long numAB = 1;
    for (long i = 1; i <= numB; i++) numAB *= numA;
    Console.WriteLine($"{numA} в степени {numB} равно {numAB}");
}

void NumPowNeg(long numA, long numB)
{
    double numAB = 1;
    for (long i = -1; i >= numB; i--) numAB *= numA;
    numAB = Math.Round((1 / numAB), 5);
    Console.WriteLine($"{numA} в степени {numB} равно {numAB}.");
}

Console.WriteLine("Введите число возводимое в степень ");
long userA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа ");
long userB = Convert.ToInt32(Console.ReadLine());

if (userB <= -1) NumPowNeg(userA, userB);
else if (userB >= 1) NumPowPos(userA, userB);
else Console.WriteLine("Любое число в степени 0 равно 1");
