﻿/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int m = 4, n = 5; 
int[,] array = new int[m, n];  
for (int i = 0; i < m; i++) 
{     
    for (int j = 0; j < n; j++)     
    {         
        array[i, j] = new Random().Next(10);         
        Console.Write($"{array[i, j]} ");     
    }     Console.WriteLine(); 
} 

for (int j = 0; j < n; j++)
{
    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum += array[i,j];
    }
    System.Console.Write($"The average of summarize of {j} colomn is {(double)sum/m}\n");
}