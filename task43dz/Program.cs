// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Пересечение прямой А с осью координат Х: b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Угловой коэфициэнт прямой А k1 ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Пересечение прямой В с осью координат Х: b2 ");
double b2 = -Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Угловой коэфициэнт прямой В k2 ");
double k2 = Convert.ToDouble(Console.ReadLine());
if (k1 != k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
    Console.WriteLine($"Координаты точки пересечения прямых:  {y}  {x}");
}
else
{
    if (b2 == b1)
    {
        Console.WriteLine("прямые находяться друг на друге");
    }
    else
    {
        Console.WriteLine("прямые параллельны");
    }
}

// /////////////////////////////////////////////////

// // y = 5 * x + 2
// a=k1
// c=b1
// b=k2
// d=b2
// // x=(b2-b1)/(k1-k2)

// // x=(4-2)/(5-9)
// // x=2/4



