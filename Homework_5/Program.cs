
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] array = CreateArray(new Random().Next(1, 11));
PrintArray(array);
NumberOfEvenNumbers(array);


void NumberOfEvenNumbers(int[] _array)
{
    int count = 0;
    for (int i = 0; i < _array.Length; i++)
    {
        if (_array[i] % 2 == 0) count++;
    }
    Console.WriteLine($"{count}");
}

int[] CreateArray(int size)
{
    int[] _array = new int[size];
    for (int i = 0; i < size; i++)
    {
        _array[i] = new Random().Next(100, 1000);
    }
    return _array;
}

void PrintArray(int[] _array)
{
    Console.Write("[ ");
    foreach (var item in _array)
        Console.Write($"{item} ");
    Console.WriteLine("]");
}


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6]-> 0

int[] array = CreateArray(new Random().Next(3, 10));
PrintArray(array);
SumOfOddPositions(array);


int[] CreateArray(int size)
{
    int[] _array = new int[size];
    for (int i = 0; i < size; i++)
        _array[i] = new Random().Next(-20, 21);
    return _array;
}

void PrintArray(int[] _array)
{
    Console.Write("[");
    foreach (var item in _array)
        Console.Write($"{item} ");
    Console.WriteLine("]");
}

void SumOfOddPositions(int[] _array)
{
    int sum = 0;
    for (int i = 0; i < _array.Length; i++)
    {
        if (i % 2 != 0) sum += _array[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");
}



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и
//  минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] arr = CreateArray(new Random().Next(1, 11));
PrintArray(arr);
Diff(arr);

double[] CreateArray(int size)
{
    double[] _array = new double[size];
    for (int i = 0; i < size; i++)
    {
        _array[i] = new Random().Next(-20, 21);
    }
    return _array;
}

void PrintArray(double[] _array)
{
    Console.Write("[ ");
    foreach (var item in _array)
        Console.Write($"{item} ");
    Console.WriteLine(']');
}

void Diff(double[] _array)
{
    double max = _array[0];
    double min = _array[0];
    for (int i = 1; i < _array.Length; i++)
    {
        if (_array[i] > max) max = _array[i];
        if (_array[i] < min) min = _array[i];
    }
    Console.WriteLine($"Max: {max}");
    Console.WriteLine($"Min: {min}");
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {max - min}");
}

