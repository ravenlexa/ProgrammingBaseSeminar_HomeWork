/*Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.*/
// Вытаскивает первые две и последние две цифры и сравнивает их между собой.
void PrintPolindromToConsole(int n)
{
    int n1 = n % 10;
    int n2 = n / 10 % 10;
    int n4 = n / 1000 % 10;
    int n5 = n / 10000 % 10;
    if (n < 10000 || n > 99999)
    {
        System.Console.WriteLine("Число не подходит");
    }
    else
    {
        if (n1 == n5 && n2 == n4)
        {
            System.Console.WriteLine("Палиндром");
        }
        else
        {
            System.Console.WriteLine("Не палиндром");
        }
    }  
}
System.Console.Write( "Введите пятизначное число и я скажу палиндром оно или нет: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintPolindromToConsole(number);



