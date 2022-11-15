// Задача 31: Задайте массив из 12 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. Найдите сумму отрицательных и 
// положительных элементов массива.

// int [] array = new int [12];
// int negNum=0;
// int posNum=0;
// for(int i=0;i<array.Length; i++)
// {
//     array[i]= new Random().Next(-9,10);
//     if(array[i]>0)
//     {
//         posNum=posNum+array[i];
//     }
//     if(array[i]<0)
//     {
//         negNum=negNum+array[i];
//     }
//     Console.Write(array[i]+",");
// }
// Console.WriteLine("Сумма положительных чисел равна"+ posNum);
// Console.WriteLine("Сумма отрицательных чисел равна"+ negNum);



// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int [] array = {5, -3, 14, -9, -21};

// for(int i=0;i<array.Length; i++)
// {
//     array[i]*= -1;
// }
// for(int i=0;i<array.Length; i++)
// {
//     Console.WriteLine(array[i] + ",");
// }

// Задача 33: Задайте массив. 
// Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// int [] array = new int [6];
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// bool tr=false;

// for(int i=0;i<array.Length; i++)
// {
//     array[i] = new Random().Next(6);
//     Console.WriteLine(array[i]);
//     if (array[i]==num)
//     {
//         tr=true;
//     }
// }
// if (tr)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//      Console.WriteLine("Нет");
// }
 

// Задача 35: Задайте одномерный массив из 5 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int [] array = new int [5];
// int count = 0;
// for(int i=0;i<array.Length; i++)
// {
//     array[i] = new Random().Next(150);
//     Console.WriteLine(array[i]);
// }
// for(int i=0;i<array.Length; i++)
// {
//    if(array[i]>10 && array[i]<100)
//    {
//     count++;
//    }
// }
// Console.WriteLine("количество элементов массива, значения которых лежат в отрезке [10,99]" + count);


// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int [] array = {1,6,72,2,84};
// int index = array.Length-1;
// int len=array.Length%2;
// int newIndex=0;
// int newNum=0;
// int [] result = new int [array.Length/2 + array.Length%2];
// if(len>0)
// {
//     newIndex = array.Length/2+1;
// }
// for(int i=0;i<array.Length; i++)
// {
//     result [i] = array[i]*array[index-i];
//     Console.WriteLine(result[i]);
//     if(newIndex==i)
//     {
//         newNum= array[i];
//     }
// }
// Console.WriteLine(newNum);



/////////////////////////// Домашняя работа//////////////////////////
// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int [] array = new int [5];
// int evennnum = 0;
// for(int i=0;i<array.Length; i++)
// {
//     array[i]= new Random().Next(100, 1000);
//     Console.WriteLine(array[i]);
// }
// for(int i=0;i<array.Length; i++)
// {
//     if(array[i]%2==0)
//     {
//         evennnum++;
//     }
// }
// Console.WriteLine(evennnum);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int size = 5;
// int sum =0;
// int[] array = GetArray(size);
// int [] GetArray(int size)
// {
//     int [] array = new int [size];
//     for(int i=0;i<size; i++)
//     {

//         array[i]= new Random().Next(-10, 10);
//         Console.WriteLine(array[i]);
//         int index = array[i];
//         if(index%2!=0)
//         {
//         sum=sum+index;
//         }

//     }
//     return array;
// }
// Console.WriteLine("Сумма элементов, стоящих на нечётных позициях, равна"+ " " +sum);


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int size = 5;
int [] array = GetArray(size);
int [] GetArray (int size) 
{
    int [] array = new int[size];
    for (int i=0; i<size;  i++)
    {
        array[i]= new Random().Next(0,100);
    }
    return array;
}
Console.WriteLine(String.Join(",", array));

int max = array[0];
for (int i=0; i<size; i++)
{
    if(array[i]>max)
    {
        max=array[i];
    }
}
int min = array[0];
for(int i=0; i<size; i++)
{
    if(array[i]<min)
    {
        min=array[i];
    }
}
Console.WriteLine("разница между максимальным и минимальным элементов массива равна"+" "+ (max-min));