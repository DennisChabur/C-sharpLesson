/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */



int[,,] array = new int[2,2,2];




array1 = CreateArray(m1, n1);
// PrintArray(array1);
System.Console.WriteLine();

int m2 = 3, n2 = 3;
int[,] array2 = new int[m2, n2];
array2 = CreateArray(m2, n2);
// PrintArray(array2);
System.Console.WriteLine();

int[,] multiArray = new int[m1,n2];


Console.WriteLine();
for (int i = 0; i < m1; i++)
{
    for (int j = 0; j < n2; j++)
    {
        
        int sum = 0;
        for (int k = 0; k < n1; k++)
        {
            sum += array1[i,k]*array2[k,j];
        }
        multiArray[i,j] = sum;
    }
}

PrintArray(multiArray);


void PrintArray(int[,] _array)
{
    for (int i = 0; i < _array.GetLength(0); i++)
    {
        for (int j = 0; j < _array.GetLength(1); j++)
        {
            Console.Write($"{_array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}



int[,] CreateArray(int size_m, int size_n, int min = 0, int max = 10)
{
    int[,] _array = new int[size_m, size_n];
    for (int i = 0; i < _array.GetLength(0); i++)
    {
        for (int j = 0; j < _array.GetLength(1); j++)
        {
            _array[i, j] = new Random().Next(min, max);
            Console.Write($"{_array[i, j]} ");
        }
        Console.WriteLine();
    }
    return _array;
}