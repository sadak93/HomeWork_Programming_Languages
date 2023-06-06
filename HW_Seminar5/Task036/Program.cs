// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(0,100);
    }
}

void PrintArray (int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

void Summ (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2==1)
            sum = sum + array[i];
    }
    System.Console.WriteLine($"Сумма значений с нечетными индексами равна: {sum}");
}

int Sum2(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
            sum = sum + array[i];
    }
    return sum;
}

Console.Clear();
System.Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
PrintArray(array);
Summ(array);
System.Console.WriteLine($"Сумма значений с нечетными индексами равна: {Sum2(array)}");
