// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void elementPos(int[,] array, int x, int y)
{
    Console.WriteLine("===========================");
    if ((x < array.GetLength(0)) && (y < array.GetLength(1)))
    {
        Console.WriteLine("Элемент на позиции [" + x + ";" + y + "] равен " + array[x, y]);
    }
    else
    {
        Console.WriteLine("Такой позиции в массиве нет ");
    }
    Console.WriteLine("===========================");
}

Console.WriteLine("Введите число строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = generateArray(m, n);
printArray(array);
Console.WriteLine("Введите номер строки, начиная c нуля");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца, начиная c нуля ");
int y = Convert.ToInt32(Console.ReadLine());
elementPos(array, x, y);
