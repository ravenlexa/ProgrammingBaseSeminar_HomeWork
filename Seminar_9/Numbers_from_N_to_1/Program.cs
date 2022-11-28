/*Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.*/

string NumbersRange(int M, int N)
{
    if (M <= N) 
    {
        return NumbersRange(M, N -1) + $"{N}, ";
    }
    else return String.Empty;
}
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NumbersRange(M, N));
