/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

// int[] GetArray(int size, int leftRange, int rightRange)
// {
//     int[] arr = new int[size];
//     Random rand = new Random();
//     for(int i = 0; i < size; i++)
//     {
//         arr[i] = rand.Next(leftRange, rightRange + 1);
//     }
//     return arr;
// }


int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
int[] arrNew = new int[(arr.Length + 1) / 2];
for (int i = 0; i < arrNew.Length; i++)
{
    arrNew[i] = arr[i] * arr[arr.Length - 1 - i];
}
if (arr.Length % 2 != 0)
{
    arrNew[arrNew.Length - 1] = arr[arr.Length / 2];
}
Console.Write(string.Join(", ", arrNew));
