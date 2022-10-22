/// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FindIntersectPointCoordinates()
{

    Console.WriteLine();
    Console.WriteLine("Hello! We may to calculate intersect point's coordinates of two lines. If their exist");
    Console.Write("Input b1, please: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input k1, please: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input b2, please: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input k2, please: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();

    if (k1 != k2)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Crossline's coordinates are: x = {x} ; y = {y}");
    }
    else Console.WriteLine("Intersept point's coordinates don't exist. These lines are parallel.");

    Console.WriteLine();
}
//Вызов метода
FindIntersectPointCoordinates();
