//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

void Line()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine("You number is " + num);
    int dec = num % 10;
    int first = num / 100;
    Console.WriteLine($"{first}  {dec}");
}
Line();
