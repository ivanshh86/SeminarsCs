// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void Line()
{
    int num = new Random().Next(-2147483000, 2147483000);
    Console.WriteLine("You number is " + num);

    if (num < 0) num *= -1;

    int i = num;
    int dig = 0;

    while (i != 0)
    {
        i /= 10;
        dig++;
    }

    if (dig = 1 || dig = 2) Console.WriteLine("No third digit!");

    while (dig != 3)
    {
        num /= 10;
        dig --;
    }
    num %= 10;
    Console.WriteLine("Thirt digit in number " + num);
}
Line();

