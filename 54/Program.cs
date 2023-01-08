/*
Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] array = new int[3,4];

    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = new Random().Next(0, 10);
                    Console.Write($"{array[i, j]} ");
                }
            Console.WriteLine();   
        }

Console.WriteLine("Массив по убыванию:");  

    for (int i = 0; i < array.GetLength(0); i++)
        {
        
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    int max = j;
                    for (int a = j+1; a < array.GetLength(1); a++)
                    {
                        if(array[i,a] > array[i,max])
                        {
                            max = a;
                        }
                    }
                    int temp = array[i,j];
                    array[i,j] = array[i,max];
                    array[i,max] = temp;
                    Console.Write($"{array[i,j]} ");
                }

            Console.WriteLine();  
        }