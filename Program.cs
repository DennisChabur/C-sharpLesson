/* Task19 Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве */

Console.Clear();

int x1, y1, z1, x2, y2, z2;

System.Console.WriteLine("input x1");
int.TryParse(Console.ReadLine()!, out x1);
System.Console.WriteLine("input y1");
int.TryParse(Console.ReadLine()!, out y1);
System.Console.WriteLine("input z1");
int.TryParse(Console.ReadLine()!, out z1);
System.Console.WriteLine("input x2");
int.TryParse(Console.ReadLine()!, out x2);
System.Console.WriteLine("input y2");
int.TryParse(Console.ReadLine()!, out y2);
System.Console.WriteLine("input z2");
int.TryParse(Console.ReadLine()!, out z2);

double cube = Math.Pow((x1-x2), 2)+Math.Pow((y1-y2), 2)+Math.Pow((z1-z2), 2);
double L = Math.Sqrt(cube);
System.Console.WriteLine(L);