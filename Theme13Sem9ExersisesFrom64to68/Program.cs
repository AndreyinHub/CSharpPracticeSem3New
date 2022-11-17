// Задача 64:РЕШЕНА
//  Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
Console.Write("Input number you need N: ");
int n = Convert.ToInt32(Console.ReadLine());

void ShowNumsInRangeFromOne(int n)
{
    if (n > 1)
    {
        Console.Write(n + " ");
        ShowNumsInRangeFromOne(n - 1);
    }
    else Console.Write(n + " ");
}

Console.WriteLine();
Console.Write("This numbers are: ");
ShowNumsInRangeFromOne(n);
Console.WriteLine();
*/
//--------------------------------------------
// Задача 66: РЕШЕНА
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30
/*
Console.WriteLine();
Console.Write("Input origin number of range M:    ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input end number of range N:       ");
int n = Convert.ToInt32(Console.ReadLine());

int SumRangeNumsMtoN (int n, int m)
{
    if (n == m) return m;
    else if(n > m)  return n = n + SumRangeNumsMtoN(m, n-1);
        else return m = m + SumRangeNumsMtoN(m-1, n);
}

Console.WriteLine();
Console.WriteLine($"Sum of numberc from {m} to {n} is: {SumRangeNumsMtoN(m, n)}");
Console.WriteLine();
*/
//----------------------------
// Задача 68: РЕШЕНА
// Напишите программу 
// вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Input first argument- number  m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second argument- number n: ");
int n = Convert.ToInt32(Console.ReadLine());


int AccermanFnFind(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AccermanFnFind(m - 1, 1);
    if (m > 0 && n > 0) return AccermanFnFind(m - 1, AccermanFnFind(m, n - 1));
    return AccermanFnFind(m, n);
}
Console.WriteLine($"For m = {m} and n = {n} Ackermann function's value is: {AccermanFnFind(m, n)}");