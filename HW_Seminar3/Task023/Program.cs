// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// int Kub(int num)
// {
//     int result = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         int kub = Convert.ToInt32(Math.Pow(i, 3));
//         result = kub;
//     }
//     return result;
// }
// Console.Clear();
// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.Write($"{Kub(num)}, ");

void Kub(int num)
{
    for (int i = 1; i <= num; i++)
    {
        int result = Convert.ToInt32(Math.Pow(i, 3));
        System.Console.Write($"{result}, ");
    }
}
Console.Clear();
System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Kub(num);


// Console.Clear();
// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= num; i++)
// {
//     int result = Convert.ToInt32(Math.Pow(i, 3));
//     System.Console.Write($"{result}, ");
// }