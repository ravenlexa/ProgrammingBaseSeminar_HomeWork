/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. */
// Выдает таблицу кубов чисел от 1 до N.
void PrintCubsToConsole(int n)
{
    if (n >= 1)
    {    
        for (int i = 1; i <= n; i++)
        {
            System.Console.WriteLine(i * i * i);
        }
    }
    else
    {
        System.Console.WriteLine("Введи число согласно условию задачи");
    }    
}
System.Console.Write( "Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintCubsToConsole(number);