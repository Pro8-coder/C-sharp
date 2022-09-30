/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int numberRead(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int RaisingADegreeB(int num, int degree)
{
    if (degree == 1)
    {
        return num;
    }
    else
    {
        return RaisingADegreeB(num, degree - 1) * num;
    }
}


int A = numberRead("Введите число A: ");
int B = numberRead("Введите степень B: ");
int raisingADegreeB = RaisingADegreeB(A, B);
Console.WriteLine(raisingADegreeB);
