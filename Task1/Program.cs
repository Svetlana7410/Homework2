// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.   

void PrintNumbers(int m, int n)
{
    if (m > n)
    {
        return;
    } 
    Console.WriteLine(m);
    PrintNumbers(m + 1, n);
}
Console.Write("Enter M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());

PrintNumbers(M, N);