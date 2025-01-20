using System;

namespace Assignment3_7G
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get array size from the user
            Console.Write("Enter the Number of element in the array: ");
            int size;

            // Validate the array size
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a positive integer for the array size.");
            }

            // Initialize the array based on the user input size
            int[] array = new int[size];

            // Get the elements of the array from the user
            Console.WriteLine("Enter the elements of the array:/n");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Invalid input! Please enter an integer.");
                    Console.Write($"Element {i + 1}: ");
                }
            }

            //// Display the array
            //Console.WriteLine("\nArray entered by the user:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();

            //// Initialize the variables to store smallest and second smallest
            //int smallest = int.MaxValue;
            //int secondSmallest = int.MaxValue;

            //// Find the second smallest element
            //for (int i = 0; i < size; i++)
            //{
            //    if (array[i] < smallest)
            //    {
            //        secondSmallest = smallest;
            //        smallest = array[i];
            //    }
            //    else if (array[i] < secondSmallest && array[i] != smallest)
            //    {
            //        secondSmallest = array[i];
            //    }
            //}

            //// Display the second smallest element
            //if (secondSmallest == int.MaxValue)
            //{
            //    Console.WriteLine("\nThere is no second smallest element in the array.");
            //}
            //else
            //{
            //    Console.WriteLine($"\nThe second smallest element is: {secondSmallest}");
            //}

            //Console.WriteLine("\nPress any key to exit...");
            //Console.ReadLine();
            // Corrected sorting logic using indices
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (array[i] > array[j])
                    {
                        // Swap the elements
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("second largest number in array:");
            Console.Write(array[1]);

            //// Output the sorted array
            //Console.WriteLine("Array elements in descending order:");
            //foreach (int num in array)
            //{
            //Console.Write(num + " ");
            //}

        }
    }
}