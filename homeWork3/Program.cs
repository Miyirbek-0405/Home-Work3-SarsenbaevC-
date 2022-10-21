
// ====================================start=====================================================
// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*
Console.Write("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
void Polindrom(int num)
{
    if (num / 10000 == num % 10 & num / 1000 % 10 == num % 100 / 10)
    {
        Console.WriteLine("Полиндром");
    }
    else
    {
        Console.WriteLine("Не полиндром");
    }
}
Polindrom(a);
*/

// ===================================================end==============================================

// ===================================================start==============================================

// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*
Console.Write("Введите х1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z1: ");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите х2: ");
int n4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
int n5 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z2: ");
int n6 = Convert.ToInt32(Console.ReadLine());
double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dis = Math.Round(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)), 2);
    return dis;
}
double result = Distance(n1, n2, n3, n4, n5, n6);
Console.WriteLine($"расстояние между ({n1}, {n2}, {n3}) и ({n4}, {n5}, {n6}) точками равно: {result}");
*/

// ===================================================end==============================================

// ===================================================start==============================================

// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
void Kub(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write($"{i * i * i} ");
    }
}
Kub(number);

// ===================================================end==============================================