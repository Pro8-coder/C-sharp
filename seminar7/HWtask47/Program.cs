/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

int numberRead(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


double[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = -100, int ringhtRange = 100)
{
    double[,] matrix = new double[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(rand.Next(leftRange, ringhtRange) / 10.0);
        }
    }
    return matrix;
}


void PrintMatrix(double[,] matrix, string text = "")
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


int m = numberRead("Введите количество строк");
int n = numberRead("Введите количество столбцов");
double[,] matr = GetMatrix(m, n);
PrintMatrix(matr, "Рандомный массив");
