/*Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.*/

int numberRead(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = -10, int ringhtRange = 10)
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
            Console.Write(String.Format("{0,5:f1}", $"{matrix[i, j]} "));
        }
        Console.WriteLine();
    }
}


void SwapLineMatrix(int[,] matrix);
{
    int tempLine;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0)
            {
                tempLine = matrix[i,j];
                matrix[i,j] = matrix[matrix.GetLength(0) - i - 1, matrix.GetLength(1) - j - 1];
                matrix[matrix.GetLength(0) - i - 1, matrix.GetLength(1) - j - 1] = tempLine;
                Console.Write(String.Format("{0,5:f1}", $"{matrix[i, j]} "));
            }
            Console.WriteLine();
        }
    }
}


int m = numberRead("Введите количество строк");
int n = numberRead("Введите количество столбцов");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr, "Рандомный массив");
//int[,] newMatr = SwapLineMatrix(matr);
//PrintMatrix(matr, "Новый массив");
SwapLineMatrix(matr);
