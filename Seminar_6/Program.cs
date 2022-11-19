// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Console.WriteLine("Размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Максимальный элемент: ");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Минимальный элемент: ");
// int min = Convert.ToInt32(Console.ReadLine());

// int [] array = GetArray(size, max, min);
// Console.WriteLine(String.Join(",", array));

// ChangeArray(array);
// Console.WriteLine(String.Join(",", array));

// int [] GetArray(int size, int max, int min)
// {
//     int []res= new int [size];
//     for(int i=0; i<size; i++)
//     {
//         res[i] = new Random().Next(min, max+1);
//     }
//     return res;
// }

// void ChangeArray(int[]array)
// {
//     for (int i=0; i<array.Length/2; i++)
//     {
//         int k=array[i];
//         array[i]= array[array.Length-1-i];
//         array[array.Length-1-i]=k;
//     }
// }

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

// Console.WriteLine("Введите три числа");

// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());

// if((num1<num2+num3) && (num2<num1+num3) && (num3<num1+num2))
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.WriteLine("Введите десятичное число ");
// int num = Convert.ToInt32(Console.ReadLine());
// string bin = "";
// while(num>0)
// {
//     bin=num%2+bin;
//     num/=2;
// }
// Console.Write(bin);

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 84

// Console.WriteLine("Введите количество чисел");
// int size = Convert.ToInt32(Console.ReadLine());

// int num1 = 0;
// int num2 = 1;
// Console.WriteLine(1+"|"+num1);
// Console.WriteLine(2+"|"+num2);

// for(int i=0; i<size; i++)
// {
//     int NextNum = num1+num2;
//     Console.WriteLine(i+"|"+NextNum);
//     num1 = num2;
//     num2 = NextNum;
// }

// Задача 45: Напишите программу, которая будет создавать 
// копию заданного массива с помощью 
// поэлементного копирования

// Console.WriteLine("Введите размер ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = GetArray(size);

// Console.WriteLine(String.Join(",", array));

// int[] copyarray = CopyArray(array);

// Console.WriteLine(String.Join(",", array));

// int [] GetArray(int size)
// {
//     int[] array1 = new int [size];
//     for(int i=0; i<size; i++)
//     {
//         array1[i]= new Random().Next(100);
//     }
//     return array1;
// }

// int [] CopyArray(int[] array)
// {
//      int[] result = new int [array.Length];
//      for(int i=0; i<array.Length; i++)
//      {
//         result[i]=array[i];
//      }
//      return result;
// }

// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Console.WriteLine("Введите количетсво цифр");
// int M = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// int [] array = new int [M];
// for(int i=0; i<M; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
//     if(array[i]>0)
//     {
//         count++;
//     }
// }   Console.WriteLine(String.Join(",", array));
// Console.WriteLine("Количество положительных чисел равно" + " "+ count);


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("уравнение y=kx+b");
Console.WriteLine("Введите b1");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k1");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b2");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k2");
double k2 = Convert.ToInt32(Console.ReadLine());

if (k1==k2)
{
    Console.WriteLine("Линии параллельны");
}
else 
{
    double x = (b2-b1)/(k2-k1);
    double y = k2*x+b1;
    Console.WriteLine("Точка пересечения равна"+ " "+"("+ x+ ";"+ y+")");
}


