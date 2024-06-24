using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 54,343,745,4243,673,5,354,335,75,3,46,733 };

        Console.WriteLine("Original list:");
        PrintList(numbers);

        SelectionSort(numbers);

        Console.WriteLine("Sorted list:");
        PrintList(numbers);
    }

    static void SelectionSort(List<int> list)
    {
        int n = list.Count;
        for (int i = 0; i < n - 1; i++)
        {
            // Find the minimum element in the unsorted part
            int min = i;
            for (int j = i + 1; j < n; j++)
            {
                if (list[j] < list[min])
                {
                    min = j;
                }
            }

            // Swap the found minimum element with the first element
            int temp = list[min];
            list[min] = list[i];
            list[i] = temp;
        }
    }

    static void PrintList(List<int> list)
    {
        foreach (int item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}