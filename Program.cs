/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
using System;
using System.Collections.Generic;

int M;
bool stop = true;
List<int> i = new List<int>();
int num = 0;
while (stop)                                                   // Цикл, с флагом
    System.Console.WriteLine("Input your number");      // Просим пользователя ввести число
    int.TryParse(Console.ReadLine()!, out M);        // Если введенное можем перевести в int, то ...
    
    if (M)
    {
        if (M > 0) num += 1;                                   // Если М положительное, то счетчик +1
    }
    i.Add(M);                                            // В любом случае, добавляем значение М к списку
    else 
        stop = false;                                         // Но если введено не число, то stop = false, значит зикл завершается

System.Console.WriteLine($"-> {num}");                  // Выводим счетчик
