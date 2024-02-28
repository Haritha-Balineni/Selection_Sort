/*
Author: Haritha Balineni
Date: 2/28/2023
Comments: This C# Console Application code demonstrates the
    Selection Sort Algorithm. No input
    is required for the script. It will execute without 
    input against pre-populated array. 
*/
using System;

class Program
{
    static void Main()
    {
        int[] selectionSortNumbers = { 5, 72, 3, 14, 7, 1 };

        Console.WriteLine("Original Array: ");
        PrintArray(selectionSortNumbers);

        Console.WriteLine("\nSorted Array (Selection Sort): ");
        SelectionSort(selectionSortNumbers);
        PrintArray(selectionSortNumbers);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    static void SelectionSort(int[] arr)
    {
        int minPosition, temp;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            minPosition = i;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minPosition])
                {
                    minPosition = j;
                }
            }

            if (minPosition != i)
            {
                temp = arr[i];
                arr[i] = arr[minPosition];
                arr[minPosition] = temp;
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}