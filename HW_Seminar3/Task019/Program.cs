// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
System.Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num5razryad=num / 10000, 
    num4razryad=(num / 1000) % 10,
    num2razryad=(num % 100) / 10,
    num1razryad=num % 10;

if (num5razryad == num1razryad && num4razryad == num2razryad)
    System.Console.WriteLine("yes");
else
    System.Console.WriteLine("no");