// ЗАДАЧА №1

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// int num = new Random().Next(10, 100); 
// int num1 = num/10;
// int num2 = num%10;

// Console.WriteLine(num);

// int max = num1;
// if (max<num2)
// {
//     max=num2;
// }
// Console.WriteLine("Максимальное число" + " " + max);


// Задача №2

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int num = new Random().Next(100, 1000);
// int num1 = (num/100)*10+num%10;
// Console.WriteLine(num);
// Console.WriteLine(num1);

// Задача №3
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.WriteLine("Введите число"); 
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число"); 
// int num2 = int.Parse(Console.ReadLine());

// if(num1%num2 == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine("Не кратно");
// }

//  Задача №4

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// Console.WriteLine("Введите число"); 
// int num1 = Convert.ToInt32(Console.ReadLine());

// if((num1%7 == 0)&&(num1%23 == 0))
// {
//     Console.WriteLine("Кратно");
// }
// else{
//     Console.WriteLine("Не кратно");
// }

// Задача №5

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

// int num1 = new Random().Next(2, 76);
// int num2 = new Random().Next(2, 76);

// Console.WriteLine(num1);
// Console.WriteLine(num2);

// if(num2 == num1*num1)
// {
//     Console.WriteLine("Да");
// }
// else{
//     Console.WriteLine("Нет");
// }

//////// Домашка

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.WriteLine("Введите число от 100 до 1000"); 
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = num/10;
// int num2 = num1%10;

// Console.WriteLine("Вторая цифра числа это" + " " + num2);


// /////////////////
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Console.WriteLine("Введите цифру"); 
// // int num = int.Parse(Console.ReadLine());
// // if(num<100)
// // {
// //     Console.WriteLine("Третьей цифры нет");
// // }
// // int num2 = (num/100)%10;
// // Console.WriteLine(num2);
// // ИЛИ//
// string num = Console.ReadLine();
// Console.WriteLine(num[2]);

///////////////////////////////////////
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите цифру дня недели"); 
// int num = Convert.ToInt32(Console.ReadLine());
// if(num>7)
// {
//     Console.WriteLine("Ошибка");
// }
// if(num == 6 || num == 7)
// {
//     Console.WriteLine("Да");
// }
// if(num==1||num==2||num==3||num==4||num==5)
// {
//     Console.WriteLine("Нет");
// }
