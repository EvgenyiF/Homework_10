// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N. M = 1; N = 15 -> 120 M = 4; N = 8. -> 30

Console.Write("Задайте число M: ");
int m = Convert.ToInt16(Console.ReadLine());
Console.Write("Задайте число N: ");
int n = Convert.ToInt16(Console.ReadLine());

int SummNumber(int m, int n)
{
    if (m == n)
        return m;
    else
     if (m < n)
        return m + SummNumber(m + 1, n);
    else
        return n + SummNumber(m, n + 1);

}
Console.WriteLine($"Сумма чисел в промежутке {m}:{n} равна  {SummNumber(m, n)}");