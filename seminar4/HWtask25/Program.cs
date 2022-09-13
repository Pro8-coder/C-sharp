/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
Не использовать Math.Pow() и аналоги!*/

// int numberRead(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }


// int Exponentiation(int number1, int number2)
// {
//     int number = number1;
//     if (number2 > 0)
//     {
//         for (int i = 1; i < number2; i++)
//         {
//             number *= number1;
//         }
//     }
//     else
//     {
//         Console.WriteLine("Число B должно быть больше 0!");
//     }
//     return number;
// }


// int numberA = numberRead("Введите число A: ");
// int numberB = numberRead("Введите число B: ");
// int exponent = Exponentiation(numberA, numberB);
// Console.WriteLine($"Число {numberA} в степени {numberB} равно {exponent}");

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int numberExponent = numberA;
for (int i = 1; i < numberB; i++)
{
    numberExponent *= numberA;
}
Console.WriteLine($"Число {numberA} в степени {numberB} равно {numberExponent}");
