// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(0,10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],2}    ");
        System.Console.WriteLine();
        }
}

void PrintArray2(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Сумма {i+1} строки: {array[i]} ");
    }
}

int [] SumRows (int [,] array)
{
    int[] sumRows = new int [array.GetLength(0)];
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        {
        sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sumRow += array[i,j];
        sumRows[i]=sumRow;
        }
    return sumRows;    
}

void MinSumRows (int [] sumRows)
{
    int minIndex = 0;
    for (int i = 0; i < sumRows.Length; i++)
    {
        if (sumRows[i]<sumRows[minIndex]) minIndex = i;
    }
    System.Console.WriteLine($"Строка с наименьшой суммой элементов: {minIndex+1}");
}

Console.Clear();
System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows, cols];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
PrintArray2(SumRows(array));
int[] sumRows = SumRows(array);
System.Console.WriteLine();
MinSumRows(sumRows);