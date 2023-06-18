// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double LenghtSegment (int xA, int yA, int zA, int xB, int yB, int zB)
{
    double lenghtSeg = Math.Sqrt(xB-xA)*(xB-xA)+(yB-yA)*(yB-yA)+(zB-zA)*(zB-zA);
    lenghtSeg = Math.Round(lenghtSeg, 2);
    return lenghtSeg;
}

Console.WriteLine("Enter coordinate x point A");
int coordXA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinate y point A");
int coordYA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinate z point A");
int coordZA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinate x point B");
int coordXB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinate y point B");
int coordYB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinate z point B");
int coordZB = Convert.ToInt32(Console.ReadLine());

double lenght = LenghtSegment(coordXA, coordYA, coordZA, coordXB, coordYB, coordZB);
Console.WriteLine($"Distance beetwin points A ({coordXA}, {coordYA}, {coordZA}) and B ({coordXB}, {coordYB}, {coordZB}) is {lenght}");
