/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int numberRead(string message)                                             //через конверт
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int sumDigits(int number)
{
    string numberString = number.ToString();
    int sum = 0;
    for (int i = 0; i < numberString.Length; i++)
    {
        int numberi = (int)Char.GetNumericValue(numberString[i]);
        //int numberi = numberString[i] - '0';                                //или так (как по мне самый интересный вариант :) )
        sum += numberi;
    }
    return sum;
}


int Number = numberRead("Введите число: ");
string NumberString = Number.ToString();
int SumDig = sumDigits(Number);
Console.WriteLine($"Сумма цифр числа {Number} равна {SumDig}");



// Console.WriteLine("Введите число: ");                                       //через деление
// int number = Convert.ToInt32(Console.ReadLine());
// string numberString = number.ToString();
// int sum = 0;
// int numberCopy = number;
// for (int i = 0; i < numberString.Length; i++)
// {
//     int numberi = numberCopy % 10;
//     sum += numberi;
//     numberCopy /= 10;
// }
// Console.WriteLine($"Сумма цифр числа {number} равна {sum}");
