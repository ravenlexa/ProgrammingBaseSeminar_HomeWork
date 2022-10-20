// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int a1 = number % 100;
int a2 = a1 / 10;
if (number > 999 || number < 100)
{
    System.Console.WriteLine("Данное число не входит в диапозон условия задачи !");
}
else
{
    System.Console.WriteLine(a2);
}