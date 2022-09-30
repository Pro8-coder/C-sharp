/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/

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
