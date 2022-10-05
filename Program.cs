// Задача 15.  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.WriteLine("Input a number of a day of the week plz");
int dayNumberInput = Convert.ToInt32(Console.ReadLine());

if (dayNumberInput == 6 || dayNumberInput == 7)
{
    System.Console.WriteLine("Yeeeeees. It's holyday man");
}
else if (dayNumberInput >= 1 && dayNumberInput <= 3 )
{
    System.Console.WriteLine("Nope. It's not even tuesday. Keep on work and suffer");
}
else if (dayNumberInput >= 4 && dayNumberInput <= 5)
{
    System.Console.WriteLine("Nope. But it's the end of the week actually. Cheer up and prepare a beer bro.");
}