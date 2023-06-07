// Задача 38: Задайте массив вещественных случайных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

void FillArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=Math.Round(new Random().NextDouble()*10,2);
    }
}

void PrintArray (double[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item}| ");
    }
    System.Console.WriteLine();
}

void RaznicaMaxMin (double[] array)
{
    double max = array [0];
    double min = array [0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i]>max)
            max = array[i];
        if (array [i]<min)
            min = array[i];
    }
    System.Console.WriteLine($"Максимальное значение: {max}");
    System.Console.WriteLine(($"Минимальное значение: {min}"));
    double raznica =  Math.Round(max - min, 2);
    System.Console.WriteLine($"Разница между макс и мин значениями: {raznica}");
}

Console.Clear();
System.Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
FillArray(array);
PrintArray(array);
RaznicaMaxMin(array);