// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

bool Lines (double k1, double b1, double k2, double b2)
{
    if (k1==k2)
        {
            if (b1==b2)
            {
                System.Console.WriteLine("Прямые совпадают");
                return false;
            }
            else
            {
                System.Console.WriteLine("Прямые параллельны");
                return false;
            }

        }
    return true;
}

void Point2 (double k1, double b1, double k2, double b2)
{
    double x = (b2-b1)/(k1-k2);
    double y = k1*x+b1;
    System.Console.WriteLine($"Имеет координаты ({x};{y})");
}

Console.Clear();
System.Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double [] array = new double [2];

if (Lines(k1, b1, k2, b2))
{
    System.Console.Write($"Точка пересечения уравнений y={k1}*x+{b1} и y={k2}*x+{b2} ");
    Point2 (k1, b1, k2, b2);
}

