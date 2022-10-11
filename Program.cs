/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] array = CreateArray(new Random().Next(0, 10), -1000, 1000);

PrintArray(array);

int summ = 0;
for (int i=1; i < array.Length; i+=2)
{
    summ += array[i];
}

Console.WriteLine($"-> {summ}");


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