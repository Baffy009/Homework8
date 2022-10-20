// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] matrix1 = new int[2, 2];

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix1[i, j] = new Random().Next(0, 10);
        Console.Write($"{matrix1[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();


int[,] matrix2 = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

for (int m = 0; m < matrix2.GetLength(0); m++)
{
    for (int n = 0; n < matrix2.GetLength(1); n++)
    {
        matrix2[m, n] = new Random().Next(0, 10);
        Console.Write($"{matrix2[m, n]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[,] resultMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

for (int x = 0; x < matrix1.GetLength(0); x++)
{
    for (int y = 0; y < matrix1.GetLength(1); y++)
    {
        resultMatrix[x, y] = matrix1[x,y] * matrix2[x,y];
        Console.Write($"{resultMatrix[x, y]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
