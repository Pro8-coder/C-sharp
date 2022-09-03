/*9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8*/

Random rand = new Random();
int number = rand.Next(10, 100);
Console.WriteLine($"Сгенерировалось случайное число: {number}");
int digit1 = number / 10;
int digit2 = number % 10;
if(digit1 > digit2)
{
    Console.WriteLine($"Цифра {digit1} наибольшая в числе {number}");
}
else if(digit1 < digit2)
{
    Console.WriteLine($"Цифра {digit2} наибольшая в числе {number}");
}
else
{
    Console.WriteLine($"Цифры равны");
}
