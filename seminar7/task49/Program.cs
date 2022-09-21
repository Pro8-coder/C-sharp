/*Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть
вот так:
1 4 7 2
5 81 2 9
8 4 2 4*/

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


void MatrixSquareEven(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
    }
}


void PrintMatrix(int[,] matrix, string text = "")
{
    Console.WriteLine(text);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}


int m = numberRead("Введите количество строк");
int n = numberRead("Введите количество столбцов");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr, "Рандомный массив");
MatrixSquareEven(matr);
PrintMatrix(matr, "Новый массив");
