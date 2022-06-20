﻿///Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


using System;
using static System.Console;
Clear();

Write("Введите число N: ");
int numberN = int.Parse(ReadLine());

int count = 1;

while (count < numberN)
{
    Write($"{Math.Pow(count,3)}, ");
    count++;
}

Write($"{Math.Pow(count,3)}");