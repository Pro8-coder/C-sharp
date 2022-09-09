/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120*/

int numberRead(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int numberProdFrom1ToA(int a)
{
    if (a >= 1)
    {
        int prod = 1;
        for (int i = 2; i <= a; i++)
        {
            prod *= i;
        }
        return prod;
    }
    else
    {
        Console.WriteLine("N должна быть не менее 1!");
        return -1;
    }
}


int number = numberRead("Введите число: ");
int Prodma = numberProdFrom1ToA(number);
Console.WriteLine($"Произведение элементов от 1 до N: {Prodma}");

