﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int numCub;
int index = 1;
while (index <= number)
{
    numCub = (int)(Math.Pow((double) index, (double) 3));
        Console.WriteLine($"Куб числа {index} -> {numCub}");
    index++;
}

