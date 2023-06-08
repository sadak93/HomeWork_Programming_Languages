// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void FillArray (int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Введите {i+1}ый элемент массива");
        array[i]=Convert.ToInt32(Console.ReadLine());
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

int PositivNum (int [] array)
{
    int result = 0;
    foreach (var item in array)
    {
       if (item > 0)
            result++;
    }
    return result;
}

Console.Clear();
System.Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

FillArray(array);
PrintArray(array);

System.Console.WriteLine($"Количество значений больше 0 равно: {PositivNum(array)}");