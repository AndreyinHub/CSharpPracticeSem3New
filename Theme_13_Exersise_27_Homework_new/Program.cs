// // Задача 27: РЕШЕНА
// //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12

int SumAllDigOfNumber(int number)
{
    number = Math.Abs(number);
    string message = Convert.ToString(number);
    int lengthNum = message.Length;

    int sum = 0;
    int i = 0;
    int n = lengthNum;
    int temp = number;
    while (i <= n)
    {
        if(n > 0)
        {
        int num = temp / Convert.ToInt32( Math.Pow(10, n - 1));
        sum = sum + num;
        temp = temp - num * Convert.ToInt32(Math.Pow(10, n - 1));
        //int newDig = Convert.ToInt32(num * Math.Pow(10, n - 1));
        //temp = temp - newDig;
        n = n - 1;
        }
        else break;
    }
    return sum;
}
Console.Write("Input positive integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumDigit = SumAllDigOfNumber(number);

Console.WriteLine($"Sum all digits of your number  {number} is: {sumDigit}.");

