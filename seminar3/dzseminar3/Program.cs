//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

using System;
using static System.Console;
Clear();

Write("Введите пятизначное число: ");
string? number = Console.ReadLine();

    if (number[0]==number[4] || number[1]==number[3])
    {
        WriteLine($"Число палиндром: {number}");
    }

    else WriteLine($"Число *{number}* Не палиндром!");