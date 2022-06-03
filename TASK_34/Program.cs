﻿/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/



void FillArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(100, 1000);
    }
}

int FindEvenNumberOfArray(int[] array2)
{
    int result = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        if (array2[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

void PrintArray(int[] array3)
{
    Console.Write("[");
    for (int i = 0; i < array3.Length; i++)
    {
        Console.Write(array3[i]);
        if(i != array3.Length-1)
        {
            Console.Write(", ");
        }
        
    }
    Console.Write("] -> ");
}

int[]array = new int[4];
FillArray(array);
PrintArray(array);
int result = FindEvenNumberOfArray(array);
Console.Write($"{result}");

