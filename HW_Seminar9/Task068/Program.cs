// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermannRec(int m, int n)
{
    if (m==0) return n+1;
    if (n==0) return AckermannRec(m-1,1);
    return AckermannRec(m-1,AckermannRec(m,n-1));
}

Console.Clear();
System.Console.WriteLine("Введите целое число m");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите целое число n");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"A({m},{n}): {AckermannRec(m,n)}");