// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать 
//треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Console.WriteLine("Ведите длинну отрезка ab ");
int ab = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите длинну отрезка bc ");
int bc = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите длинну отрезка ca ");
int ca = Convert.ToInt32(Console.ReadLine());
if (ab<bc+ca & bc<ab+ca & bc<ab+ca)
{
      Console.WriteLine("Такой треугольник существует");
}
else
{
    Console.WriteLine("Такой треугольник не может существовать");
}