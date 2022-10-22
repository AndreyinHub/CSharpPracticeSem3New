// //Задача 41: Пользователь вводит с клавиатуры M чисел. 
// //Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // Без массива!!!
// // 0, 7, 8, -2, -2 -> 2

int CountPositivInputNumbers()
{
    Console.Clear();
    Console.WriteLine();
    int numOfNumbers = new Random().Next(1, 10);
    Console.WriteLine($" Input {numOfNumbers} random numbers");
    Console.WriteLine();

    int count = 0;

    for (int i = 0; i < numOfNumbers; i++)
    {
        Console.Write("Input number, please: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        if (inputNumber > 0)

            count++;
    }
    return count;
}

int countInputPositives = CountPositivInputNumbers();

Console.WriteLine();
Console.WriteLine($"You inputed {countInputPositives} positiv numbers.");
Console.WriteLine();
