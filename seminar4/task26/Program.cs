/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

int numberRead(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int number = numberRead("Введите число: ");
string numberString = number.ToString();
int len = numberString.Length;
Console.WriteLine($"В числе {len} цифр");
