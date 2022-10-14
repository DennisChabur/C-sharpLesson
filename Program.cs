/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int m = 4, n = 5;
int[,] array = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

System.Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int j2 = 1; j2 < n-j; j2++)
        {
            if (array[i,j2-1] > array[i,j2])
            {
                int temp = array[i,j2];
                array[i, j2] = array[i,j2-1];
                array[i,j2-1] = temp;
            }
        }
        System.Console.Write($"{array[i, j]} ");
    }
    System.Console.WriteLine();
}