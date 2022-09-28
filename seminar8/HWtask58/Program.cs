/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49*/

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


int[,] MultiplicationTwoMatrices(int[,] matrix1, int[,] matrix2)
{
    int[,] NewMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            NewMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    return NewMatrix;
}


int m = numberRead("Введите количество строк");
int n = numberRead("Введите количество столбцов");
int[,] matr1 = GetMatrix(m, n);
PrintMatrix(matr1, "Рандомный массив 1");
int[,] matr2 = GetMatrix(m, n);
PrintMatrix(matr2, "Рандомный массив 2");
int[,] matrNew = MultiplicationTwoMatrices(matr1, matr2);
PrintMatrix(matrNew, "Произведением этих матриц будет матрица: ");
