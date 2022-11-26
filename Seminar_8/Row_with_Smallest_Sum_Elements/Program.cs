/*Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.*/
int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

int SearchMinSumRow(int[,] array)
{
    int minSumRow = 0;
    int indexMinRow = 0;


    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSumRow = minSumRow + array[0, j];
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow = sumRow + array[i, j];
        }
        if (sumRow < minSumRow)
        {
            minSumRow = sumRow;
            indexMinRow = i;
        }
    }
    return indexMinRow;
}

Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
Console.WriteLine();
FillArray(array);
Console.WriteLine();
int minRow =  SearchMinSumRow(array);
System.Console.WriteLine("Строка номер : " + minRow);

