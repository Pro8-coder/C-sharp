/*Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36*/

int numberRead(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int numberSumFrom1ToA(int a)
{
    if (a >= 1)
    {
        int sum = 0;
        for (int i = 1; i <= a; i++)
        {
            sum += i;
        }
        return sum;
    }
    else
    {
        Console.WriteLine("A должна быть не менее 1!");
        return -1;
    }
}


int number = numberRead("Введите число: ");
int summa = numberSumFrom1ToA(number);
Console.WriteLine($"Сумма элементов от 1 до A: {summa}");
