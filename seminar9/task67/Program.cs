/*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/

int numberRead(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int SumDigitsNumber(int num)
{
    if (num / 10 == 0)
    {
        return num;
    }
    else
    {
        int sum = 0;
        return sum += SumDigitsNumber(num / 10) + num % 10;
    }
}


int N = numberRead("Введите число N: ");
int sumDigitsNumber = SumDigitsNumber(N);
Console.WriteLine(sumDigitsNumber);
