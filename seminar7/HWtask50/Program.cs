/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет*/

string? stringNumberRead(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}


int[,] GetMatrix(int rowsCount = 5, int columnsCount = 7, int leftRange = -10, int ringhtRange = 10)
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


void GetElemMatrix(int[,] matrix)
{
    while (true)
    {
        string? rows = stringNumberRead("Введите координаты элемента матрицы");
        string? columns = stringNumberRead("Введите координаты элемента матрицы");
        if (rows == "стоп" || columns == "стоп")
        {
            Console.WriteLine($"Работа программы завершена пользователем");
            break;
        }
        try
        {
            int i = Convert.ToInt32(rows);
            int j = Convert.ToInt32(columns);
            if (i >= matrix.GetLength(0) || j >= matrix.GetLength(1))
            {
                Console.WriteLine($"Такого элемента в матрице нет");
                break;
            }
            else if (i > -1 && j > -1)
            {
                Console.WriteLine($"Элемент матрицы с координатами [{i}, {j}] {matrix[i, j]}");
                break;
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Введите числа больше -1 или 'стоп' для выхода.");
        }
    }
}


int[,] matr = GetMatrix();
PrintMatrix(matr, "Рандомный массив");
GetElemMatrix(matr);
