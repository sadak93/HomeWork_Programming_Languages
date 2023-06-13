// Задача VERY HARD необязательная Имеется массив случайных целых чисел. Создайте массив, 
// в который попадают числа, описывающие максимальную сплошную возрастающую последовательность. 
// Порядок элементов менять нельзя. Одно число - это не последовательность.

// Пример:

// [1, 5, 2, 3, 4, 6, 1, 7] => [1, 7] так как здесь вразброс присутствуют все числа от 1 до 7

// [1, 5, 2, 3, 4, 1, 7, 8 , 15 , 1 ] => [1, 5] так как здесь есть числа от 1 до 5 и эта последовательность 
// длиннее чем от 7 до 8

// [1, 5, 3, 4, 1, 7, 8 , 15 , 1 ] => [3, 5] так как здесь есть числа от 3 до 5 и эта последовательность 
// длиннее чем от 7 до 8

void FillArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(0,10);
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

int Line (int [] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<min)
            min = array[i];
    }
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j]==min)
            {
                count++;
            }
        }
        min=min+1;
    }
    return count;
}

// int Line2 (int [] array)
// {
//     int max = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]>max)
//             max = array[i];
//     }
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]==max-1)
//             {
//                 count++;
//             }
//         max=max-1;
//     }
//     return count;
// }

Console.Clear();
System.Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

FillArray(array);
PrintArray(array);

System.Console.WriteLine(Line(array));

// System.Console.WriteLine(Line2(array));