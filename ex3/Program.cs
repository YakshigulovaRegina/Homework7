// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] generateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 20);
        }
    }
    return array;
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{(array[i, j])} ; ");
        }
        Console.WriteLine();
    }
}


void calcAvgArifForColumn(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double summa = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summa += array[i, j];
        }
        double avgArif = summa / array.GetLength(0);
        Console.WriteLine("============================================");
        Console.WriteLine($"Сумма элементов столбца '" + (j + 1) + "' " + summa);
        Console.WriteLine($"Среднее арифметическое столбца '" + (j + 1) + "' " + Math.Round(avgArif, 2));
        Console.WriteLine("============================================");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите число строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = generateArray(m, n);
printArray(array);
calcAvgArifForColumn(array);
