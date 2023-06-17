﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                array[i, j, k] = new Random().Next(10, 100);
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k],3}  {(i, j, k)}  ");
                System.Console.WriteLine();
            }
        }
    }
}

Console.Clear();
System.Console.WriteLine("Введите количество строк");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int y = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество рядов");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int[x, y, z];
FillArray(array);
PrintArray(array);