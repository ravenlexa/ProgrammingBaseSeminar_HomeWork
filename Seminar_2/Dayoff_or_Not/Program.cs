// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели и получите ответ - выходной или нет");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7 || number < 1)
{
    System.Console.WriteLine("Нет такого номера дня недели");
}
else
{
    if (number < 6 && number >0)
    {
        System.Console.WriteLine("Будни");
    }
    if (number <8 && number >5)
    {
        System.Console.WriteLine("Выходной");
    }
}