// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от M до N в обратном порядке. M = 1; N = 5. -> «5, 4, 3, 2, 1»

Console.Write("Задайте число M: ");
int m = Convert.ToInt16(Console.ReadLine());
Console.Write("Задайте число N: ");
int n = Convert.ToInt16(Console.ReadLine());

void NaturalNumber(int m, int n)
{
    if (m == n) Console.Write($" {n} ");
    else if (m < n)
    {
        Console.Write($" {n} ");
        NaturalNumber(m, n-1);
    }
    else
    {
        Console.Write($" {m} ");
        NaturalNumber(m-1, n);
    }
    
}
NaturalNumber(m, n);