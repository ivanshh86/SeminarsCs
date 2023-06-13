// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void Line()
{
    int num = new Random().Next(0, 100000);
    Console.WriteLine("You number is " + num);
    int threeDig = 0;

    int i = num;
    int dig = 0;
    for (; i != 0; dig++)
    {
        i = i / 10;
    }
    //      Console.WriteLine("Digits of number = " + dig);

    if (dig == 1 || dig == 2 || dig == 0)
    {
        Console.WriteLine("No third digit!");
    }
    if (dig == 3)
    {
        threeDig = num % 10;
        Console.WriteLine("Third digit in number " + threeDig);
    }
    if (dig == 4)
    {
        int temp = num / 10;
        threeDig = temp % 10;
        Console.WriteLine("Third digit in number " + threeDig);
    }
    if (dig == 5)
    {
        int temp = num / 100;
        threeDig = temp % 10;
        Console.WriteLine("Third digit in number " + threeDig);
    }
}
Line();

