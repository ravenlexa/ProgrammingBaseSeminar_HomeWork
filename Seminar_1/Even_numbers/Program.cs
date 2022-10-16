// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите чило N, чтобы узнать все четные числа от 1 до N:");
Console.Write("Введите число - ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count < a)
{
    if (count % 2==0)
    {
       Console.WriteLine(count);
       count++;
    } 
    else
    {
        count++;
    }
}