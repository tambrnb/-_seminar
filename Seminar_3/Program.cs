// 17. Напишите программу, 
// которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// // в которой находится эта точка.

// Console.WriteLine("Введите число");
// int x = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число");
// int y = int.Parse(Console.ReadLine());

// if(x>0&&y>0)
// {
//     Console.WriteLine("1");
// }
// if(x>0&&y<0)
// {
//   Console.WriteLine("4");  
// }
// if(x<0&&y>0)
// {
//     Console.WriteLine("2");
// }
// if(x<0&&y<0)
// {
//     Console.WriteLine("3");
// }

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Введите число");
// int x1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число");
// int y1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число");
// int x2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число");
// int y2 = int.Parse(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));

// Console.WriteLine(d);

// ///////////////////
// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
// Console.WriteLine("Введите число");
// int  num = int.Parse(Console.ReadLine());

// if(num==1)
// {
// Console.WriteLine("x>0, y>0");
// }

// if(num==2)
// {
// Console.WriteLine("x<0, y>0");
// }

// if(num==3)
// {
// Console.WriteLine("x<0, y<0");
// }

// if(num==4)
// {
// Console.WriteLine("x>0, y<0");
// }


////////////////////////////////
// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("Введите число");
// int  N = int.Parse(Console.ReadLine());
// for(int i = 1; i<=N;i++)
// {
//     int PW = i*i;
//     Console.WriteLine(PW);
// }

// //////////////
// Домашняя работа/////////
// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите значение x1");
// int x1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите значение y1");
// int y1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите значение c1");
// int c1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите значение x2");
// int x2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите значение y2");
// int y2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите значение c2");
// int c2 = int.Parse(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(c1-c2,2));

// Console.WriteLine(d);

///////////////////////////////////
// Задача 23

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число");
// int N = int.Parse(Console.ReadLine());

// for(int i =1; i<=N; i++)
// {
//     Console.WriteLine(Math.Pow(i,3));
// }