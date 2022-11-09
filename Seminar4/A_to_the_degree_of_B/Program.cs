/*Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Для решения задания использование цикла for является обязательным условием. 
Не использовать встроенный метод возведения в степень.*/

int Exponentiation(int number1, int number2)
{
    number2 = Math.Abs(number2);
    int exponentiation = 1;
    for (int i = 1; i <= number2; i++)
    {
        exponentiation = exponentiation * number1;

    }
    return exponentiation;
}
System.Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int exponentiation = Exponentiation(numberA, numberB);
System.Console.WriteLine($"{numberA} в степени {Math.Abs(numberB)} = {exponentiation}");
