// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Input your XXX number plz");
int thirdNumberInput = Convert.ToInt32(Console.ReadLine()) / 100;
// if (thirdNumberInput == 0);
// {
//     System.Console.WriteLine("There is no 3rd number");
// }
if (thirdNumberInput == 0)
{
    System.Console.WriteLine("There's no 3rd number");
}
else
{
    System.Console.WriteLine("3rd number is " + thirdNumberInput);
}