// Задача 34: РЕШЕНА
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// ________________________________________

Console.Clear();

int[] ArrayDoRandom(int size, int minValue, int maxValue)
{
    int[] arrayToDo = new int[size];

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

int NumberOfPositiveArraysElements(int[] arrayToDo)
{

    int countPlus = 0;

    for (int i = 0; i < arrayToDo.Length; i++)
    {

        if (arrayToDo[i] % 2 == 0)
            countPlus = countPlus + 1;

    }
    return countPlus;
}

Console.WriteLine();
Console.Write("Input length of your array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minValue of array's elements: ");  //массив заполненный случайными  
int minValue = Convert.ToInt32(Console.ReadLine());     //положительными трёхзначными числами
Console.Write("Input maxValue of array's elements: ");
int maxValue = Convert.ToInt32(Console.ReadLine());     //положительными трёхзначными числами

int[] arrayNumPlus = ArrayDoRandom(length, minValue, maxValue);
Console.WriteLine();
Console.Write("This array is: "); PrnMyArray(arrayNumPlus);
int[] numPlus = ArrayDoRandom(length, minValue, maxValue);
Console.Write($"It's conteins {NumberOfPositiveArraysElements(arrayNumPlus)} positive numbers");
Console.WriteLine();
Console.WriteLine();
