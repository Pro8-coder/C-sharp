/*Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7*/

int numberRead(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int ringhtRange = 9)
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


(int, int, int) MinElemRowsColumnsMatrix(int[,] matrix)
{
    int min = matrix[0, 0];
    int rowsMin = 0;
    int columnsMin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
                rowsMin = i;
                columnsMin = j;
            }
        }
    }
    return (min, rowsMin, columnsMin);
}


int[,] DelRowsColumnsMinElemMatrix(int[,] matrix, int minElem = 0, int rowsMin = 0, int columnsMin = 0)
{
    int[,] matrixNew = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int rowNext = 0;
    int columnNext = 0;
    for (int i = 0; i < matrixNew.GetLength(0); i++)
    {
        if (i == rowsMin) rowNext++;
        for (int j = 0; j < matrixNew.GetLength(1); j++)
        {
            if (j == columnsMin) columnNext++;
            matrixNew[i, j] = matrix[i + rowNext, j + columnNext];
        }
        columnNext = 0;
    }
    return matrixNew;
}


int m = numberRead("Введите количество строк");
int n = numberRead("Введите количество столбцов");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr, "Рандомный массив");
var (minElem, rowsMin, columnsMin) = MinElemRowsColumnsMatrix(matr);
Console.WriteLine($"{minElem} [{rowsMin}, {columnsMin}]");
int[,] matrNew = DelRowsColumnsMinElemMatrix(matr, minElem, rowsMin, columnsMin);
PrintMatrix(matrNew, "Новый массив");
