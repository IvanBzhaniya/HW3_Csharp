/*

Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

*/

Console.WriteLine("input number ");
int number = Convert.ToInt32(Console.ReadLine());;
int temp1 = number / 10000;
int temp2 = number / 1000 % 10;
int temp3 = number % 100 / 10;
int temp4 = number % 10;

if (number > 9999 && number < 100000)
{
    if (temp1 == temp4 && temp2 == temp3)
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
}
else
{
    Console.WriteLine("input 5-digit number");
}