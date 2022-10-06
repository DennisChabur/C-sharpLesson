// Task19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.Clear();
string a = Console.ReadLine();

// int i = 0, j = 4;
// bool flag = true;
// while( i != j)
// {
//     if (a[i] == a[j])
//     {
//         continue;
//     }
//     else
//     {
//         flag = false;
//     }
// }
// if (flag)
// {
//     System.Console.WriteLine("It's a palindrome");
// }
// else
// {
//     System.Console.WriteLine("It's not a palindrome");
// }

if (a[0] == a[4] && a[1] == a[3])
{
    System.Console.WriteLine("Yes");
}
else
{
    System.Console.WriteLine("No");
}