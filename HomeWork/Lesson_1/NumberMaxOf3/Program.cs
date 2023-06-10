Console.WriteLine("Enter fist number ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.WriteLine("Maximum number " + max);

