/* Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента или 
же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int m = 3;
int n = 4;
int[,] array = new int[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = (int) new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

int mInput, nInput;
System.Console.WriteLine("Input m");
int.TryParse(Console.ReadLine()!, out mInput);
System.Console.WriteLine("Input n");
int.TryParse(Console.ReadLine()!, out nInput);

try
{
    System.Console.WriteLine($"{array[mInput,nInput]}");
}
catch (System.Exception)
{
    System.Console.WriteLine("Out of range");
}