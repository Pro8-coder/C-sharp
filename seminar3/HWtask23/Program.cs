/*Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("Введите число больше 0: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;

if (N > 0)
{
    while (count <= N)
    {
        Console.Write(Math.Pow(count, 3) + " ");
        count++;
    }
}
else
{
    Console.WriteLine("Введённое число должно быть больше 0.");
}
