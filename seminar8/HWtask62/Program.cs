/*Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7*/

int numberRead(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int[,] GetMatrix(int size)                                                //через ветвление, для любой размерности
{
    int[,] matrix = new int[size, size];
    int start = 1;
    int i = 0;
    int j = 0;
    while (start <= size * size)
    {
        matrix[i, j] = start;
        start++;
        if (i <= j + 1 && i + j < size - 1) j++;
        else if (i < j && i + j >= size - 1) i++;
        else if (i + j > size - 1 && i +j >= size - 1) j--;
        else if (i - 1 >= j && i + j <= size - 1) i--;
    }
    return matrix;
}


// int[,] GetMatrix(int size)                                               //через цикл, для любой размерности
// {
//     int[,] matrix = new int[size, size];
//     int start = 0;
//     for (int i = 0; i < size / 2; i++)
//     {
//         for (int j = 0; j + i < size - 1 - i; j++)
//         {
//             matrix[i, j + i] = start++;
//         }
//         for (int j = 0; j + i < size - 1 - i; j++)
//         {
//             matrix[i + j, size - 1 - i] = start++;
//         }
//         for (int j = 0; j + i < size - 1 - i; j++)
//         {
//             matrix[size - 1 - i, size - 1 - i - j] = start++;
//         }
//         for (int j = 0; j + i < size - 1 - i; j++)
//         {
//             matrix[size - 1 - i - j, i] = start++;
//         }
//     }
//     if (size % 2 != 0)
//     {
//         matrix[(size-1) / 2, (size-1) / 2] = start++;
//     }
//     return matrix;
// }


void PrintMatrix(int[,] matrix, string text = "")
{
    Console.WriteLine(text);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,5}", $"{matrix[i, j]} "));
        }
        Console.WriteLine();
    }
}


int n = numberRead("Введите размер сторон матрицы: ");
int[,] matr = GetMatrix(n);
PrintMatrix(matr, "Рандомный массив");
