/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int[] array = CreateArray(new Random().Next(0, 10), -1000, 1000);

PrintArray(array);


int summ = 0;
int max = array[0];
int min = array[0];

for (int i=0; i < array.Length; i++)
{
    if (array[i] > max)
        max = array[i];
    else if (array[i] < min)
        min = array[i];
    else continue;
}      
summ = max - min;
Console.WriteLine($"{max} - {min} = {summ}");
Console.WriteLine($"-> {summ}");






// Create random array

int[] CreateArray( int size, int min, int max)
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