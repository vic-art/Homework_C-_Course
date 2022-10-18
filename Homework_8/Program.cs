// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int m = 3, n = 4;

int[,] array = CreateArray(m, n);
int[,] sortedArray = Sorting(array);
Console.WriteLine();
PrintArray(sortedArray);


int[,] CreateArray(int _m, int _n, int max = 10, int min = 0)
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

int[,] Sorting(int[,] _array)
{
    for (int i = 0; i < _array.GetLength(0); i++)
    {
        for (int j = 0; j < _array.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < _array.GetLength(1) - j - 1; k++)
            {
                if (_array[i, k] < _array[i, k + 1])
                {
                    int temp = _array[i, k];
                    _array[i, k] = _array[i, k + 1];
                    _array[i, k + 1] = temp;
                }
            }

        }
    }
    return _array;
}

void PrintArray(int[,] _array)
{
    for (int i = 0; i < _array.GetLength(0); i++)
    {
        for (int j = 0; j < _array.GetLength(1); j++)
        {
            Console.Write($"{_array[i, j]} ");
        }
        Console.WriteLine();
    }
}





// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой 
// элементов: 1 строка

int m = 4, n = 4;

int[,] array = CreateArray(m, n);

SmallestSum(array);

int[,] CreateArray(int _m, int _n, int min = 0, int max = 10)
{
    int[,] _array = new int[_m, _n];
    for (int i = 0; i < _m; i++)
    {
        for (int j = 0; j < _n; j++)
        {
            _array[i, j] = new Random().Next(min, max);
            Console.Write($"{_array[i, j]} ");
        }
        Console.WriteLine();
    }
    return _array;

}

void SmallestSum(int[,] _array)
{
    int min = 0;
    int rowNumber = 1;
    for (int i = 0; i < _array.GetLength(0); i++)
    {
        int sum = 0;
        for (int k = 0; k < _array.GetLength(1); k++)
        {
            sum += _array[i, k];
        }
        if (i == 0)
            min = sum;
        else if (sum < min)
        {
            min = sum;
            rowNumber = i + 1;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {rowNumber} строка");
}



// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int m, n, k;

Console.WriteLine("Введите число строк 1-ой матрицы");
int.TryParse(Console.ReadLine()!, out m);

Console.WriteLine("Введите число столбцов 1-ой матрицы (и строк 2-ой матрицы)");
int.TryParse(Console.ReadLine()!, out n);

Console.WriteLine("Введите число столбцов 2-ой матрицы");
int.TryParse(Console.ReadLine()!, out k);

Console.WriteLine("Первая матрица");
int[,] matrix1 = CreateArray(m, n);
Console.WriteLine("Вторая матрица");
int[,] matrix2 = CreateArray(n, k);
Console.WriteLine("Результат умножения матриц");
dotProduct(matrix1, matrix2);


int[,] CreateArray(int _m, int _n, int min = 0, int max = 5)
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

void dotProduct(int[,] _matrix1, int[,] _matrix2)
{
    int[,] _result = new int[m, k];
    for (int i = 0; i < _result.GetLength(0); i++)
    {
        for (int j = 0; j < _result.GetLength(1); j++)
        {
            int sum = 0;
            for (int l = 0; l < _matrix1.GetLength(1); l++)
            {
                sum += _matrix1[i, l] * _matrix2[l, j];
            }
            _result[i, j] = sum;
            Console.Write($"{_result[i, j]} ");
        }
        Console.WriteLine();
    }
}






// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных 
// чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] array = new int[2, 2, 2];

List<int> nums = new List<int>();

for (int i = 0; i < 20; i++)
    nums.Add(i + 10);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            if (nums.Count == 0)
                array[i, j, k] = 0;
            else
            {
                int temp = new Random().Next(nums.Count);
                array[i, j, k] = nums[temp];
                nums.RemoveAt(temp);
            }
        }
    }
}


WriteArray(array);


void WriteArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"x({i}) y({j}) ");
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"z({k})={array[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}




// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int m = 4;

int[,] array = CreateArray(m);
PrintArray(array);

int[,] CreateArray(int _m)
{
    int[,] _array = new int[_m, _m];
    for (int i = 0, j = 0, k = 0; k < _array.Length; k++)
    {
        _array[i, j] = k + 1;
        if (i <= j + 1 && i + j < _array.GetLength(1) - 1)
            j++;  // вправо
        else if (i < j && i + j >= _array.GetLength(0) - 1)
            i++;  // вниз
        else if (i >= j && i + j > _array.GetLength(1) - 1)
            j--; // влево
        else
            i--; // вверх
    }
    return _array;
}

void PrintArray(int[,] _array)
{
    for (int i = 0; i < _array.GetLength(0); i++)
    {
        for (int j = 0; j < _array.GetLength(1); j++)
        {
            Console.Write(string.Format("{0:00} ", _array[i, j]));
        }
        Console.WriteLine();
    }
}