<<<<<<< HEAD
﻿Console.WriteLine("Hello, World!");
=======
﻿//1
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization.Formatters;

int[] recordBoocks = {1042,1058,1071,1093,1105};
int target = 107453531;
bool found = false;
foreach (int number in recordBoocks)
{
    if(number == target){
        found = true;
        break;
    }
}
Console.WriteLine(found ? "студент найден" : "студент не найден");

//2

int variant = 1;
bool isPrime = true;
if (variant < 2)
{
    isPrime = false;
}
else
{
    for (int divisor = 2; divisor < variant; divisor++)
    {
        if (variant % divisor == 0)
        {
            isPrime = false;
            break;
        }
    }
}
if (variant == 1)
{
     Console.WriteLine("Единица не считается ни простым, ни составным числом");
}
else
{
    Console.WriteLine(isPrime ? "Номер варианта простой" : "номер варианта составной"); }

//3
int[] pointsPerlab = { 8, -1, 10, 9, -1, 7 };
int sum = 0;
int sum1 = 0;
foreach (int points in pointsPerlab)
{
    if (points < 0)
    {
        sum += points;
        continue;
    }
    else if (points > 0)
    {
        sum1 += points;
        continue;
    }
}
Console.WriteLine($"сумма баллов за сданные работы:{sum}");
Console.WriteLine($"сколько работал было сдано:{sum1}");
>>>>>>> 6340d62785d8914120de1aebb5fb95ed7128bcae
