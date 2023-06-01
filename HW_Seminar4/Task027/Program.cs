// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SummaCifr (int num)
{
    int result = 0;
    int sum=0;
    int num1=num;
    while (num>0)
    {
        num1=num%10;
        sum=sum+num1;
        num=num/10;
    }
    result=sum;
    return result;   
}

Console.Clear();
System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Сумма цифр числа {num} равна: {SummaCifr(num)}");