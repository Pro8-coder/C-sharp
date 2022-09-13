/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем*/

int numberRead(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int[] ArrConsole(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = numberRead($"Введите числовой элемент массива под индексом {i}:\t");
    }
    return arr;
}


int[] array = ArrConsole(8);
Console.WriteLine(string.Join(", ", array));
