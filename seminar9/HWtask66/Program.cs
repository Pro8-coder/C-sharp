/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int numberRead(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int SumMtoNRecurs(int m, int n)
{
    if (m > n)
    {
        int temp1 = n;
        n = m;
        m = temp1;
        //return SumMtoNRecurs(m, n);
    }
    // else if (n == m)
    // {
    //     return SumMtoNRecurs(m, n - 1) + n;
    // }
    // else if (m < n)
    // {
    //     return SumMtoNRecurs(m, n - 1) + n;
    // }
    return SumMtoNRecurs(m, n - 1) + n;
}


int M = numberRead("Введите число M: ");
int N = numberRead("Введите число N: ");
int sumMtoN = SumMtoNRecurs(M, N);
Console.WriteLine($"{sumMtoN}");
