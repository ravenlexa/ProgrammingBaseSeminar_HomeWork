/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.*/
int[,,] CreateArray3d (int [,,] array) 
{
	    int numbers = 10;
	
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            for (int k = 0; k < array.GetLength(2); k++)
	            {
	                array[i, j, k] = numbers;
	                numbers++;
	            }
	        }
	    }
	return array;
}    

 
void PrintArray3d(int[,,] array)
{
    for (int i = 0; i <  array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
            Console.Write($"{array[i, j, k], 1} ({i} {j} {k}) | ");            
            }
        }    
    }        
}

Console.WriteLine(); 
int[,,] array3D = new int [3,3,2];
CreateArray3d(array3D);
PrintArray3d(array3D);

