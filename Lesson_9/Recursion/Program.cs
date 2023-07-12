// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// void ShowNumbers(int n)
// {
//     if (n > 1) ShowNumbers(n - 1);
//     Console.Write(n + " ");
// }
// ShowNumbers(5);





// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// void ShowNumbers(int m, int n)
// {
//     if (n > m) ShowNumbers(m, n - 1);
//     Console.Write($"{n} ");
// }
// ShowNumbers(4, 8);
// Console.WriteLine();



// void ShowNumRange(int n, int m)
// {
//     // if(Math.Max(n,m) != Math.Min(n,m)) ShowNumRange(Math.Min(n,m), Math.Max(n,m)-1);
//     if(n!=m) ShowNumRange(Math.Min(n, m), Math.Max(n, m)-1);
//     Console.Write($"{Math.Max(n,m)} ");
// }
// ShowNumRange(10,20);





// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// int SumDigits(int n)
// {
//     if (n < 0) n *= (-1);
//     if (n == 0) return 0;
//     return SumDigits(n / 10) + n % 10;
// }
// Console.WriteLine("Enter num");
// int n = Convert.ToInt32(Console.ReadLine());
// int summ = SumDigits(n);
// Console.WriteLine($"Your sum is {summ}");
// // // Console.WriteLine($"Your sum is {SumDigits(Convert.ToInt32(Console.ReadLine()))}");





// Напишите программу, которая на вход принимает два числа A и B, и возводит число A в целую степень B с помощью рекурсии.

// double FindPow(int a, int b)
// {
//     if (b == 0) return 1.0;
//     if (b > 0) return FindPow(a, b - 1) * a;
//     return FindPow(a, b + 1) / a;
// }
// double res= FindPow(5, 3);
// Console.WriteLine($"{res} ");





// Напишите программу, которая на вход принимает целое десятичное положительное число, а на выходе переводит его в бинарный формат.

// string DecToBin(int n, ref string s)
// {
//     if (n > 0)
//     {
//         DecToBin(n / 2, ref s);
//         s += (n % 2).ToString("");
//     }
//     if (n == 0) return s;
//     return s;
// }

// Console.WriteLine("Enter num");
// int n = Convert.ToInt32(Console.ReadLine());
// string s = "";
// string summ = DecToBin(n, ref s);
// Console.WriteLine(summ);

