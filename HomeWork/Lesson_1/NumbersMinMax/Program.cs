Console.WriteLine("Enter first number  ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number  ");
int b = Convert.ToInt32(Console.ReadLine());

int max, min;

if (a > b) 
{
    max = a;
    min = b;
}
    else
{   
    max = b;
    min = a;
}
Console.WriteLine("Maximum number " + max);
Console.WriteLine("Minimum number " + min);

if (a == b)
{
Console.Write("Entered numbers equal " + max);
Console.WriteLine(" = " + min);
}