/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int M, N;
int.TryParse(Console.ReadLine()!, out M);
int.TryParse(Console.ReadLine()!, out N);

PrintNum(M, N);

Console.WriteLine($"{PrintNum(M,N)}");

int PrintNum(int m, int n)
{
    if (m == 0) return n+1;
    else if (n==0 && m>0) return PrintNum(m-1, 1);
    else return PrintNum(m-1, PrintNum(m,n-1));
}