/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
Ввод чисел останавливается при помощи ввода стоп-слова "stop"
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int count = 0;
while (true)
{
    Console.WriteLine("Введите элемент: ");
    string? num = Console.ReadLine();
    if (num == "stop") break;
    try
    {
        int number = Convert.ToInt32(num);
        if (number > 0) count++;
    }
    catch (Exception)
    {
        Console.WriteLine("Вы ввели не число.");
    }
}
Console.WriteLine($"Введено чисел больше нуля: {count}");
