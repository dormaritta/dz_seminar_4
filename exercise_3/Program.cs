﻿/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int[] array = new int[8];
Random RandomArray = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = RandomArray.Next(0, 8);
        Console.Write("{0} ", array[i]);
    }
