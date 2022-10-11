﻿/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] array = CreateArray(new Random().Next(20), 100, 1000);

PrintArray(array);

int count = 0;
for (int i=0; i < array.Length; i++)
{
    if (array[i] % 2 ==0)
        count ++;
}

Console.WriteLine($"-> {count}");


// Create random array

int[] CreateArray(int size, int min, int max)
{
    int[] _array = new int[size];
    for (int i = 0; i < size; i++)
        _array[i] = new Random().Next(min, max);
    return _array;
}

void PrintArray(int[] _array)
{
    System.Console.Write("[");
    foreach (var item in _array)
        System.Console.Write($"{item} ");
    System.Console.Write("]");
    System.Console.WriteLine();
}