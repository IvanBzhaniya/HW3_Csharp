/*

Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.



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


Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.



double LongLineABC (int xA, int xB, int yA, int yB, int zA, int zB)
{
    double longLine = Math.Sqrt((xB - xA)*(xB - xA) + (yB - yA)*(yB - yA) + (zB - zA)*(zB - zA));
    longLine = Math.Round(longLine, 2);
    return longLine;
}

Console.WriteLine("input X ccord of A ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input Y ccord of A ");
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input Z ccord of A ");
int zCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input X ccord of B ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input X ccord of B ");
int yCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input Z ccord of B ");
int zCoordB = Convert.ToInt32(Console.ReadLine());

double dist = LongLineABC(xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB);
Console.WriteLine($"distance between A({xCoordA} + {yCoordA} + {zCoordA}) and B({xCoordB} + {yCoordB} + {zCoordB}) is {dist}");


Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

*/

void SqurePrinter(int numberN)
{
        int current = 1;
        while (current <= numberN)
        {
                double res = Math.Pow(current,3);
                Console.Write($"{res:f0}, ");
                current++;
        }
        Console.WriteLine("\b\b.");
}
void SqurePrinterNeg(int numberN)
{
        int current = 1;
        while (current >= numberN)
        {
                double res = Math.Pow(current,3);
                Console.Write($"{res:f0}, ");
                current--;
        }
        Console.WriteLine("\b\b.");
}

Console.Write("Input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number > 0)
        SqurePrinter(user_number);
else
        SqurePrinterNeg(user_number);