// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrom(int num)
{
    int num5razryad = num / 10000,
        num4razryad = (num / 1000) % 10,
        num2razryad = (num % 100) / 10,
        num1razryad = num % 10;

    if (num5razryad == num1razryad && num4razryad == num2razryad)
        System.Console.WriteLine("yes");
    else
        System.Console.WriteLine("no");
}

Console.Clear();
System.Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

Palindrom(num);

// string Palindrom1(int num)
// {
//     string result = "";
//     int num5razryad = num / 10000,
//         num4razryad = (num / 1000) % 10,
//         num2razryad = (num % 100) / 10,
//         num1razryad = num % 10;

//     if (num5razryad == num1razryad && num4razryad == num2razryad)
//         result = "yes";
//     else
//         result = "no";
//     return result;
// }

// Console.Clear();
// System.Console.Write("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(Palindrom1(num));
