/*Задача 19 РЕШЕНА
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
//!=

void CheckPalindromLi(int num)
{
    num = Math.Abs(num);
    string answer = Convert.ToString(num);
    int length = answer.Length;
    if (length != 5)
        Console.WriteLine(" Error!!Needs only 5 digits in this number. Try again, please");

    int n = 1;
    int m = length - n;// m = 4;
    int num1 = num;

    int firstDig = num1 % 10;
    int lastDig = Convert.ToInt32(num1 / Math.Pow(10, m));

    if (firstDig == lastDig)
    {
        int numTemp = Convert.ToInt32(num1 % Math.Pow(10, m)) / 10;
        num1 = numTemp;
        m = m - 2;
        firstDig = num1 % 10;
        lastDig = Convert.ToInt32(num1 / Math.Pow(10, m));
    }

    if (firstDig == lastDig) Console.WriteLine($"Число {num} - палиндром.");
    else
        Console.WriteLine($" Число {num} - не палиндром.");
}

Console.WriteLine();
Console.Write("Input positive integer number with 5 digits: ");
int num = Convert.ToInt32(Console.ReadLine());

CheckPalindromLi(num);
Console.WriteLine();
