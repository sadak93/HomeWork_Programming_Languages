// Задача 26 HARD Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4
int CountNumCeloe(int numCeloe)
{
    int result = 0;
    while (numCeloe > 0)
    {
        numCeloe = numCeloe / 10;
        result++;
    }
    return result;
}
int CountNumDrob(decimal numDrob)
{
    int result = 0;
    while (numDrob > 0 && numDrob < 1)
    {
        decimal x = numDrob * 10;
        int xCeloe = Convert.ToInt32(Math.Floor(x));
        numDrob = x - xCeloe;
        result++;
    }
    return result;
}
Console.Clear();
System.Console.WriteLine("Введите целое или дробное число: ");
decimal num = Convert.ToDecimal(Console.ReadLine());
int numCeloe = Convert.ToInt32(Math.Floor(num));
decimal numDrob = num - numCeloe;
int count = CountNumCeloe(numCeloe) + CountNumDrob(numDrob);
System.Console.WriteLine($"Количество цифр в числе: {count}");


// Console.Clear();
// System.Console.WriteLine("Введите целое или дробное число: ");
// decimal num = Convert.ToDecimal(Console.ReadLine());
// int numCeloe = Convert.ToInt32(Math.Floor(num));
// decimal numDrob = num - numCeloe;

// int count1 = 0;
// while (numCeloe > 0)
// {
//     numCeloe = numCeloe / 10;
//     count1++;
// }

// int count2 = 0;
// while (numDrob > 0 && numDrob < 1)
// {
//     decimal x = numDrob * 10;
//     int xCeloe = Convert.ToInt32(Math.Floor(x));
//     numDrob = x - xCeloe;
//     count2++;
// }

// int count = count1 + count2;
// System.Console.WriteLine($"Количество цифр в числе: {count}");
