/*Задача 21 РЕШЕНА
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.*/

Console.Clear();

double FindDistance3Dspace(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Round(Math.Pow((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)), 0.5), 2);
}

Console.Write("Input point1 x-coordinate : ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("     Input point1 y-coordinate : ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("         Input point1 z-coordinate : ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input point2 x-coordinate : ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("     Input point2 y-coordinate : ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("         Input point2 z-coordinate : ");
double z2 = Convert.ToDouble(Console.ReadLine());

//double res = Math.Round(Math.Pow((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)), 0.5), 2); 
Console.WriteLine($" Distance between 1 points and 2 equal {FindDistance3Dspace(x1, y1, z1, x2, y2, z2)} ");
Console.WriteLine();



