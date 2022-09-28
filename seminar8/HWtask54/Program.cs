/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8*/

int numberRead(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 1, int ringhtRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, ringhtRange);
        }
    }
    return matrix;
}


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

int[,] SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] <= matrix[i, k])
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
    return matrix;
}


int m = numberRead("Введите количество строк");
int n = numberRead("Введите количество столбцов");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr, "Рандомный массив");
int[,] matrSort = SortMatrix(matr);
PrintMatrix(matrSort, "Упорядоченный массив");
