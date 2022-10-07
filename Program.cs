/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int A = 0, B = 0;

System.Console.WriteLine("Input A");
int.TryParse(Console.ReadLine()!, out A);
System.Console.WriteLine("Input B");
int.TryParse(Console.ReadLine()!, out B);

void Power(int A, int B)
{
    int pow = 1;
    for (int i = 0; i < B; i++)
    {
        pow *= A;
    }
    System.Console.WriteLine($"The number you are looking for is {pow}");
}
Power(A, B);
