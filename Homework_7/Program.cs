// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = 3, n = 4;

int k = 10;

double[,] array = CreateArray(m, n);

double[,] CreateArray(int _m, int _n, int min = -10, int max = 11)
{
    double[,] _array = new double[_m, _n];
    for (int i = 0; i < _array.GetLength(0); i++)
    {
        for (int j = 0; j < _array.GetLength(1); j++)
        {
            _array[i, j] = (double)new Random().Next(min * k, max * k) / k;
            Console.Write($"{_array[i, j]} ");
        }
        Console.WriteLine();
    }
    return _array;
}


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int m = 3, n = 4;

int[,] array = CreateArray(m, n);


int[,] CreateArray(int _m, int _n, int min = 0, int max = 10)
{
    int[,] _array = new int[_m, _n];
    for (int i = 0; i < _array.GetLength(0); i++)
    {
        for (int j = 0; j < _array.GetLength(1); j++)
        {
            _array[i, j] = new Random().Next(min, max);
            Console.Write($"{_array[i, j]} ");
        }
        Console.WriteLine();
    }
    return _array;

}

int x, y;

Console.WriteLine("Введите позицию элемента");
int.TryParse(Console.ReadLine()!, out x);

y = x % 10;  // индекс столбца
x = x / 10;  // индекс строки


if (x >= array.GetLength(0) || y >= array.GetLength(1) || x < 0)
    Console.WriteLine("Такого числа в массиве нет");
else
    Console.WriteLine($"{array[x, y]}");




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = 4, n = 4;

int[,] array = CreateArray(m, n);

int[,] CreateArray(int _m, int n, int min = 0, int max = 10)
{
    int[,] _array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            _array[i, j] = new Random().Next(min, max);
            Console.Write($"{_array[i, j]} ");
        }
        Console.WriteLine();
    }
    return _array;
}


double simpleAverage = 0;
double[] arrOfSimpleAverage = new double[array.GetLength(1)];
for (int i = 0; i < n; i++)
{
    int sum = 0;
    for (int j = 0; j < m; j++)
    {
        sum += array[j, i];
    }
    simpleAverage = (double)sum / array.GetLength(0);
    arrOfSimpleAverage[i] = simpleAverage;

}

Console.Write("Среднее арифметическое каждого столбца:");
foreach (var item in arrOfSimpleAverage)
{
    Console.Write($" {item}; ");
}






