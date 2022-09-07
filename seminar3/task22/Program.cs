/*Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1, 4*/

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;

if (N != 0)
{
    if (N > 0)
    {
        while (count <= N)
        {
            Console.Write(Math.Pow(count, 2) + " ");
            count++;
        }
    }
    else
    {
        count = -1;
        while (count >= N)
        {
            Console.Write(Math.Pow(count, 2) + " ");
            count -= 1;
        }
    }
}
else
{
    Console.WriteLine("Введённое число не должно быть 0.");
}
