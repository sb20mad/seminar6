// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
Console.WriteLine("ВВедите число ");
int n = Convert.ToInt32(Console.ReadLine());
{
int [] bin = new int [32];
int i = 0;
while (n > 0) 
{
bin[i] = n % 2;
n = n / 2;
i++;
}
for ( int o = i - 1; o >= 0; o--)
Console.Write(bin[o]);
}


