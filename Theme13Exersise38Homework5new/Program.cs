// Задача 38: РЕШЕНА
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] ArrayDoRandomDouble()
{
    Console.WriteLine();
    Console.Write("Input length of your array: ");
    int length = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input minValue of array's elements: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input maxValue of array's elements: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[] arrayToDo = new int[length];

    for (int i = 0; i < arrayToDo.Length; i++)
    {
        arrayToDo[i] = new Random().Next(minValue, maxValue);
    }

    double[] arrayToDoDouble = new double[length];

    for (int i = 0; i < arrayToDo.Length; i++)
    {
        arrayToDoDouble[i] = (double)arrayToDo[i] + 0.23 * i;
    }
    return arrayToDoDouble;
}

void PrnMyArray(double[] arrayPrn)
{
    for (int i = 0; i < arrayPrn.Length; i++)
    {
        Console.Write(arrayPrn[i] + " ");
    }
    Console.WriteLine();
}

double FindMaxMinElementsDifferences(double[] inputArray)
{
    double max = inputArray[0];
    for (int i = 0; i < inputArray.Length; i++)
        if (inputArray[i] > max) max = inputArray[i];

    double min = inputArray[0];
    for (int i = 0; i < inputArray.Length; i++)
        if (inputArray[i] < min) min = inputArray[i];

    double differenceMaxMin = max - min;
    differenceMaxMin = Math.Round(differenceMaxMin, 2);

    return differenceMaxMin;
}

double[] arrayNumPlus = ArrayDoRandomDouble();
Console.WriteLine();
Console.Write($"This array is: "); PrnMyArray(arrayNumPlus);
Console.WriteLine($"    Difference array's Max and Min elements is: {FindMaxMinElementsDifferences(arrayNumPlus)}");
Console.WriteLine();

