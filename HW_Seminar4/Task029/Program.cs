// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void Massiv(int[] Array)
{
    Console.WriteLine("Введите числа:");
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"Число {i + 1}: ");
        Array[i] = Convert.ToInt32(Console.ReadLine());
        
    }
     System.Console.WriteLine(String.Join(" ", Array));
}
Console.Clear();
int[] Array = new int[8];
Massiv(Array);

// Console.Clear();
// int[] Array = new int[8];
// Console.WriteLine("Введите числа:");
// for (int i = 0; i < 8; i++)
// {
//     Console.Write($"Число {i + 1}: ");
//     Array[i] = Convert.ToInt32(Console.ReadLine());
// }
// System.Console.WriteLine(String.Join(" ", Array));