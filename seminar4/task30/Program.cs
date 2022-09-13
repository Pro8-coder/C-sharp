/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

int[] arr = new int[8];
int n = arr.Length;
Random rnd = new Random();
for (int i = 0; i < n; i++)
{
    arr[i] = rnd.Next(0, 2);
}
Console.WriteLine(string.Join(", ", arr));

//foreach (int el in arr)
// {
//   Console.Write(el);
// }
