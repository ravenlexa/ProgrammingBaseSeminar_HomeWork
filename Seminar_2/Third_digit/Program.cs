Console.WriteLine("Введите число и я укажу третью цифру слева");
int number = Convert.ToInt32(Console.ReadLine());
int a1 = 10;
if (number < 100)
{
    System.Console.WriteLine("Нет третьей цифры");
}
else
{    while (number > 1000)
    {
        number = number / a1;
    }
    int a2 = number % 10;
    System.Console.WriteLine(a2);
}
//if (number < 100) System.Console.WriteLine("Нет");
