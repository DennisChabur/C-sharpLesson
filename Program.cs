/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1,
y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double x;
double y;
double b1; 
double k1; 
double b2; 
double k2;

System.Console.WriteLine("Input b1");
double.TryParse(Console.ReadLine()!, out b1);
System.Console.WriteLine("Input k1");
double.TryParse(Console.ReadLine()!, out k1);
System.Console.WriteLine("Input b2");
double.TryParse(Console.ReadLine()!, out b2);
System.Console.WriteLine("Input k2");
double.TryParse(Console.ReadLine()!, out k2);

x = (b2-b1) / (k1-k2);
y = k1 * x + b1;

System.Console.WriteLine($"({x};{y})");