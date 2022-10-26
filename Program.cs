/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int M, N;
int.TryParse(Console.ReadLine()!, out M);
int.TryParse(Console.ReadLine()!, out N);

int PrintSum(int M, int N, int sum=0)
{
    if (M>N) return 0;

    return M + PrintSum(M+1, N);

}
int Sum = PrintSum(M,N);
System.Console.WriteLine($"{Sum}");