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

void MathParametr(int[] array)
{
    int max = array[0];
    int imax = 0;
    int min = array [0];
    int imin = 0;
    double sum = 0;
    double average = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>max)
        {    
            max = array[i];
            imax = i;
        }
        if (array[i]<min)
        {
            min = array[i];
            imin = i;
        }
        sum = Convert.ToDouble(sum + array[i]);
        average = Convert.ToDouble(sum/array.Length);

    }
    System.Console.WriteLine(max);
    System.Console.WriteLine(imax);
    System.Console.WriteLine(min);
    System.Console.WriteLine(imin);
    System.Console.WriteLine(sum);
    System.Console.WriteLine(average);
}

void Mediana (int[] array)
{
    double mediana = 0;
    double sumMedian = 0;
    if (array.Length%2==1)
        mediana = array[array.Length/2];
    else
        sumMedian = Convert.ToDouble(array[array.Length/2]+array[array.Length/2-1]);
        mediana = Convert.ToDouble(sumMedian/2);   
    System.Console.WriteLine(mediana);
}

Console.Clear();
System.Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int[] array2 = array;

FillArray(array);
PrintArray(array);
MathParametr(array);
Mediana(array);
PrintArray(array2);
System.Console.WriteLine($"{MaxNum(array)}");