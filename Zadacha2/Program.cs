// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int Recurcia(int start, int end)
{
    if (start == end) return end;
    if (start < end) return start + Recurcia(start + 1, end);
    else return end + Recurcia(end + 1, start);
}

Console.WriteLine("Введите натуральное число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M = {m}; N = {n} -> {Recurcia(m, n)}");