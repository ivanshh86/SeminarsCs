using Internal;
using System;
// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.


void crat()
{
    Console.Write("Enter first number ");
    int first = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter second ");
    int second = Convert.ToInt32(Console.ReadLine());

    if (second % first == 0)
    
        Console.WriteLine("Второе кратно первому");

        else
            Console.WriteLine("second%first");
        

    }

crat();
