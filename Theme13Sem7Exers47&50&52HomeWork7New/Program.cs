// Задача 47. РЕШЕНА
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
double[,] CreateRandom2DArrayDouble()
{
    Console.Write(" Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write(" Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("     Input min positive value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("     Input max positive value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round((double)(new Random().Next(minValue, maxValue + 1) + new Random().NextDouble()), 2);
        }
    }
    return array;
}

void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(" " + array[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

double[,] myArray = CreateRandom2DArrayDouble();
ShowArray(myArray);
*/

// Задача 50. РЕШЕНА
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет
/*
int[,] CreateRandom2DArray()
{
    Console.Write(" Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("     Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("         Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("             Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;

}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(" " + array[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

string ArraysElementValue(int[,] array)
{
    Console.WriteLine("Input 2D array element's indeces you need."); 
    Console.Write("Please, input rows position 'i': ");
    int iFind = Convert.ToInt32(Console.ReadLine());
    Console.Write("     And now columns position 'j': ");
    int jFind = Convert.ToInt32(Console.ReadLine());

    string valueArraysElement = "";
    if (array.GetLength(0) - 1 >= iFind && array.GetLength(1) - 1 >= jFind)
    {
        valueArraysElement = Convert.ToString(array[iFind, jFind]) + " - value of the 2D array's element whith indexes i, j you input.";
    }
    else
    {
        valueArraysElement = "Check,please! Element whith such indeces not exist";
    }    
    return valueArraysElement;
}

int[,] myArray = CreateRandom2DArray();
ShowArray(myArray);
Console.WriteLine();
Console.WriteLine($"{ArraysElementValue(myArray)}");
Console.WriteLine();
*/

// Задача 52. РЕШЕНА
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
int[,] CreateRandom2DArray()
{
    Console.Write(" Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("     Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("         Input min positive value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("             Input max positive value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;

}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(" " + array[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

void AverageIchArraysColumns(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int col = j;
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {

            sum = sum + array[i, j];

        }
        double averageColumns = Math.Round(sum / array.GetLength(0), 1);
        Console.Write($" Average {col} columns = " + averageColumns);
        Console.WriteLine();
    }
}

int[,] myArray = CreateRandom2DArray();
ShowArray(myArray);
AverageIchArraysColumns(myArray);
*/