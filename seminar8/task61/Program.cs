/*Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника*/

int numberRead(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


void Pascal(int N)
{
    int[][] arr = new int[N][];
    arr[0] = new int[] { 1 };
    Console.WriteLine("{0,5}", arr[0][0]);
    for (int i = 1; i < N; i++)
    {
        arr[i] = new int[i + 1];
        for (int j = 0; j <= i; j++)
        {
            if (j == 0 || j == i)
            {
                arr[i][j] = 1;
                Console.Write("{0,5}", arr[i][j]);
            }
            else
            {
                arr[i][j] = arr[i - 1][j - 1] + arr[i - 1][j];
                Console.Write("{0,5}", arr[i][j]);
            }
        }
        Console.WriteLine();
    }
}


int N = numberRead("Введите количество столбцов");
Pascal(N);

