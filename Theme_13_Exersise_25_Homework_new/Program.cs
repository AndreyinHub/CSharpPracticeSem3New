//Задача 25: РЕШЕНА
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


double GetExponent(double a, double b)
{
   double num = a; 
   double count = 1;

    while (count < b)
   {
        num = num * a;
        count++;    
   }
    return num; 
}

Console.Write("Input your digit: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Input degree of you need: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($" {GetExponent(a,b)} ");
