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
            array[i, j] = Math.Round((new Random().Next(minValue, maxValue + 1) + new Random().NextDouble()), 1);
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