//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

using System;
using static System.Console;
Clear();

Write("Введите координаты x1: ");
int x1 = int.Parse(ReadLine());

Write("Введите координаты y1: ");
int y1 = int.Parse(ReadLine());

Write("Введите координаты c1: ");
int c1 = int.Parse(ReadLine());

Write("Введите координаты x2: ");
int x2 = int.Parse(ReadLine());

Write("Введите координаты y2: ");
int y2 = int.Parse(ReadLine());

Write("Введите координаты c2: ");
int c2 = int.Parse(ReadLine());

double x = Math.Pow(x1-x2,2);
double y = Math.Pow(y1-y2,2);
double c = Math.Pow(c1-c2,2);

double distance = Math.Sqrt(x + y + c);
WriteLine($"Растояние равно: {distance:f2}");
