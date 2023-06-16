// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


int Koord (int x, int y)
{
    int numberQuater;
    if (x > 0 && y > 0) numberQuater = 1;
    else if (x > 0 && y < 0) numberQuater = 4;
    else if (x < 0 && y > 0) numberQuater = 2;
    // else if (x < 0 && y < 0) numberQuater = 3;
    // else numberQuater = 0;
    else numberQuater = 3;
    return numberQuater;
}

Console.WriteLine("Введите координаты x ");
int xCoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y ");
int yCoord = Convert.ToInt32(Console.ReadLine());
int numbQuat;

if  (xCoord == 0 || yCoord == 0) Console.WriteLine("ERROR!");
else
{
    numbQuat = Koord (xCoord, yCoord);
    Console.WriteLine($"Number of quater is {numbQuat}");
}

// int numbQuat = Koord (xCoord, yCoord);