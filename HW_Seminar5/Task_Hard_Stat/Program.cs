// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, 
// среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и 
// вывести на экран с пояснениями. Найти медианное значение первоначалального массива , 
// возможно придется кое-что для этого дополнительно выполнить.

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

int MaxNum (int [] array)
{
    int max = array[0];
    int imax = 0;
     for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>max)
        {    
            max = array[i];
            imax = i;
        }
    }
    return max;
}

int IndexMaxNum (int [] array)
{
    int max = array[0];
    int imax = 0;
     for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>max)
        {    
            max = array[i];
            imax = i;
        }
    }
    return imax;
}

int MinNum (int [] array)
{
    int min = array [0];
    int imin = 0;
     for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<min)
        {
            min = array[i];
            imin = i;
        }
    }
    return min;
}

int IndexMinNum (int [] array)
{
    int min = array [0];
    int imin = 0;
     for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<min)
        {
            min = array[i];
            imin = i;
        }
    }
    return imin;
}

double Average (int [] array)
{
    double sum = 0;
    double average = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = Convert.ToDouble(sum + array[i]);
        average = Convert.ToDouble(sum/array.Length);
    }
    return average;
}

int [] SortArray (int [] array2)
{
    for (int i = 0; i < array2.Length-1; i++)
    {
        int imin = i;
        for (int j = i+1; j < array2.Length; j++)
        {
            if (array2[j]<array2[imin])
                imin = j;
        }
        int temp = array2[i];
        array2[i]=array2[imin];
        array2[imin]=temp;
    }
    return array2;
}

void Mediana (int[] array2)
{
    
    double mediana = 0;
    double sumMedian = 0;
    if (array2.Length%2==1)
        mediana = array2[array2.Length/2];
    else
        {
            sumMedian = Convert.ToDouble(array2[array2.Length/2]+array2[array2.Length/2-1]);
            mediana = Convert.ToDouble(sumMedian/2);
        }   
    System.Console.WriteLine($"Медианное значения массива: {mediana}");
}

Console.Clear();
System.Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int[] array2 = array;

FillArray(array);
PrintArray(array);

System.Console.WriteLine($"Максимальное значение: {MaxNum(array)}");
System.Console.WriteLine($"Индекс макс значения: {IndexMaxNum(array)}");
System.Console.WriteLine($"Минимальное значение: {MinNum(array)}");
System.Console.WriteLine($"Индекс мин значения: {IndexMinNum(array)}");
System.Console.WriteLine($"Среднее арифметическое значение:{Average(array)}");
PrintArray(SortArray(array));
Mediana(array2);



// void MathParametr(int[] array)
// {
//     int max = array[0];
//     int imax = 0;
//     int min = array [0];
//     int imin = 0;
//     double sum = 0;
//     double average = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]>max)
//         {    
//             max = array[i];
//             imax = i;
//         }
//         if (array[i]<min)
//         {
//             min = array[i];
//             imin = i;
//         }
//         sum = Convert.ToDouble(sum + array[i]);
//         average = Convert.ToDouble(sum/array.Length);

//     }
//     System.Console.WriteLine(max);
//     System.Console.WriteLine(imax);
//     System.Console.WriteLine(min);
//     System.Console.WriteLine(imin);
//     System.Console.WriteLine(sum);
//     System.Console.WriteLine(average);
// }