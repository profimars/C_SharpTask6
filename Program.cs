//Задача 6
//Напишите программу, которая на вход принимает число, и выдает является ли оно четным
Console.WriteLine("Введите целое число");
int d = Convert.ToInt32(Console.ReadLine());
if (d % 2 == 0)
{
    Console.WriteLine("Это число четное");
}
else
{
    Console.WriteLine("Это число не четное");
}
