﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int N;
// Console.WriteLine("Введите число: ");
// int.TryParse(Console.ReadLine()!, out N);

// Console.WriteLine(PrintNumbers(N));

// string PrintNumbers(int _N)
// {
//     if (_N == 1)
//         return 1.ToString();
//     return $"{_N} {PrintNumbers(_N - 1)}";
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// double M, N;
// Console.WriteLine("Введите первое число ");
// double.TryParse(Console.ReadLine()!, out M);

// Console.WriteLine("Введите второе число ");
// double.TryParse(Console.ReadLine()!, out N);

// Console.WriteLine(Sum((int)M, (int)N));

// int Sum(int a, int b)
// {
//     if (a == b)
//         return b;
//     return a + Sum(a + 1, b);
// }


// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int M, N;
Console.WriteLine("Введите первое неотрицательное число ");
int.TryParse(Console.ReadLine()!, out M);

Console.WriteLine("Введите второе неотрицательное число ");
int.TryParse(Console.ReadLine()!, out N);

int AckermannFunction(int _M, int _N)
{
    if (_M = 0)
    {
        return _N + 1;
    }
    else if (_M > 0 && _N == 0)
    {
        return
    }
    else if (_M > 0 && _N > 0)
    {

    }
    else
        Console.WriteLine("Функция Аккермана определена для неотрицательных целых чисел. Измените вводные данные.");

}










