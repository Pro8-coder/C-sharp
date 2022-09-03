/*11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98*/

Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine($"Сгенерировалось случайное число: {number}");
int digit1 = number / 100;
int digit2 = number % 10;
//Console.Write($"Новое число: {digit1}{digit2}");
int number2 = digit1 * 10 + digit2;
Console.Write($"Новое число:" + number2);
