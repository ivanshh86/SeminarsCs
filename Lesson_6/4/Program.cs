//Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.
// каждая сторона треугольника меньше суммы двух других сторон.
// a<b+c; b<a+c; c<a+b

 void PrintArray(int[] printArray)
{
    for (int i = 0; i < printArray.Length; i++)
    {
        Console.Write(printArray[i]);
        if (i != printArray.Length - 1) Console.Write(", ");
        else Console.WriteLine(".");
    }
    Console.WriteLine();
}

void Triangle(int firstSide, int secondSide, int thirdSide)
{
    int[] sides = { firstSide, secondSide, thirdSide };
    if (sides[0] < sides[1] + sides[2] && sides[1] < sides[0] + sides[2] && sides[2] < sides[1] + sides[0]) Console.WriteLine($"Triangle trye");
    else
        Console.WriteLine($"Triangle false");
}

Triangle(3,4,5);
