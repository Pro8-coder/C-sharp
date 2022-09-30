/*Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"*/

int numberRead(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


void Print1toNRecurs(int n)
{
    if (n<=0)
    {
        return;
    }
    else
    {
        Print1toNRecurs(n-1);
        Console.Write($"{n} ");
    }
}


int N = numberRead("Введите число: ");
Print1toNRecurs(N);
