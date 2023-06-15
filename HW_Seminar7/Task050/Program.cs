// Задача 50. Напишите программу, которая на вход принимает значение 
// элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(0,20);
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

void PrintArray2(int[] array)
{
    foreach (var item in array)
    {
        System.Console.Write($"{item}, ");
    }
}

int [] SearchNum (int [,] array, int num)
{
    // System.Console.WriteLine("Введите искомое число");
    // int num = Convert.ToInt32(Console.ReadLine());
    int [] arrayI= new int [2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j]==num)
                {
                    arrayI[0]=i;
                    arrayI[1]=j;
                }
        }
    }
    System.Console.WriteLine("Идекс искомого числа: ");
    return arrayI;
}

bool FindNum (int [,] array, int num)
{
    bool find = false;
    foreach (var item in array)
    {
        if (item == num)
            find = true;
    }
    return find;
}

Console.Clear();
System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows, cols];

FillArray(array);
PrintArray(array);
System.Console.WriteLine("Введите искомое число");
int num = Convert.ToInt32(Console.ReadLine());
if (FindNum(array, num))
{
    PrintArray2(SearchNum(array,num));
}
else System.Console.WriteLine("Этого числа нет в массиве");


