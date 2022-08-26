// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
GetBinaryView(number);
void GetBinaryView (int n)
{
    if (n<=0) return;
    GetBinaryView(n\2);
    GetBinaryWrite(n%2);

}