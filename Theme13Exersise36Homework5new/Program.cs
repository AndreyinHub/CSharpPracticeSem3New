// Задача 36: РЕШЕНА
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] ArrayDoRandom()
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
    return arrayToDo;
}

void PrnMyArray(int[] arrayPrn)
{
    for (int i = 0; i < arrayPrn.Length; i++)
    {
        Console.Write(arrayPrn[i] + " ");
    }
    Console.WriteLine();
}

int FindSumdOddPositionElements(int[] inputArray)
{
    int sum = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (i % 2 > 0) sum = sum + inputArray[i];
    }
    return sum;
}

int[] arrayNumPlus = ArrayDoRandom();
Console.WriteLine();
Console.Write($"This array is: "); PrnMyArray(arrayNumPlus);
Console.WriteLine($" Sum of elements, having odd indexes, is: {FindSumdOddPositionElements(arrayNumPlus)}");
Console.WriteLine();
