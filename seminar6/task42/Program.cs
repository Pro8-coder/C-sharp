/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10*/

int numberRead(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


void ConvertArray10to2(int number)
{
    if (number <= 0) return;
    ConvertArray10to2(number / 2);
    Console.Write(number % 2);
}


int num = numberRead("Введите число: ");
ConvertArray10to2(num);
