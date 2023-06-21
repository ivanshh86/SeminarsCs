void NumPowPos(int numA, int numB)
{
    int numAB = 1;
    for (int i = 1; i <= numB; i++) numAB *= numA;
    Console.WriteLine($"{numA} в степени {numB} равно {numAB}");
}

void NumPowNeg(int numA, int numB)
{
    double numAB = 1;
    for (int i = -1; i >= numB; i--) numAB *= numA;
    numAB = Math.Round((1 / numAB), 3);
    Console.WriteLine($"{numA} в степени {numB} равно {numAB}");
}

Console.WriteLine("Введите число возводимое в степень ");
int userA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа ");
int userB = Convert.ToInt32(Console.ReadLine());

if (userB < 0) NumPowNeg(userA, userB);
else if (userB > 0) NumPowPos(userA, userB);
else Console.WriteLine("Любое число в степени 0 равно 1");
