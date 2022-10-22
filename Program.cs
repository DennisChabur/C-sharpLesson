/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int M, N;
int.TryParse(Console.ReadLine()!, out M);
int.TryParse(Console.ReadLine()!, out N);

void PrintSum(int m, int n, int sum=0)
{
    sum = sum + m;
    if (m <= n) Console.Write($" {sum} ");
    PrintSum(m+1, n, sum);

}