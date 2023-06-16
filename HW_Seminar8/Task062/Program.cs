// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillArray(int[,] array, int n)
{
    int value=1;
    int minRow=0, maxRow=n-1,
        minCol=0, maxCol=n-1;
    while (value<=n*n)
    {
        for (int j = minCol; j <= maxCol; j++)
        {
            array[minRow, j] = value;
            value++;
        }
        minRow++;
        for (int i = minRow; i <= maxRow; i++)
        {
            array[i, maxCol] = value;
            value++;
        }
        maxCol--;
        for (int j = maxCol; j >= minCol ; j--)
        {
            array[maxRow, j] = value;
            value++;
        }
        maxRow--;
        for (int i = maxRow; i >= minRow ; i--)
        {
            array[i, minCol] = value;
            value++;
        }
        minCol++;
    }
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

Console.Clear();
System.Console.WriteLine("Введите число чтоб заполнить массив спиралью");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, n];
FillArray(array, n);
PrintArray(array);