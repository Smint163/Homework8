/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] array = new int[4,4];

    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = new Random().Next(1, 17);
                }
        }

    for (int i = 0; i < array.GetLength(0); i++)
        {
        
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    int max = j;
                    for (int a = j+1; a < array.GetLength(1); a++)
                    {
                        if(array[i,a] > array[i,max])
                        {
                            array[i,j] = new Random().Next(1, 17);
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
