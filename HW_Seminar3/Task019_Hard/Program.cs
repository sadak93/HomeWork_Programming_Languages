// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, 
// является ли оно палиндромом. Через строку нельзя решать само собой.

Console.Clear();
System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1=num;
int revnum=0;
int div = 0;
while (num1>0)
{
    div=num1%10;
    revnum=revnum*10+div;
    num1=num1/10;
}
if (num==revnum)
    System.Console.WriteLine("Число является палиндромом");
else
    System.Console.WriteLine("Число не является палиндромом");
