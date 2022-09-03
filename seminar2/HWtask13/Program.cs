/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberString = number.ToString();

if (numberString.Length < 3)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    Console.Write($"Третья цифра: {numberString[2]}");
}
