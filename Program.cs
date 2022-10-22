/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int M, N;
int.TryParse(Console.ReadLine()!, out M);
int.TryParse(Console.ReadLine()!, out N);

PrintNum(M, N);

Console.WriteLine($"{PrintNum(M,N)}");

int PrintNum(int start, int end)
{
    if (start <= end) 
    {
        int sum = 0;
        sum += PrintNum(start+1, end);
        return sum;
    }
}