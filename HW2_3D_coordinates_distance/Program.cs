﻿// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// d = √(xb - xa)^2 + (yb - ya)^2 + (za - zb)^2

Console.Clear();

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = 0;
    result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return result;
}

Console.WriteLine("Введите координату Х1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z1");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Х2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z2");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Distance(x1, y1, z1, x2, y2, z2),2);
Console.WriteLine($"{result}");