// Задача 46: Задайте двумерный массив размером m×n, з
// аполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.WriteLine("Введите кол-во строк");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int [row, columns];
// for(int i=0; i<matrix.GetLength(0); i++)
// {
//     for(int j=0; j<matrix.GetLength(1); j++)
//     {
//         matrix[i,j]= new Random().Next(11);
//         Console.Write(matrix[i,j]+"\t ");
//     }
//     Console.WriteLine();
// }

// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int [,] array = new int [3, 4];
// for(int i=0; i<3; i++)
// {
//     for(int j=0; j<4; j++)
//     {
//         array[i,j]= i + j;
//         Console.Write(array[i,j]+"\t ");
//     }
//     Console.WriteLine();
// }

// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

// int [,] array = new int [6, 7];
// for(int i=0; i<6; i++)
// {
//     for(int j=0; j<7; j++)
//     {
//         array[i,j]= i + j;
//         Console.Write(array[i,j]+"\t ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Новая редакция:");
// for(int i=0; i<6; i++)
// {
//     for(int j=0; j<7; j++)
//     {
//         if(i%2 == 0 && j%2==0)
//         {
//             array[i,j] *= array[i,j]; 
//         }
//         Console.Write(array[i,j]+"\t ");
//     }
//     Console.WriteLine();
// }

// Задача 51:Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.

// int [,] array = new int [3, 4];
// int a = 0;
// for(int i=0; i<3; i++)
// {
//     for(int j=0; j<4; j++)
//     {
//         array[i,j]= i + j;
//         Console.Write(array[i,j]+"\t ");
//         if(i==j)
//         {
//             a+=array[i,j];
//         }
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("__________________");
// Console.WriteLine("Сумма элементов, находящихся на главной диагонали равна"+ " "+a);




//  ДЗ ////////
// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


// float [,] matrix = new float [3,4];
// for(int i=0; i<matrix.GetLength(0); i++)
// {
//     for(int j=0; j<matrix.GetLength(1); j++)
//     {
//         matrix[i,j]= new Random().Next(20);
//         Console.Write(matrix[i,j]+"\t ");
//     }
//     Console.WriteLine();
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// Console.WriteLine("Задайте элемент для поиска");
// int num = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int [3,4];
// for (int i=0; i<3; i++)
// {
//     for (int j=0; j<4; j++)
//     {
//         array[i,j] = new Random().Next(10);
//         Console.Write(array[i,j]+"\t ");
//     }
//     Console.WriteLine();
// }

// for (int i=0; i<3; i++)
// {
//     for (int j=0; j<4; j++)
//     {
//         if(num==array[i,j])
//         {
//             Console.WriteLine(array[i,j]);
            
//         }
//         else
//         {
//             Console.WriteLine("Такого элемента нет в массиве");
//         }
//     }
        
// }


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// int [,] array = new int [3,4];
// int sum = 0;
// float av = 0;

// for (int i=0; i<3; i++)
// {
//     for (int j=0; j<4; j++)
//     {
//         array[i,j] = new Random().Next(10);
//         Console.Write(array[i,j]+"\t ");
//     }
//     Console.WriteLine();
// }
// for (int i=0; i<3; i++)
// {
//     for (int j=0; j<4; j++)
//     {
//       sum = sum+array[i,j];
//       av = sum/3;
//     }
//     Console.Write(av + " ");
// }

