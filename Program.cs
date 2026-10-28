
//1
using System.Security.Cryptography.X509Certificates;

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
        continue;
    }
    
   
        sum += points;
        sum1++;
    
}
Console.WriteLine($"сумма баллов за сданные работы:{sum}");
Console.WriteLine($"сколько работал было сдано:{sum1}");

//4
int[] id = { 101, 104, 107, 104, 110 };
bool has = false;
for(int i = 0; i < id.Length; i++)
{
    for (int j = i + 1; j < id.Length; j++)
    {
        if (id[i] == id[j])
        {
            has = true;
            Console.WriteLine($"найден дубликат:{id[i]} и {id[j]}");
            break;
        }
    }
}
if (has)
{
    Console.WriteLine("в массиве есть дубликат");
}
else
{
    Console.WriteLine("дубликата нет");
}
//самостоятельное задание В
int[] m = { 1, 2, 3, 4, 5, 6 };
int sum3 = 0;
foreach (int mb in m)
{
    if (mb % 2 == 0)
    {
        sum3 += mb;
        continue;
    }
}
Console.WriteLine($"сумма четных чисел:{sum3}");

//Г
int[] a = { 1, 2, 3, 4, 5, 4 };
bool ups = false;
for (int b = 0; b < a.Length; b++)
{
    for (int c = b + 1; c < a.Length; c++)
    {
        if (a[b] == a[c])
        {
            ups = true;
            break; 
        }
    }
}
if (ups)
{
    Console.WriteLine("в массиве есть дубликат");
}
else
{
    Console.WriteLine("дубликата нет");
}

//вариант 2
Console.WriteLine("Вводите число , для остановки нажмите 0");
while (true)
{
    int x = int.Parse(Console.ReadLine());
    if (x == 0)
    {
        break;
    }

    bool z = true;
    if (x < 2)
    {
        z = false;
    }
    else
    {
        for (int q = 2; q < x; q++)
        {
            if (x % q == 0)
            {
                z = false;
                break;
            }
        }
    }
    if (z)
    {
        Console.WriteLine($"{x} простое");
    }
    else
    {
        Console.WriteLine($"{x}составное");
    }
}

//5
for (int im = 1; im <= 100; im++)
{
    if (im % 2 == 0 && im % 3 == 0)
    {
        Console.WriteLine($"Найдено число: {im}");
        break; 
    }
}