/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] GetMatrix(int rowsCount = 5, int columnsCount = 7, int leftRange = 0, int ringhtRange = 10)
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


double[] ArithmeticMeanColumns(int[,] matrix)
{
    double[] arithmetic = new double[matrix.GetLength(1)];
    //int len = matrix.GetLength(0);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arithmetic[j] += matrix[i, j];
        }
    }
    for (int k = 0; k < matrix.GetLength(1); k++)
    {
        arithmetic[k] /= matrix.GetLength(0);
    }
    return arithmetic;
}


int[,] matr = GetMatrix();
PrintMatrix(matr, "Рандомный массив");
double[] arithmeticMeanColumns = ArithmeticMeanColumns(matr);
Console.WriteLine($"Среднее арифметическое элементов в каждом столбце: \n{string.Join(", ", arithmeticMeanColumns)}");
