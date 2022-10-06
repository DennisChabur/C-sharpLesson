/* Task23 Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N */

Console.Clear();
int N;
System.Console.WriteLine("Input number of cubes");
int.TryParse(System.Console.ReadLine()!, out N);

for (int i = 1; i <= N; i++)
{
    System.Console.Write($"{Math.Pow(i, 3)}");
    if (i < N)
    {System.Console.Write(", ");}
    else
    {continue;}
}