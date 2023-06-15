// Напишите программу, которая принимает на вход цифру, обозначающую день недели 
// и проверяет, является ли этот день выходным.

void Week()
{
Console.WriteLine("Введите номер дня недели ");
int day = Convert.ToInt32(Console.ReadLine());

if (day >= 1 && day <= 5) Console.WriteLine($"{day} - будний день недели"); 

if (day >= 6 && day <= 7) Console.WriteLine($"{day} - выходной день недели");

if (day <= 0 || day >= 8) Console.WriteLine($"{day} - внедиапазона дней недели!");
}
Week();
