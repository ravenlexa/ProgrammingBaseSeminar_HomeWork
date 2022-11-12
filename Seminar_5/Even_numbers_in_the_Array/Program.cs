/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/
int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count ++;
        }
    }
    return count;
}

int[] array = new int [new Random().Next(5, 11)];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    System.Console.Write(array[i] + " ");
}
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных чисел в массиве = {EvenNumbers(array)}");
