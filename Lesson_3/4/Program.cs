
//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.
// A(x1,y1); B(x2,y2)
//
//               ________________________________ 
// double distanceAB = \/ (x2-x1)*(x2-x1)+(y2-y1)*(y2-y1) // квадрат  +   (z2-z1)*(z2-z1)   // куб
// Math.Sqrt(25); // Извлечение квадратного корня

double LongLineAB(int xA, int xB, int yA, int yB)
{
    double longLine = Match.Sqrt((xB - xA)*(xB - xA) + (yB - yA) * (yA - yB);
    longLine = Match.Round(longLine, 2);
    return longLine;
}

Console.WriteLine("Input X of A ");
int xCoordA - Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Y of A ");
int yCoordA - Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input X of B ");
int xCoordB - Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Y of B ");
int yCoordB - Convert.ToInt32(Console.ReadLine());

double dist = LongLineAB(xCoordA, xCoordB, yCoordA, yCoordB);
Console.WriteLine($"Distance between A({xCoordA},{yCoordA}) and B({xCoordB},{yCoordB}) is {dist}");







