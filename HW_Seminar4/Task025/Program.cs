// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Stepen (int A, int B)
{
    int result = 0;
    result = Convert.ToInt32(Math.Pow(A,B));
    return result;
    
}

Console.Clear();
System.Console.WriteLine("Введите число которое нужно возвести в степень: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень: ");
int B = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Полученный результат: {Stepen(A,B)}");


// void Stepen (int A, int B)
// {
//     int result = Convert.ToInt32(Math.Pow(A,B));
//     System.Console.WriteLine($"Полученный результат: {result}");
// }

// Console.Clear();
// System.Console.WriteLine("Введите число которое нужно возвести в степень: ");
// int A = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите степень: ");
// int B = Convert.ToInt32(Console.ReadLine());

// Stepen(A,B);
