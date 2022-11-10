// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int SumNum(int number)
// {
//     int sum = 0;
//     int count = 0;
//     while (number>count)
//     {
//         count++;
//         sum += count;
//     }
//     return sum;
// }
// Console.WriteLine("Суммма равна"+ SumNum(num));


// Задача 26: Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());
// int F(int num)
// {
//     int count = 0;
//     while(num>0)
//     {
//         count++;
//         num /= 10;
//     }
//     return count;
// }
// Console.WriteLine("Количество цифр"+" "+ F(num));


// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int [] array = GetArray(8);
// int []GetArray(int size)
// {
//     int [] array = new int [size];
//     for (int i=0; i<size; i++)
//     {
//         array[i] = new Random().Next(0,2);

//     }
//     return array;
// }
// Console.WriteLine(String.Join(",",array));

// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// int Getnum(int number)
// {
//     int result = 1;
//     for(int i=2;i<=number;i++)
//     {
//         result*=i;
//     }
//     return result;
// }
// Console.WriteLine("Произведение чисел равно"+" "+ Getnum(num));



// Домашнее задание//

// Задача 25 Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.WriteLine("Введите число");
// int num1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2 = int.Parse(Console.ReadLine());

// Console.WriteLine(Convert.ToInt32(Math.Pow(num1, num2)));


// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());
// int Func(int num)
// {
//     int result = 0;
//     while(num>0)
//     {
//         result += num%10;
//         num /= 10;
//     }
//     return result;
// }
// Console.WriteLine(Func(num));


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int [] array = GetArray(5);
int [] array1 = GetArray1(3);
int []GetArray(int size)
{
    int [] array = new int [size];
    for (int i=0; i<size; i++)
    {
        array[i] = new Random().Next(0,100);

    }
    return array;
}
int []GetArray1(int size)
{
    int [] array1 = new int [size];
    for (int i=0; i<size; i++)
    {
        array1[i] = new Random().Next(0,100);

    }
    return array1;
}
Console.WriteLine(String.Join(",", array));
Console.WriteLine(String.Join(",", array1));
