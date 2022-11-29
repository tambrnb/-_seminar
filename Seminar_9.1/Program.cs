﻿// Задача 63: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// string PrintNumber(int start, int end)
// {
//     if(end==start)
//     {
//         return end.ToString();
//     }
//     return (start+ ", " + PrintNumber(start +1, end));
// }

// Console.WriteLine(PrintNumber(1,n));


// Задача 65: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в 
// промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// Console.WriteLine("Введите число");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// string PrintNumber(int start, int end)
// {
//     if(end<start)
//     {
//         return "Введите корректные числа";
//     }
//     if(end==start)
//     {
//         return start.ToString();
//     }
//     return (start+ ", " + PrintNumber(start +1, end));
// }

// Console.WriteLine(PrintNumber(m,n));


// Задача 67: Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());

// int SumNubers(int num)
// {
//     if (num==0)
//     {
//         return 0;
//     }
//     return(num%10+SumNubers(num/10));
// }
// Console.WriteLine(SumNubers(n));


// адача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// Console.WriteLine("Введите число");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int B = Convert.ToInt32(Console.ReadLine());

// int Pow(int n1, int n2)
// {
//     if(n2==0)
//     {
//         return 1;
//     }
//     if(n2==1)
//     {
//         return n1;
//     }
//     return (n1*Pow(n1, n2-1));
// }
// Console.WriteLine(Pow(A,B));



// ////////// ////////   ДОМАШНЯЯ РАБОТА   /////////////////

// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());

// string PrintNumber(int end, int start)
// {
//     if(end==start)
//     {
//         return end.ToString();
//     }
//     return (end+ ", " + PrintNumber(end -1, start));
// }

// Console.WriteLine(PrintNumber(N, 1));

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите число");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int start, int end)
// {
//     if (end==start)
//     {
//         return end+start;
//     }
//     return start +SumNumbers(start+1, end);
// }
// Console.WriteLine(SumNumbers(M,N));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29