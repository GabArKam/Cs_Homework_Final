// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое натуральное число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Interval(m, n));


int Interval(int m, int n)
{
    if(m==n) return m;
    else return n + Interval(m, n-1);
}