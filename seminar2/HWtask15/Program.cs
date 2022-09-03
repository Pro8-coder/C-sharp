/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] weekdays = new int[5] { 1, 2, 3, 4, 5 };
int[] weekend = new int[2] { 6, 7 };

//if (weekdays.Exists (number))
if (System.Array.IndexOf(weekdays, number) >= 0)
{
    Console.WriteLine("Нет, это не выходной день");
}
//else if (weekend.Exists(number))
else if (System.Array.IndexOf(weekend, number) >= 0)
{
    Console.WriteLine("Да, это выходной день");
}
else
{
    Console.WriteLine("В неделе 7 дней!!!");
}

// if (number == 1)
// {
//     Console.WriteLine("Нет, понедельник не выходной день");
// }
// else if (number == 2)
// {
//     Console.WriteLine("Нет, вторник не выходной день");
// }
// else if (number == 3)
// {
//     Console.WriteLine("Нет, среда не выходной день");
// }
// else if (number == 4)
// {
//     Console.WriteLine("Нет, четверг не выходной день");
// }
// else if (number == 5)
// {
//     Console.WriteLine("Нет, пятница не выходной день");
// }
// else if (number == 6)
// {
//     Console.WriteLine("Да, суббота выходной день");
// }
// else if (number == 7)
// {
//     Console.WriteLine("Да, воскресенье выходной день");
// }
// else
// {
//     Console.WriteLine("В неделе 7 дней!!!");
// }
