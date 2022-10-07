/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int N = 0;

System.Console.WriteLine("Input N");
int.TryParse(Console.ReadLine()!, out N);

void Sum(int _N)
{
    int res = 0;
    for (int i = 0; i < N; i++)
    {
        res += N % 10;
        N /= 10;
    }
    System.Console.WriteLine($"The summ of your number is {res}");
}
Sum(N);
