using System;

namespace SelectionSort
{
    class Program
    {
        static void Main()
        {
            int[] arr = GenerateRandomArray(10, 1, 100);

            Console.WriteLine("Original Array:");
            PrintArray(arr);

            SelectionSort(arr);

            Console.WriteLine("\nSorted Array:");
            PrintArray(arr);
        }

        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            // Outer loop for selecting the minimum element
            for (int i = 0; i < n - 1; i++)
            {
                // Assume the current index contains the minimum element
                int minIndex = i;

                // Inner loop to find the minimum element
                for (int j = i + 1; j < n; j++)
                {
                    // Compare the current minimum with the current element
                    if (arr[j] < arr[minIndex])
                    {
                        // Update the index of the minimum element
                        minIndex = j;
                    }
                }

                // Swap the minimum element with the current element
                if (minIndex != i)
                {
                    Swap(arr, i, minIndex);
                }
            }
        }

        static void Swap(int[] arr, int i, int j)
        {
            // Swap two elements in the array
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static int[] GenerateRandomArray(int size, int minValue, int maxValue)
        {
            // Generate an array of random integers
            Random random = new Random();
            int[] randomArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                randomArray[i] = random.Next(minValue, maxValue + 1);
            }

            return randomArray;
        }

        static void PrintArray(int[] arr)
        {
            // Print the elements of the array
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
