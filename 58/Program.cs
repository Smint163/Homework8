/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] array = new int[2,2];
int[,] arr = new int[2,2];

    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = new Random().Next(0, 10);
                    Console.Write($"{array[i, j]} ");
                }
            Console.WriteLine();      
        }
        
Console.WriteLine(); 

    for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = new Random().Next(0, 10);
                    Console.Write($"{arr[i, j]} ");
                }      
            Console.WriteLine();  
        }

Console.WriteLine();
Console.WriteLine("Результирующая матрица будет:");  

int[,] newArray = new int[2,2];

for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(0); k++)
                    {
                        newArray[i, j] += array[i, k] * arr[k, j];
                    }
                    Console.Write($"{newArray[i, j]} ");
                }
            Console.WriteLine();
        }