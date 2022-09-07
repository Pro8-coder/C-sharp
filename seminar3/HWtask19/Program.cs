/*Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberString = number.ToString();

if (numberString.Length == 5)
{
    if (numberString == new string(numberString.Reverse().ToArray()))       //вариант через разворот (после того как сделал, понял что это и было доп задание к семинару 3 :D)
    {
        Console.Write("Да, это палиндром");
    }
    else
    {
        Console.Write("Нет, это не палиндром");
    }

    // for (int i = 0; i < numberString.Length / 2; i++)                       //вариант через цикл
    // {
    //     char ch = numberString[i];
    //     if (numberString[i] != numberString[numberString.Length - i - 1])
    //     {
    //         Console.WriteLine("Нет, это не палиндром");
    //         break;
    //     }
    //     else if (i == (numberString.Length / 2) - 1)
    //     {
    //         Console.WriteLine("Да, это палиндром");
    //     }
    // }
}
else
{
    Console.WriteLine("Введено не пятизначное число");
}
