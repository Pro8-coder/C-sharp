/*Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольный*/

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


// int MatrixSumMainDiagonal(int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum += matrix[i, j];
//             }
//         }
//     }
//     return sum;
// }


int MatrixSumMainDiagonal(int[,] matrix)
{
    int sum = 0;
    if (matrix.GetLength(0) >= matrix.GetLength(1))
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            sum += matrix[i, i];
        }
    }
    else
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, i];
        }
    }
    return sum;
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
int sum = MatrixSumMainDiagonal(matr);
Console.WriteLine($"Сумма элементов главной диагонали = {sum}");
