// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
// ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int N;
Console.WriteLine("Введите количество чисел: ");
int.TryParse(Console.ReadLine()!, out N);

int count = 0;
int a = 0;

for (int i = 0; i < N; i++)
{
    Console.WriteLine("Введите число из последовательности: ");
    int.TryParse(Console.ReadLine()!, out a);
    if (a > 0) count += 1;
}

Console.WriteLine($"Кол-во чисел больше 0 равно: {count}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1, k1, b2, k2;
double x, y;

Console.WriteLine("Введите значение b1: ");
double.TryParse(Console.ReadLine()!, out b1);
Console.WriteLine("Введите значение k1: ");
double.TryParse(Console.ReadLine()!, out k1);
Console.WriteLine("Введите значение b2: ");
double.TryParse(Console.ReadLine()!, out b2);
Console.WriteLine("Введите значение k2: ");
double.TryParse(Console.ReadLine()!, out k2);


if (k1 == k2 && b1 == b2)
    Console.WriteLine("Прямые совпадают");
else if (k1 == k2)
    Console.WriteLine("Прямые параллельны");
else
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine(
        String.Format("Точка пересечения двух прямых: ({0:0.##}, {0:0.##})", x, y));

}











