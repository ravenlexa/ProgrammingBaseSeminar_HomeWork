/*Напишите программу, которая будет принимать от пользователя позицию (M, N) 
двумерного массива и возвращать значение элемента, стоящего в этой позиции. 
Если такой позиции в массиве нет, то сообщить об этом пользователю. 
Сгенерировать массив случайным образом. 
Размерность массива определить самостоятельно. 
Использование методов для заполнения массива обязательно. 
Остальное можно реализовать в главной программе.*/
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

int ReturnValue(int[,] array, int m, int n)
{
    int value = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == m && j == n)
            {
                value = array[i, j];
            }
        }
    }    
    return value;
}

Console.WriteLine("Введите позицию числа в строку: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите позицию числа столбце: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[4, 4];

Console.WriteLine();

if (m > 3 || n > 3)
{
    Console.WriteLine("Нет такой позиции!!!");
}
else
{
    FillArray(array);
    Console.WriteLine();

    int vaiue = ReturnValue(array, m, n); // Если это вытащить за рамки else,
    Console.WriteLine(vaiue);             // то даже при не верно узанной позиции все равно печатается 0.
}



