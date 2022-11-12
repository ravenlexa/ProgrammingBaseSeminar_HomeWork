/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.*/

double DifferenceMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= max)
        {
            max = array[i];
        }
        else if (array[i] <= min)
        {
            min = array[i];
        }
    }
    System.Console.WriteLine("Максимальное число = " + max);
    System.Console.WriteLine("Минимальное число = " + min);
    diff = max - min;
    return diff;
}

double[] array = new double[7] {5.44, 4.8, 45.5, 87.4, 56.5, 101.5, 45.6};
System.Console.WriteLine("Разница между максимальным и минимальным чилом = " + DifferenceMaxMin(array));


