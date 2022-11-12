/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.*/

int SumOddPsition(int[] array)
{
    int SumOdd = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            SumOdd = SumOdd + array[i];
            i++;
        }
    }
    return SumOdd;
}

int[] array = new int [11];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10, 99);
    System.Console.Write(array[i] + " ");
}
int sum = SumOddPsition(array); 
System.Console.WriteLine();
System.Console.WriteLine("Сумма = " + sum);