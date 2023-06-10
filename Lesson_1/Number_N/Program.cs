Console.WriteLine("Enter number N: ");
 int N = Convert.ToInt32(Console.ReadLine());
 int count = N * (-1);
 while (count <= N)
{
Console.WriteLine(count + ", ");
count = count + 1; // count +=1; count ++
}