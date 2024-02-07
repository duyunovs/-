using System;

class Program
{
    static void Main()
    {
        Console.Write("Первое число (M): ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Второе число (N): ");
        int n = int.Parse(Console.ReadLine());

        PrintNumbers(m, n);
    }

    static void PrintNumbers(int m, int n)
    {
        if (m > n)
        {
            return;
        }
        else
        {
            Console.WriteLine(m);
            PrintNumbers(m + 1, n);
        }
    }
}
