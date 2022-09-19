/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.*/

int numberRead(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


bool TriangleInequalityTheorem(int number1, int number2, int number3)
{
    bool theorem = false;
    if (number1 + number2 > number3 && number1 + number3 > number2 && number2 + number3 > number1)
    {
        theorem = true;
    }
    return theorem;
}


int num1 = numberRead("Введите первое число: ");
int num2 = numberRead("Введите второе число: ");
int num3 = numberRead("Введите третье число: ");
bool triang = TriangleInequalityTheorem(num1, num2, num3);
if (triang == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
