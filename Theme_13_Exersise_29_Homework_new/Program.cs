// //Задача 29 Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// //m = 5 -> [1, 2, 5, 7, 19]
// //m = 3 -> [6, 1, 33]


int[] CreateArray(int length)
{
    int[] newArray = new int[length];

    for (int i = 0; i < length; i++)
        newArray[i] = new Random().Next(0, 100);

    return newArray;
}

void PrnMyArray(int[] arrayPrn)
{
    for (int i = 0; i < arrayPrn.Length; i++)
    {
        Console.Write(arrayPrn[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Input length of your array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] arrayToPrn = CreateArray(length);
PrnMyArray(arrayToPrn);