// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            Console.Write($"{array[i,j],3}    ");
        System.Console.WriteLine();
        }
}

void AverageCols (int [,] array)
{
    double average = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        {
            double sumCols = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                {
                    sumCols += array[i,j];                     
                }
            average = Math.Round(sumCols/(array.GetLength(0)),2);
            System.Console.Write($"{average,3}|   ");
        }       
}

Console.Clear();
System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows, cols];
FillArray(array);
PrintArray(array);
System.Console.WriteLine("Среднее арифметичское каждого столбца:");
AverageCols(array);