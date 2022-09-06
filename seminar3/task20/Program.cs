/*Задача 20: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21*/

Console.WriteLine("Введите координату точки A по x: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки A по y: ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки B по x: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки B по y: ");
int By = Convert.ToInt32(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow((Bx - Ax), 2) + Math.Pow((By - Ay), 2));
Console.WriteLine($"{AB:f2}");
