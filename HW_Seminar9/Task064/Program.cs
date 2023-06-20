// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string ShowNumbers (int n)
{
    string str = "";
    while (true)
    {
        str = str + ", " + Convert.ToString(n);
        n--;
        if (n == 0)
            break;
    }
    return str;
}

string ShowNumbers2(int n)
{
    if (n == 1) return "1";
    return $"{n}, " + ShowNumbers2(n-1);
}

Console.Clear();
System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Натуральные числа в промежутке от N до 1: {ShowNumbers(n)}");
System.Console.WriteLine($"Натуральные числа в промежутке от N до 1: {ShowNumbers2(n)}");