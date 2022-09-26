/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/

int numberRead(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int num = numberRead("Введите число больше 2: ");
int[] Fibonachi(int number)
{
    int[] arrNew = new int[num];
    arrNew[0] = 0;
    arrNew[1] = 1;
    for (int i = 0; i < number - 2; i++)
    {
        arrNew[i + 2] = arrNew[i] + arrNew[i + 1];
    }
    return arrNew;
}


if (num > 2)
{
    int[] array = Fibonachi(num);
    Console.Write(string.Join(", ", array));
}
else
{
    Console.Write("Введенное число должно быть больше 2!");
}
