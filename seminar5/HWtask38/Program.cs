/*Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}


int DifferenceMaxMin(int[] arr)
{
    int min = arr[0];
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
        }
        else if (max < arr[i])
        {
            max = arr[i];
        }
    }
    return (max - min);
}


int[] array = GetArray(5, 1, 99);
int diff = DifferenceMaxMin(array);
Console.WriteLine($"{diff} разница между мин и макс массива: \n{string.Join(", ", array)}");
