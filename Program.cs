/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
using System;
using System.Collections.Generic;

System.Console.WriteLine("Input numbers of inputed numbers");
int Num;
int.TryParse(Console.ReadLine()!, out Num);
int count = 0;
// int i = 0;
List<int> list = new List<int>();
for ( int i = 0; i < Num; i++)
{
    System.Console.WriteLine("Input number");
    int numInput;
    int.TryParse(Console.ReadLine()!, out numInput);
    if (numInput > 0)   count += 1;
    list.Add(numInput);
    // i ++;
}
foreach (var item in list)
    System.Console.Write($"{item} ");
System.Console.WriteLine($" -> {count}");