/*Запросите от пользователя размерности двумерного массива. 
Напишите метод для заполнения массива случайными числами. 
Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво). 
Округлите значения, генерируемые Random до двух знаков после запятой.*/
double[,] DoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 10;
            //Console.Write("{0,6:F2}", array[i, j]); // Это тоже работает
            Console.Write(Math.Round(array[i, j], 2) + " | ");
        }
        Console.WriteLine();
    }
    return array;
}

Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
Console.WriteLine();
DoubleArray(array);
