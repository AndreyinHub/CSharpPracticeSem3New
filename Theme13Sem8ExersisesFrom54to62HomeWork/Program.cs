// Задача 54: РЕШЕНА
// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
/*
int[,] Create2DArray()    //Готовый метод для генерации целочисленного рандомного 2Д массива
{
    Console.Write("Input rows's number ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns's number ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min positive value ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input Max positive value ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

     int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

int[,] Array2DBubbleSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1) - 1; k++)
        {
            for (int j = 0; j < array.GetLength(1) - 1 - k; j++)
            {
                if (array[i, j + 1] > array[i, j])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
                //Console.Write(array[j] + " ");
            }
        }
    }
    Console.WriteLine();
    return array;
}

int[,] arrayRandom2D = Create2DArray();
PrintArray(arrayRandom2D);
PrintArray(Array2DBubbleSort(arrayRandom2D));
*/

// Задача 56: РЕШЕНА
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
//и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int[,] arrayToSum = new[,]  {{4,8,2,5,2}, //19          //21
                            {1,1,2,1,2},  //5           //7
                            {8,4,8,5,2},  //25          //27
                            {4,4,7,1,2}}; //16 ВСЕГО 65 //18   //73

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

PrintArray(arrayToSum);

void ArrayMinSumRowNumber(int[,] array)
{
    int minSum = 0;
    int minSumRowNumber = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minSum)
        {
            minSum = sumRow;
            minSumRowNumber = i;
        }
        sumRow = 0;
    }
    Console.Write($"Min rows's sum have {minSumRowNumber + 1} row");
}

Console.WriteLine();
ArrayMinSumRowNumber(arrayToSum);
Console.WriteLine();
*/

// Задача 58: РЕШЕНА
// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] arrayA = new[,] {    {2, 4, 2},
                            {3, 2, 3},
                            {2, 3, 4}};

int[,] arrayB = new[,] {    {3, 4, 2},
                            {3, 3, 2},
                            {2, 3, 4}};
int[,] arrayResultC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];

void ArraysMultyplay(int[,] arrayA, int[,] arrayB, int[,] arrayResultC)
{
    for (int i = 0; i < arrayResultC.GetLength(0); i++)
    {
        for (int j = 0; j < arrayResultC.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                sum += arrayA[i, k] * arrayB[k, j];
            }
            arrayResultC[i, j] = sum;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
ArraysMultyplay(arrayA, arrayB, arrayResultC);
Console.WriteLine();
Console.WriteLine($"The array A multiplied ar.B is: ");
PrintArray(arrayResultC);
Console.WriteLine();


// Задача 60. РЕШЕНА
// ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
/*
int[,,] Do3DArray()
{
    Console.Write("Input rows's number ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns's number ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input layer's number ");
    int layers = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min positive value ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input Max positive value ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,,] array = new int[rows, columns, layers];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(9, 99);
            }
        }
    }
  
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)

        for (int j = 0; j < array.GetLength(1); j++)

            for (int k = 0; k < array.GetLength(2); k++)

                Console.WriteLine(array[i, j, k] + " " + "["+ i + ","+ j +","+ k +"]");
    Console.WriteLine();
    Console.WriteLine();

}
int[,,] ourArray = Do3DArray();
PrintArray(ourArray);
*/

// Задача 62. РЕШЕНА
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
/*
int[,] ArraySpiralFil()
{
Console.Write("Input rows's number ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns's number ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

    int step = 1;
    int colsBegin = 0;
    int colsFin = array.GetLength(1) - 1;
    int rowsBegin = 0;
    int rowsFin = array.GetLength(0) - 1;

    while (colsBegin <= colsFin && rowsBegin <= rowsFin)
    {
        for (int i = colsBegin; i <= colsFin; i++)
        {
            array[rowsBegin, i] = step;
            step++;
        }
        rowsBegin++;

        for (int j = rowsBegin; j <= rowsFin; j++)
        {
            array[j, colsFin] = step;
            step++;
        }
        colsFin--;

        for (int i = colsFin; i >= colsBegin; i--)
        {
            array[rowsFin, i] = step;
            step++;
        }
        rowsFin--;

        for (int i = rowsFin; i >= rowsBegin; i--)
        {
            array[i, colsBegin] = step;
            step++;
        }
        colsBegin++;
    }
    return array;
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}
PrintArray(ArraySpiralFil());
*/