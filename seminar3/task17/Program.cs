//Задача 17: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координату точки по x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки по y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой координатной четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится в второй координатной четверти");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей координатной четверти");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвертой координатной четверти");
}
else
{
    Console.WriteLine("Введена нулевая координата по X и/или Y");
}
