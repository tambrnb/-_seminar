// Задача 1
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int sqr = number * number;
// Console.WriteLine(sqr);


// Задача 2

// Console.WriteLine("Введите число");
// int number_1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int number_2 = Convert.ToInt32(Console.ReadLine());

// if(number_1 == number_2 * number_2)
// {
//     Console.WriteLine("Число 1 является квадратом 2-го числа");
// }
// else
// {
//     Console.WriteLine("Число 1 не является квадратом 2-го числа")
// }



// Задача 3 для показа дня недели

// Console.WriteLine("Введите число");
// int number_1 = Convert.ToInt32(Console.ReadLine());

// if(number_1 > 7||number_1 < 1)
// {
//     Console.WriteLine("Ошибка");
// }
// if(number_1 == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// if(number_1 == 2)
// {
//     Console.WriteLine("Вторник");
// }
// if(number_1 == 3)
// {
//     Console.WriteLine("Среда");
// }
// if(number_1 == 4)
// {
//     Console.WriteLine("Четверг");
// }
// if(number_1 == 5)
// {
//     Console.WriteLine("Пятница");
// }
// if(number_1 == 6)
// {
//     Console.WriteLine("Суббота");
// }
// if(number_1 == 7)
// {
//     Console.WriteLine("Воскресенье");
// }



// Задача 4

// Console.Write("Введите число");
// int number_1 = Convert.ToInt32(Console.ReadLine());

// int numberNeg = number_1 * (-1);

// while(numberNeg <= number_1)
// {
//     Console.WriteLine(numberNeg);
//     numberNeg++;
// }



// Задача 5

// Console.Write("Введите число ");
// int number_1 = Convert.ToInt32(Console.ReadLine());
// int number_2 = number_1%10;
// Console.WriteLine(number_2);





//////// Домашняя работа///////////

// ЗАДАЧА №2

// Console.WriteLine("Введите число");
// int number_1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int number_2 = Convert.ToInt32(Console.ReadLine());
// int max = number_1;

// if(number_1 > number_2)
// {
//     max = number_1;
// }
// else
// {
//     max = number_2;
// }
// Console.WriteLine(max);


////////////////////////////////////////////////////////
// ЗАДАЧА №4

// Console.WriteLine("Введите число");
// int number_1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int number_2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int number_3 = Convert.ToInt32(Console.ReadLine());

// int max = 0;
// if(number_1>number_2)
// {
//    if(number_1>number_3)
//    {
//     max = number_1;
//    }
//     else
//     {
//     max = number_3;
//     }
// }
// else if (number_2>number_3)
// {
//     max = number_2;
// }
// else
// {
//     max = number_3;
// }
// Console.WriteLine("Максимальное число:" + max);

///////////////////////////////////////////
// ЗАДАЧА №6

// Console.WriteLine("Введите число");
// int number_1 = Convert.ToInt32(Console.ReadLine());

// if(number_1%2 == 0)
// {
//     Console.WriteLine("Число четное");
// }
// else
// {
//     Console.WriteLine("Число нечетное");
// }


////////////////////////////////////////////////////
//ЗАДАЧА №8

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;

while(count <= N)
{
    if(count%2 == 0)
        {Console.WriteLine(count);}
count++;
}

