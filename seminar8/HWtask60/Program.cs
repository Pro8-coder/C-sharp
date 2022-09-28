/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)*/

(int, int, int) numberRead(string message1, string message2, string message3)
{
    while (true)
    {
        try
        {
            Console.WriteLine("Стороны многомерного массива 3го порядка, состоящего из двузначных чисел, суммарно не должны превышать 13.");
            Console.WriteLine(message1);
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(message2);
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(message3);
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 + num2 + num3 < 14 && 0 < num1 + num2 + num3)
            {
                return (num1, num2, num3);
            }
        }
        catch (Exception) { }
    }
}





int[,,] GetMatrix(int heightMatrix, int longMatrix, int depthMatrix, int leftRange = 10, int ringhtRange = 100)
{
    int[] arr = new int[heightMatrix * longMatrix * depthMatrix];
    Random rand = new Random();
    for (int n = 0; n < heightMatrix * longMatrix * depthMatrix; n++)
    {
        int temp = rand.Next(leftRange, ringhtRange);
        if (arr.Contains(temp)) n--;
        else arr[n] = temp;
    }

    int[,,] matrix = new int[heightMatrix, longMatrix, depthMatrix];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = arr[count];
                count++;
            }
        }
    }
    return matrix;
}


void PrintMatrix(int[,,] matrix, string text = "")
{
    Console.WriteLine(text);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(String.Format("{0,5}", $"{matrix[i, j, k]}({i},{j},{k}) "));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}



var (z, y, x) = numberRead("Введите глубину массива по z: ", "Введите высоту массива по y: ", "Введите ширину массива по x: ");
int[,,] matr = GetMatrix(z, y, x);
PrintMatrix(matr, "Рандомный массив");
