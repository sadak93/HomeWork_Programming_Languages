// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SummNumbers(int num1, int num2)
{
    int summ = 0;
    while (true)
    {
        summ = summ + num2;
        num2--;
        if (num2 == num1-1)
            break;
    }
    return summ;
}
int SummNumbersRec(int num1, int num2)
{
    if (num2==num1)  return num1;
    return SummNumbersRec(num1, num2-1) + num2;
}
Console.Clear();
System.Console.WriteLine("Введите целое число начало: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите целое число конец: ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма от {num1} до {num2} равна {SummNumbers(num1, num2)}");
System.Console.WriteLine($"Сумма от {num1} до {num2} равна {SummNumbersRec(num1, num2)}");