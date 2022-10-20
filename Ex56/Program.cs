﻿// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] matrix = new int[4,3];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int a = 0;
int[] res = new int[matrix.GetLength(0)];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
    }

    Console.WriteLine($"Сумма в строке № {i + 1} равна {sum}");
    res[a] = sum;
    a++;
}

for(int m = 0; m < res.Length; m++)
{
    Console.Write(res[m] + " ");
}
Console.WriteLine();
int min = res[0];
int index = 0;
for(int n = 0; n < res.Length; n++)
{
    if (min >= res[n])
    {
        min = res[n];
        index = n;        
    }
}
Console.Write($"Наименьшая сумма в строке {index + 1} ");