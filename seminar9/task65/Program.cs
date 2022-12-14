/*Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"*/

int numberRead(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


void PrintMtoNRecurs(int m, int n)
{
    if (m > n)
    {
        int temp1 = n;
        n = m;
        m = temp1;
        PrintMtoNRecurs(m, n);
    }
    else if (n == m)
    {
        Console.Write($"{n} ");
        return;
    }
    else if (m < n)
    {
        PrintMtoNRecurs(m, n - 1);
        Console.Write($"{n} ");
    }
}


int M = numberRead("Введите число M: ");
int N = numberRead("Введите число N: ");
PrintMtoNRecurs(M, N);
