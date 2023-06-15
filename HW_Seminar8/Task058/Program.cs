// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],2}    ");
        System.Console.WriteLine();
    }
}

void MultiArray(int[,] arrayA, int[,] arrayB, int [,] arrayC)
{
    arrayC[0,0]= arrayA[0,0]*arrayB[0,0] + arrayA[0,1]*arrayB[1,0];
    arrayC[0,1]= arrayA[0,0]*arrayB[0,1] + arrayA[0,1]*arrayB[1,1];
    arrayC[1,0]= arrayA[1,0]*arrayB[0,0] + arrayA[1,1]*arrayB[1,0];
    arrayC[1,1]= arrayA[1,0]*arrayB[0,1] + arrayA[1,1]*arrayB[1,1];

}

Console.Clear();
int[,] arrayA = new int[2, 2];
int[,] arrayB = new int[2, 2];
int[,] arrayC = new int[2, 2];
System.Console.WriteLine("Матрица А:");
FillArray(arrayA);
PrintArray(arrayA);
System.Console.WriteLine("Матрица B");
FillArray(arrayB);
PrintArray(arrayB);
System.Console.WriteLine("Матрица С - произведение матриц A и B:");
MultiArray(arrayA,arrayB,arrayC);
PrintArray(arrayC);
