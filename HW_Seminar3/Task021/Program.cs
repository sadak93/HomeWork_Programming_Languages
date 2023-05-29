// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

decimal Length(int Xa, int Ya, int Za, int Xb, int Yb, int Zb)
{
    decimal result = Convert.ToDecimal(Math.Sqrt((Xb-Xa)*(Xb-Xa) + (Yb-Ya)*(Yb-Ya)+(Zb-Za)*(Zb-Za)));
    return result;
}

Console.Clear();
System.Console.WriteLine("Введите первую координату Xa точки А");
int Xa = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите вторую координату Ya точки А");
int Ya = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите вторую координату Za точки А");
int Za = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите первую координату Xb точки В");
int Xb = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите вторую координату Yb точки В");
int Yb = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите вторую координату Zb точки В");
int Zb = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"расстояние между точками составит {Length(Xa, Ya, Za, Xb, Yb, Zb)}");