// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.

Console.Clear();

System.Console.WriteLine("Введите кол-во пространства N: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] KoordA = new int[N];
int[] KoordB = new int[N];

for (int i = 0; i < N; i++)
{
    Console.Write($"Координата {i + 1} точки А: ");
    KoordA[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < N; i++)
{
    Console.Write($"Координата {i + 1} точки B: ");
    KoordB[i] = Convert.ToInt32(Console.ReadLine());
}

int kvadratRaznici=0;
for (int i=0; i<N; i++)
{
    int Raznica = (KoordB[i] - KoordA[i]);
    kvadratRaznici += Raznica * Raznica;
}
double sqrt = Math.Round(Math.Sqrt(Convert.ToDouble(kvadratRaznici)),2);
System.Console.WriteLine($"Растояние между точками А и В: {sqrt}");



