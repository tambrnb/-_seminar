// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] GetArray(int m, int n, int min, int max)
// {
//     int [,] result = new int [m,n];
//     for (int i=0; i<m; i++)
//     {
//         for(int j=0; j<n; j++)
//         {
//             result[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return result;
// }

// void ChangeRows (int [,] matrix)
// {
//     int rowsCount = matrix.GetLength(0)-1;
//     for(int i=0; i<matrix.GetLength(1); i++)
//     {
//         int temp = matrix[0,i];
//         matrix[0,i] = matrix[rowsCount,i];
//         matrix[rowsCount,i] = temp;
//     }
// }

// void PrintArray (int [,] inputArray)
// {
//     for (int i=0; i<inputArray.GetLength(0); i++)
//     {
//         for(int j=0; j<inputArray.GetLength(1); j++)
//         {
//             Console.Write(inputArray[i,j]);
//         }
//         Console.WriteLine();
//     }
    
// }

// int[,] array = GetArray(rows,columns,2,9);
// PrintArray(array);
// Console.WriteLine("____________________");
// ChangeRows(array);
// PrintArray(array);


// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.


// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());

// if(columns!=rows)
// {
//     Console.WriteLine("В данной матрице нельзя заменить");
//     return;
// }

// int [,] GetArray(int m, int n, int min, int max)
// {
//     int [,] result = new int [m,n];
//     for (int i=0; i<m; i++)
//     {
//         for(int j=0; j<n; j++)
//         {
//             result[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return result;
// }

// void PrintArray (int [,] inputArray)
// {
//     for (int i=0; i<inputArray.GetLength(0); i++)
//     {
//         for(int j=0; j<inputArray.GetLength(1); j++)
//         {
//             Console.Write(inputArray[i,j]);
//         }
//         Console.WriteLine();
//     }
    
// }

// int[,] ChangeArray(int[,] array)
// {   
//     int[,] result = new int [array.GetLength(0), array.GetLength(1)];

//     for( int i=0; i<array.GetLength(0); i++)
//     {
//         for (int j=0; j<array.GetLength(1); j++)
//         {
//             result[i,j] = array[j,i];
//         }
//         Console.WriteLine();
//     }
//     return result;
// }



// int[,] array2 = GetArray(rows,columns,2,9);
// PrintArray(array2);
// Console.WriteLine("____________________");
// PrintArray(ChangeArray(array2));


// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7


// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());

// int minValue = int.MaxValue;
// int minIndexRows = 0;
// int minIndexCol = 0;
// int [,] GetArray(int m, int n, int min, int max)
// {
//     int [,] result = new int [m,n];
//     for (int i=0; i<m; i++)
//     {
//         for(int j=0; j<n; j++)
//         {
//             result[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return result;
// }

// void PrintArray (int [,] inputArray)
// {
//     for (int i=0; i<inputArray.GetLength(0); i++)
//     {
//         for(int j=0; j<inputArray.GetLength(1); j++)
//         {
//             Console.Write(inputArray[i,j]);
//             if(minValue>inputArray[i,j])
//             {
//                 minValue=inputArray[i,j];
//                 minIndexRows=i;
//                 minIndexCol=j;
//             }
//         } 
//         Console.WriteLine();
//     }
    
// }

// int[,] ChangeArray(int[,] array)
// { 
//     for( int i=0; i<array.GetLength(0); i++)
//     {
//         if(i!=minIndexRows)
//         {
//             for (int j=0; j<array.GetLength(1); j++)
//             {
//                 if(j!=minIndexCol)
//                 {
//                     Console.Write(array[i,j]);  
//                 }
                
//             }
//         }
//         Console.WriteLine();
//     }
//     return array;
// }


// int[,] array2 = GetArray(rows,columns,2,9);
// PrintArray(array2);
// Console.WriteLine("____________________");
// PrintArray(ChangeArray(array2));




/////////////////////////// Домашняя работа////////////////////////////



// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] GetArray(int m, int n, int min, int max)
// {
//     int [,] result = new int [m,n];
//     for (int i=0; i<m; i++)
//     {
//         for(int j=0; j<n; j++)
//         {
//             result[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return result;
// }

// void PrintArray (int [,] inputArray)
// {
//     for (int i=0; i<inputArray.GetLength(0); i++)
//     {
//         for(int j=0; j<inputArray.GetLength(1); j++)
//         {
//             Console.Write(inputArray[i,j]);
//         }
//         Console.WriteLine();
//     }
    
// }

// void FindMax(int[,] change)
// { 
//     for( int i=0; i<change.GetLength(0)-1; i++)
//     {
//         for (int j = 0; j <change.GetLength(1); j++)
//         {
//             int max= 0;
//             if(max < change[i,j])
//             {
//                 max = change[i,j];
//                 change[i,j] = max;
//             }
//         }
             
//     }
// }

// int[,] array = GetArray(rows,columns,2,9);
// PrintArray(array);
// Console.WriteLine("____________________");
// FindMax(array);
// PrintArray(array);


// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой 
// строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.WriteLine("Введите число");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int n= Convert.ToInt32(Console.ReadLine());
// int [,] array = new int [m,n]; 
// int sum = 0;
// for(int i=0; i<m; i++)
// {
//     for(int j=0; j<4; j++)
//     { 
//         array[i,j]= new Random().Next(10);
//         Console.Write(array[i,j]);
//     }
//     Console.WriteLine();
// }
// for(int i=0; i<m; i++)
// {
//     for(int j=0; j<n; j++)
//     {
//         sum = sum + array[i,j];
//     }
//     Console.WriteLine(sum);
// }




// Задача 60. ...Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
