/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

double[] array = CreateArray(new Random().Next(0, 10), -1000, 1000);

PrintArray(array);


double summ = 0;
double max = 0;
double min = 0;
double temp = 0;

for (int i=0; i < array.Length; i++)
{
    if (array[i] < array[i+1])
        temp = array[i];
        
    summ = max - min;
}

Console.WriteLine($"-> {summ}");






// Create random array

int[] CreateArray(int size, double min, double max)
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