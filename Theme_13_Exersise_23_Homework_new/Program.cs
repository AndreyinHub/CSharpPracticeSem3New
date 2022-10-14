//Задача 23 РЕШЕНА!
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine();
static void ShowQube(int n)
{
    int count = 1;
    while (count <= n)
    {
    Console.Write(Math.Pow(count, 3) + ", ");
    count++;
    }
}
Console.Write("Input your digit: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($" For n = {n} sequences is: ");
ShowQube(n);
Console.WriteLine();
Console.WriteLine();