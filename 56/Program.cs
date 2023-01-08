/*
Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:
1 строка
*/

int[,] array = new int[4,4];

    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = new Random().Next(0, 10);
                    Console.Write($"{array[i, j]} ");
                }
            Console.WriteLine();   
        }

int summ = 0;
int min = 0;
int str = 0;

    for (int i = 0; i < array.GetLength(0); i++)
        {
            summ = 0;
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    summ = array[i,j] + summ;
                }
            if (i == 0)
                {
                    min = summ;
                }
            else if (summ < min)
                {
                    min = summ;
                    str = i;
                }
        }

Console.WriteLine($"Строка с наименьшей суммой элементов: {str+1}");