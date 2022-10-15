/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
наибольшей суммой элементов. */



int m = 4, n = 5;
int[,] array = new int[m, n];
array = CreateArray(m, n);
int[] sumArray = new int[m];

Console.WriteLine();
for (int i = 0; i < m; i++)
{
    int[] sum = new int[m];
    for (int j = 0; j < n; j++)
    {
        sum[i] += array[i, j];
    }
    Console.Write($"| {sum[i]} |");
    sumArray[i] = sum[i];
}

    int max = sumArray[0];
    int l=0;
for (int i = 1; i < m; i++)
{

    if (sumArray[i] > max)
    {
        max = sumArray[i];
        l = i;
    }
    
}
Console.Write($"The max sum is {max} im {l} line");

















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