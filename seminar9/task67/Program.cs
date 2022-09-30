/*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/

int numberRead(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}





int N = numberRead("Введите число N: ");
