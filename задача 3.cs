using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = GenerateRandomArray(size);
        PrintArrayFromEnd(array, array.Length - 1);
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 150);
        }

        return array;
    }

    static void PrintArrayFromEnd(int[] array, int index)
    {
        if (index < 0)
            return;

        Console.WriteLine(array[index]);
        PrintArrayFromEnd(array, index - 1);
    }
}