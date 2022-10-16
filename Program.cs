/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */



int m1 = 2, n1 = 3;
int[,] array1 = new int[m1, n1];
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