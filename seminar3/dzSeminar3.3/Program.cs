///Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


using System;
using static System.Console;
Clear();

Write("Введите число N: ");
int numberN = Convert.ToInt32(ReadLine());

for (int count=1; count<=numberN; count++)
{
    WriteLine($"{Math.Pow(count,3)}");
}
WriteLine("Finish!"); //Как вы говорили на семинаре, из тела уже переменную не выдернуть поэтому избавится от запятай не могу. Вывел в столбик.)))