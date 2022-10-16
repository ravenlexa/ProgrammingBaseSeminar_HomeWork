// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа, чтобы узнать максимальное:");
Console.Write("Введите 1 число - ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число - ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3 число - ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.Write("max = ");
Console.WriteLine(max);
